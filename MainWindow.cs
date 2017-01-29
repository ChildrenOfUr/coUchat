using System;
using coUchat;
using Gtk;

public partial class MainWindow : Gtk.Window {
	public MainWindow() : base (Gtk.WindowType.Toplevel) {
		#pragma warning disable RECS0021 // Warns about calls to virtual member functions occuring in the constructor
		Build();

		#pragma warning restore RECS0021 // Warns about calls to virtual member functions occuring in the constructor
		UsernameEntry.Text = Storage.Username;
	}

	public string Username {
		get {
			return UsernameEntry.Text.Trim();
		}
	}

	public string Channel {
		get {
			return ChannelSelect.ActiveText.Trim();
		}
	}

	public string Message {
		get {
			return MessageEntry.Text.Trim();
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

	public void PushMessage(string message, string username = "") {
		Console.WriteLine("[{0}] {1}", username, message); 
		if (username.Length == 0) {
			ConvoView.Buffer.Text += $"\n\n{message}\n\n";
		} else {
			ConvoView.Buffer.Text += $"\n[{username}] {message}\n\n";
		}
		ConvoView.ScrollToIter(ConvoView.Buffer.EndIter, 0, false, 0, 0);
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
		if (Server.Connected) {
			Server.Send(Channel, Username, Message);
		} else {
			Server.Connect();
		}
	}

	protected void ChannelChanged(object sender, EventArgs e) {
		Storage.LogChat(ChannelSelect.ActiveText, ConvoView.Buffer.Text);
		ConvoView.Buffer.Text = "";
	}

	protected void OnMessageEntryKeyReleaseEvent(object o, KeyReleaseEventArgs args) {
		if (args.Event.Key == (Gdk.Key.Return)) {
			SendClicked(o, args);
		}
	}
}
