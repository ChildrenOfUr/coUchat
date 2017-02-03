using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebSocketSharp;

namespace coUchat {
	public class Channel : IDisposable {
		private WebSocket Socket;

		public readonly ChatWindow Window;

		public readonly string StreetName;

		public bool Connected {
			get {
				return Socket != null && Socket.ReadyState == WebSocketState.Open;
			}

			set {
				if (value) {
					if (!Program.UI.Connected) {
						Program.UI.Connected = true;
					}

					try {
						Window.UpdateStatus("Connecting...");
						Socket.Connect();
					} catch (Exception ex) {
						Window.UpdateStatus($"Couldn't connect: {ex.Message}");
					}
				} else {
					try {
						Send(new Message {
							Command = "leave",
							OldStreet = StreetName
						});

						Task.Run(() => Socket.Close());
						Window.UpdateStatus();
					} catch (Exception ex) {
						Window.UpdateStatus($"Couldn't disconnect: {ex.Message}");
					}
				}
			}
		}

		public Channel(string streetName) {
			StreetName = streetName;
			Window = new ChatWindow(this);

			Socket = new WebSocket(Server.ChatUrl);

			Socket.OnMessage += (sender, e) => {
				Message message;

				try {
					message = JsonConvert.DeserializeAnonymousType(e.Data, new Message());
				} catch (Exception ex) {
					Window.UpdateStatus($"Invalid server message ({e.Data}) {ex.Message}");
					return;
				}

				try {
					if (message.Command == "ping") {
						Send(new Message { Command = "pong" });
						Send(new Message {
							Command = "list",
							Channel = StreetName,
							NewStreet = StreetName
						});
					} else if (message.Command == "list") {
						Window.ListUsers(message.UserList);
					} else if (message.Text.Length > 0) {
						Window.PushMessage(message);
					}
				} catch (Exception ex) {
					Window.UpdateStatus($"Couldn't handle server message ({e.Data}) {ex.Message}");
				}
			};

			Socket.OnOpen += (sender, e) => {
				Send(new Message { Command = "join" });
				Send(new Message { Command = "list" });
				Window.UpdateStatus();
			};

			Socket.OnClose += (sender, e) => {
				Window.ListUsers(new string[0]);
				Window.UpdateStatus();
			};
		}

		public void Send(Message message) {
			string json = JsonConvert.SerializeObject(message);

			try {
				Socket.Send(json);
			} catch (Exception ex) {
				Window.UpdateStatus($"Error sending message: {ex.Message}");
			}
		}

		public void Dispose() {
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing) {
			Connected = false;

			if (disposing) {
				Socket.Close();
				Window.Dispose();
			}
		}
	}
}
