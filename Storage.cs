using System;
using System.IO;

namespace coUchat {
	public static class Storage {
		private const string UsernameFile = "username.txt";
		private const string LocalChatFile = "channels.list";
		private const string ChatFolder = "channels";

		public static string[] LocalChats {
			get {
                try {
                    if (File.Exists(LocalChatFile) && // File exists and is less than a week old
                        File.GetLastWriteTime(LocalChatFile).AddDays(7).Subtract(DateTime.Now).TotalDays > 0
                       ) {
                        return File.ReadAllLines(LocalChatFile);
                    } else {
                        return null;
                    }
                } catch (Exception ex) {
                    MainClass.Dialog.Open($"Error reading Local Chat cache:\n\n{ex.Message}");
                    return null;
                }
			}

			set {
                try {
                    File.WriteAllLines(LocalChatFile, value);
                } catch (Exception ex) {
                    MainClass.Dialog.Open($"Error saving Local Chat cache:\n\n{ex.Message}");
                }
			}
		}

		public static string Username {
			get {
                try {
                    if (File.Exists(UsernameFile)) {
                        return File.ReadAllText(UsernameFile);
                    } else {
                        return $"Remote {new Random().Next()}";
                    }
                } catch (Exception ex) {
                    MainClass.Dialog.Open($"Error reading username:\n\n{ex.Message}");
                    return $"Remote {new Random().Next()}";
                }
			}

			set {
                try {
                    File.WriteAllText(UsernameFile, value);
                } catch (Exception ex) {
                    MainClass.Dialog.Open($"Error saving username:\n\n{ex.Message}");
                }
			}
		}

		public static void LogChat(string channel, string messages) {
            try {
                string file = Path.Combine(ChatFolder, channel) + ".log";

                messages = "\n" + DateTime.Now + "\n\n" + messages;

                if (!Directory.Exists(ChatFolder)) {
                    Directory.CreateDirectory(ChatFolder);
                } else if (File.Exists(file)) {
                    messages = File.ReadAllText(file) + messages;
                }

                File.WriteAllText(file, messages);
            } catch (Exception ex) {
                MainClass.Dialog.Open($"Error saving chat log:\n\n{ex.Message}");
            }
		}
	}
}
