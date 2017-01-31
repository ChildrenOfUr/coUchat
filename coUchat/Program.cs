using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace coUchat {
    public static class Program {
		public static MainWindow UI;
		public static List<Channel> Channels = new List<Channel>();

        [STAThread]
        public static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			UI = new MainWindow();
            Application.Run(UI);
        }
    }
}
