using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebSocketSharp;

namespace coUchat {
	public static class Server {
		public const string Host = "localhost";
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
					JObject message = (JObject) JsonConvert.DeserializeObject(e.Data);
					if ((string) message["statusMessage"] == "ping") {
						Socket.Send("{\"statusMessage\": \"pong\"}");
					} else if ((string) message["statusMessage"] == "list") {
						MainClass.Window.PushMessage(e.Data);
					} else {
						MainClass.Window.PushMessage(e.Data);
					}
				} catch (Exception ex) {
					MainClass.Dialog.Open($"Error parsing server response:\n{e.Data}\n\n{ex.Message}");
				}
			};

			Socket.OnOpen += (sender, e) => {
				MainClass.Window.Status("Connected");
				Thread.Sleep(500);
				MainClass.Window.Status();

				Socket.Send(JsonConvert.SerializeObject(new Dictionary<string, string>() {
					{"channel", MainClass.Window.Channel},
					{"street", MainClass.Window.Channel},
					{"username", MainClass.Window.Username},
					{"statusMessage", "list"}
				}));
			};

			Socket.OnClose += (sender, e) => {
				MainClass.Dialog.Open($"The connection to the server was lost:\n{Socket.Url}\n\n{e.Code}: {e.Reason}");
				MainClass.Window.Status();
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

		public static void Send(string channel, string username, string message) {
			if (channel.Length == 0) {
				MainClass.Dialog.Open("Please select a channel.");
			} else if (username.Length == 0) {
				MainClass.Dialog.Open("Please enter a username.");
			} else if (message.Length == 0) {
				MainClass.Dialog.Open("You can't send a blank message.");
			} else {
				Socket.Send(JsonConvert.SerializeObject(new Dictionary<string, string> () {
					{"username", username},
					{"channel", channel},
					{"street", channel},
					{"message", message}
				}));

				MainClass.Window.PushMessage(message, username);
			}
		}
	}
}
