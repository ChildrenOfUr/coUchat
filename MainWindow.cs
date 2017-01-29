using System;
using coUchat;
using Gtk;

public partial class MainWindow : Gtk.Window {
	private string LastStreet = "";

	public MainWindow() : base (Gtk.WindowType.Toplevel) {
		#pragma warning disable RECS0021 // Warns about calls to virtual member functions occuring in the constructor
		Build();

		#pragma warning restore RECS0021 // Warns about calls to virtual member functions occuring in the constructor
		UsernameEntry.Text = Storage.Username;
	}

	public Message Fields {
		get {
			return new Message {
				Channel = ChannelSelect.ActiveText.Trim(),
				Username = UsernameEntry.Text.Trim(),
				Text = MessageEntry.Text.Trim()
			};
		}
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a) {
		Storage.Username = UsernameEntry.Text;
		Storage.LogChat(ChannelSelect.ActiveText, ConvoView.Buffer.Text);

		Application.Quit();
		a.RetVal = true;
	}

	public void PopulateStreetList() {
		foreach (string streetName in Storage.LocalChats ?? Server.ListStreets()) {
			ChannelSelect.AppendText(streetName);
		}
	}

	public void PushMessage(Message message) {
		try {
			ConvoView.Buffer.Text += message.ToString() + "\n\n";
		} catch {
			MainClass.Dialog.Open("Invalid character in message");
		}
		ConvoView.ScrollToIter(ConvoView.Buffer.EndIter, 0, false, 0, 0);
	}

	public void ListUsers(string[] users) {
		UserList.Buffer.Text = "";

		foreach (string user in users) {
			UserList.Buffer.Text += user.Trim() + "\n";
		}
	}

	public void Status(string status = "") {
		MessageEntry.Text = status;

		if (status.Length == 0) {
			MessageEntry.Sensitive = SendButton.Sensitive = true;
		} else {
			MessageEntry.Sensitive = SendButton.Sensitive = false;
		}

		if (Server.Connected) {
			SendButton.Label = "Send";
			MessageEntry.Sensitive = true;
		} else {
			SendButton.Label = "Connect";
			MessageEntry.Sensitive = false;
		}
	}

	protected void SendClicked(object sender, EventArgs e) {
		Message sending = Fields;

		if (Server.Connected) {
			if (sending.Channel.Length == 0) {
				MainClass.Dialog.Open("Please select a channel.");
			} else if (sending.Username.Length == 0) {
				MainClass.Dialog.Open("Please enter a username.");
			} else if (sending.Text.Length == 0) {
				MainClass.Dialog.Open("You can't send a blank message.");
			} else {
				MessageEntry.Text = "";
				Server.Send(sending);
			}
		} else {
			Server.Connect();
		}
	}

	protected void OnMessageEntryKeyReleaseEvent(object o, KeyReleaseEventArgs args) {
		if (args.Event.Key == (Gdk.Key.Return)) {
			SendClicked(o, args);
		}
	}

	protected void OnChannelSelectChanged(object sender, EventArgs e) {
		Server.Send(new Message(Fields) {
			Command = "changeStreet",
			OldStreet = LastStreet,
			NewStreet = Fields.Channel
		});

		LastStreet = Fields.Channel;

        Storage.LogChat(Fields.Channel, ConvoView.Buffer.Text);
        ConvoView.Buffer.Text = "";
	}
}
