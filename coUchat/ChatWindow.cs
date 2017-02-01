using System;
using System.Windows.Forms;

namespace coUchat {
	public partial class ChatWindow : Form {
		public readonly Channel Channel;
		private string RtfLog = @"{\rtf1\ansi ";
		private string TxtLog = "";

		public ChatWindow(Channel channel) {
			Channel = channel;

			InitializeComponent();

			Text += ": " + Channel.StreetName;

			Show();
		}

		public void UpdateStatus(string status = "") {
			if (status.Length > 0) {
				StatusButton.Text = status;
			} else {
				StatusButton.Text = Channel.Connected ? "Connected. Click to disconnect." : "Not Connected. Click to connect.";
				MessageEntry.Enabled = SendButton.Enabled = Channel.Connected;
			}

			MessageEntry.Invoke((MethodInvoker) delegate {
				MessageEntry.Enabled = Channel.Connected;
			});

			SendButton.Invoke((MethodInvoker) delegate {
				SendButton.Enabled = Channel.Connected;
			});
		}

		public void ListUsers(string[] users) {
			UserView.Invoke((MethodInvoker) delegate {
				UserView.Nodes.Clear();
				UserView.Nodes.Add(new TreeNode(Program.UI.Username));
			});

			foreach (string user in users) {
				UserView.Invoke((MethodInvoker) delegate {
					UserView.Nodes.Add(new TreeNode(user.Trim()));
				});
			}
		}

		public void PushMessage(Message message) {
			if ((message.Text ?? "").Trim().Length == 0 || (message.Username ?? "").Trim().Length == 0) {
				Console.WriteLine("Not showing message: {0}", message);
				return;
			}

			RtfLog += message.ToRtf();
			TxtLog += message.ToTxt();
			MsgView.Invoke((MethodInvoker) delegate {
				MsgView.Rtf = RtfLog + "}";
			});
		}

		private void MessageEntry_TextChanged(object sender, EventArgs e) {
			Console.WriteLine(MessageEntry.Text);
			SendButton.Enabled = MessageEntry.Text.Trim().Length > 0;
		}

		private void StatusButton_ButtonClick(object sender, EventArgs e) {
			Channel.Connected = !Channel.Connected;
		}

		private void SendButton_Click(object sender, EventArgs e) {
			Channel.Send(new Message {
				Channel = Channel.StreetName,
				Username = Program.UI.Username,
				Text = MessageEntry.Text.Trim()
			});

			MessageEntry.Text = "";
		}

		private void UserView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
			System.Diagnostics.Process.Start(Properties.Resources.ProfileUrl + e.Node.Text);
		}

		private void ChatWindow_Shown(object sender, EventArgs e) {
			UpdateStatus();
			Channel.Connected = true;
			UpdateStatus();
		}

		private void ChatWindow_FormClosing(object sender, FormClosingEventArgs e) {
			Storage.LogChat(Channel.StreetName, TxtLog);
		}
	}
}
