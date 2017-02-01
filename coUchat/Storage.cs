using System;
using System.IO;

namespace coUchat {
	public static class Storage {
		public static string Username {
			get {
				try {
					if (File.Exists(Properties.Resources.UsernameFile)) {
						return File.ReadAllText(Properties.Resources.UsernameFile);
					} else {
						return $"Remote {new Random().Next()}";
					}
				} catch (Exception ex) {
					Program.UI.UpdateStatus($"Error reading username:\n\n{ex.Message}");
					return $"Remote {new Random().Next()}";
				}
			}

			set {
				try {
					File.WriteAllText(Properties.Resources.UsernameFile, value);
				} catch (Exception ex) {
					Program.UI.UpdateStatus($"Error saving username:\n\n{ex.Message}");
				}
			}
		}

		public static void LogChat(string channel, string messages) {
			try {
				string file = Path.Combine(Properties.Resources.ChannelFolder, channel) + ".log";

				messages = "\n" + DateTime.Now + "\n\n" + messages;

				if (!Directory.Exists(Properties.Resources.ChannelFolder)) {
					Directory.CreateDirectory(Properties.Resources.ChannelFolder);
				} else if (File.Exists(file)) {
					messages = File.ReadAllText(file) + messages;
				}

				File.WriteAllText(file, messages);
			} catch (Exception ex) {
				Program.UI.UpdateStatus($"Error saving chat log:\n\n{ex.Message}");
			}
		}
	}
}