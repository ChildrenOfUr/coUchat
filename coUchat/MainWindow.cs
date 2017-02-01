using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coUchat {
	public partial class MainWindow : Form {
		private bool _Connected = false;

		public bool Connected {
			get {
				return _Connected;
			}

			set {
				_Connected = value;

				ServerOpts.Invoke((MethodInvoker) delegate {
					ServerOpts.Enabled = !value;
				});

				UsernameEntry.Invoke((MethodInvoker) delegate {
					UsernameEntry.Enabled = !value;
				});

				ChannelList.Invoke((MethodInvoker) delegate {
					ChannelList.Enabled = value;
				});
				
				ConnectBtn.Invoke((MethodInvoker) delegate {
					ConnectBtn.Text = value ? "Disconnect" : "Connect";
				});

				UpdateStatus();
			}
		}

		public MainWindow() {
			InitializeComponent();

			Task.Run(() => Connected = false);

			Task.Run(() => UsernameEntry.Invoke((MethodInvoker) delegate {
				UsernameEntry.Text = Storage.Username;
			}));
		}

		public void UpdateStatus(string status = "") {
			Invoke((MethodInvoker) delegate {
				if (status.Trim().Length > 0) {
					StatusText.Text = status;
				} else {
					StatusText.Text = Connected ? "Connected" : "Not Connected";
				}
			});
		}

		public string SelectedServerUrl {
			get {
				if (ServerLocal.Checked) {
					return Properties.Resources.ServerUrlLocal;
				}

				if (ServerDev.Checked) {
					return Properties.Resources.ServerUrlDev;
				}

				if (ServerLive.Checked) {
					return Properties.Resources.ServerUrlLive;
				}

				return null;
			}
		}

		public string Username {
			get {
				return UsernameEntry.Text.Trim();
			}
		}

		public void ListChannels(string[] channels) {
			ChannelList.Items.Clear();
			ChannelList.Items.Add("Global Chat");
			ChannelList.Items.AddRange(channels);
		}

		private void ConnectBtn_Click(object sender, EventArgs e) {
			if (!Connected) {
				UpdateStatus("Connecting...");

				try {
					UpdateStatus("Downloading street list...");
					ListChannels(Server.ListStreets());
					Connected = true;
				} catch (Exception ex) {
					UpdateStatus($"Connection error: {ex.Message}");
				}

				try {
					UpdateStatus("Reconnecting channels...");

					foreach (Channel channel in Program.Channels) {
						channel.Connected = true;
					}

					UpdateStatus("Reconnected channels");

					Task.Run(() => {
						Thread.Sleep(1000);
						UpdateStatus();
					});
				} catch (Exception ex) {
					UpdateStatus($"Couldn't reconnect channels: {ex.Message}");
				}
			} else {
				UpdateStatus("Disconnecting...");
				Connected = false;

				foreach (Channel channel in Program.Channels) {
					channel.Connected = false;
				}
			}
		}

		private void UsernameEntry_TextChanged(object sender, EventArgs e) {
			if (UsernameEntry.Text.Trim().Length > 0) {
				ConnectBtn.Enabled = true;
				UpdateStatus("Ready");
			} else {
				ConnectBtn.Enabled = false;
				UpdateStatus("Enter a username");
			}
		}

		private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) {
			Connected = false;
			Storage.Username = Username;
		}

		private void ChatButton_Click(object sender, EventArgs e) {
			Program.Channels.Add(new Channel(ChannelList.Text));
		}

		private void ChannelList_SelectedValueChanged(object sender, EventArgs e) {
			ChatButton.Enabled = (ChannelList.Text ?? "") != "";
		}
	}
}
