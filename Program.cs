using System;
using Gtk;

namespace coUchat {
	class MainClass {
		public static MainWindow Window;
		public static Dialog Dialog;

		public static void Main(string[] args) {
			Application.Init();

			Window = new MainWindow();
			Dialog = new Dialog();

			Window.PopulateStreetList();

			Application.Run();
		}
	}
}
