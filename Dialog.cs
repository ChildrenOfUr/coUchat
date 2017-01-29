namespace coUchat {
	public partial class Dialog : Gtk.Dialog {
		private bool Initialized = false;

		public void Open(string text) {
			if (!Initialized) {
				Build();
				Initialized = true;
			}

			DialogText.Text = text;
			ShowNow();
		}

		protected void OnCloseButtonClicked(object sender, System.EventArgs e) {
			Hide();
		}
	}
}
