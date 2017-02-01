using System.IO;
using System.Net;

namespace coUchat {
	public static class Server {
		public static string Selected {
			get {
				return Program.UI.SelectedServerUrl;
			}
		}

		public static string StreetsUrl {
			get {
				return $"http://{Selected}:{Properties.Resources.HttpPort}/listStreets";
			}
		}

		public static string ChatUrl {
			get {
				string protocol = Selected == Properties.Resources.ServerUrlLive ? "wss" : "ws";
				return $"{protocol}://{Selected}:{Properties.Resources.WsPort}/chat";
			}
		}

		public static string[] ListStreets() {
			Stream response = WebRequest.Create(StreetsUrl).GetResponse().GetResponseStream();
			string lines = new StreamReader(response).ReadToEnd();
			string[] streetNames = lines.Split('\n');
			return streetNames;
		}
	}
}
