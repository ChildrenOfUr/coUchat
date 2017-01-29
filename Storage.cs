using System;
using System.IO;

namespace coUchat {
	public static class Storage {
		private const string UsernameFile = "username.txt";
		private const string LocalChatFile = "channels.list";
		private const string ChatFolder = "channels";

		public static string[] LocalChats {
			get {
				if (File.Exists(LocalChatFile) && // File exists and is less than a week old
				    File.GetLastWriteTime(LocalChatFile).AddDays(7).Subtract(DateTime.Now).TotalDays > 0
				   ) {
					return File.ReadAllLines(LocalChatFile);
				} else {
					return null;
				}
			}

			set {
				File.WriteAllLines(LocalChatFile, value);
			}
		}

		public static string Username {
			get {
				if (File.Exists(UsernameFile)) {
					return File.ReadAllText(UsernameFile);
				} else {
					return $"Remote {new Random().Next()}";
				}
			}

			set {
				File.WriteAllText(UsernameFile, value);
			}
		}

		public static void LogChat(string channel, string messages) {
			string file = Path.Combine(ChatFolder, channel) + ".log";

			messages = "\n" + DateTime.Now + "\n\n" + messages;

			if (File.Exists(file)) {
				messages = File.ReadAllText(file) + messages;
			}

			File.WriteAllText(file, messages);
		}
	}
}
