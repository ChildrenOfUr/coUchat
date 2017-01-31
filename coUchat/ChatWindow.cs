using System;
using System.Windows.Forms;

namespace coUchat {
	public partial class ChatWindow : Form {
		public readonly Channel Channel;

		public ChatWindow(Channel channel) {
			Channel = channel;

			InitializeComponent();
			Text += ": " + Channel.StreetName;
			Show();
		}

		public void UpdateStatus(string status = "") {
			if (status.Length > 0) {
				ConnectStatus.Text = status;
			} else {
				ConnectStatus.Text = Channel.Connected ? "Connected" : "Not Connected";
			}

			MessageEntry.Enabled = SendButton.Enabled = Channel.Connected;
		}

		public void ListUsers(string[] users) {
			UserView.Invoke((MethodInvoker) delegate {
				UserView.Nodes.Clear();
			});

			foreach (string user in users) {
				UserView.Invoke((MethodInvoker) delegate {
					UserView.Nodes.Add(new TreeNode(user.Trim()));
				});
			}
		}

		public void PushMessage(Message message) {
			MessageView.Invoke((MethodInvoker) delegate {
				MessageView.AppendText(message.ToString() + "\n\n");
			});
		}

		private void SendBtn_Click(object sender, EventArgs e) {
			Channel.Send(new Message {
				Channel = Channel.StreetName,
				Username = Program.UI.Username,
				Text = MessageEntry.Text.Trim()
			});

			MessageEntry.Text = "";
		}

		private void UserView_AfterSelect(object sender, TreeViewEventArgs e) {
			System.Diagnostics.Process.Start(Properties.Resources.ProfileUrl + e.Node.Text);
		}

		private void ConnectStatus_ButtonClick(object sender, EventArgs e) {
			Channel.Connected = !Channel.Connected;
		}

		private void MessageEntry_Enter(object sender, EventArgs e) {
			SendBtn_Click(sender, e);
		}

		private void MessageEntry_KeyPress(object sender, KeyPressEventArgs e) {
			SendButton.Enabled = MessageEntry.Text.Trim().Length > 0;
		}
	}
}
