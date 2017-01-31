using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coUchat {
    public partial class MainWindow : Form {
		private bool _Connected = false;

		private bool Connected {
			get {
				return _Connected;
			}

			set {
				_Connected = value;

				Invoke((MethodInvoker) delegate {
					ServerOpts.Enabled = !value;
					UsernameEntry.Enabled = !value;
					ChannelList.Enabled = value;
					ConnectBtn.Text = value ? "Disconnect" : "Connect";
					UpdateStatus(value ? "Connected" : "Not Connected");
				});
			}
		}

        public MainWindow() {
            InitializeComponent();

			Task.Run(() => Connected = false);

			Task.Run(() => UsernameEntry.Invoke((MethodInvoker) delegate {
				UsernameEntry.Text = Storage.Username;
			}));
		}

        public void UpdateStatus(string status) {
            StatusLabel.Text = status;
        }

        public string SelectedServerUrl {
			get {
				if (ServerLocal.Checked) return Properties.Resources.ServerUrlLocal;
				if (ServerDev.Checked) return Properties.Resources.ServerUrlDev;
				if (ServerLive.Checked) return Properties.Resources.ServerUrlLive;
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
