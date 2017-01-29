using System;
using System.IO;
using System.Net;
using System.Threading;
using Newtonsoft.Json;
using WebSocketSharp;

namespace coUchat {
	public static class Server {
		#if DEBUG
			public const string Host = "localhost";
		#else
			public const string Host = "robertmcdermot.com";
		#endif

		public const string StreetsUrl = "http://" + Host + ":8181/listStreets";
		public const string ChatUrl = Host + ":8282/chat";

		public static bool Connected {
			get {
				return Socket != null && Socket.ReadyState == WebSocketState.Open;
			}
		}

		private static WebSocket Socket;

		public static string[] ListStreets() {
			Stream response = WebRequest.Create(StreetsUrl).GetResponse().GetResponseStream();
			string lines = new StreamReader(response).ReadToEnd();
			string[] streetNames = lines.Split('\n');
			Storage.LocalChats = streetNames;
			return streetNames;
		}

		private static void InitSocket() {
			string url = (Host == "localhost" ? "ws://" : "wss://") + ChatUrl;
			Socket = new WebSocket(url);

			Socket.OnMessage += (sender, e) => {
				try {
					Message message = JsonConvert.DeserializeAnonymousType(e.Data, new Message());

					if (message.Command == "ping") {
						SendCommand("pong");
						SendCommand("list");
					} else if (message.Command == "list") {
						MainClass.Window.ListUsers(message.UserList);
					} else {
						MainClass.Window.PushMessage(message);
					}
				} catch (Exception ex) {
					MainClass.Dialog.Open($"Error parsing server response:\n{e.Data}\n\n{ex.Message}");
				}
			};

			Socket.OnOpen += (sender, e) => {
				MainClass.Window.Status("Connected");
				Thread.Sleep(500);
				MainClass.Window.Status();

				SendCommand("join");
				SendCommand("list");
			};

			Socket.OnClose += (sender, e) => {
				MainClass.Dialog.Open($"The connection to the server was lost:\n{Socket.Url}\n\n{e.Code}: {e.Reason}");
				//MainClass.Window.Status();
			};
		}

		public static void Connect() {
			MainClass.Window.Status("Connecting...");

			if (Socket == null) {
				InitSocket();
			}

			try {
				Socket.Connect();
			} catch (Exception ex) {
				MainClass.Dialog.Open($"Could not connect to the server:\n\n{Socket.Url}\n\n{ex.Message}");
			}
		}

		public static void Send(Message message) {
			string json = JsonConvert.SerializeObject(message);

            if (json == null) {
                return;
            }

			Socket.Send(json);
		}

		public static void SendCommand(string command) {
			Send(new Message(MainClass.Window.Fields) { Command = command });
		}
	}
}
