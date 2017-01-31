using Newtonsoft.Json;

namespace coUchat {
	[JsonObject(MemberSerialization.OptIn)]
	public struct Message {
		[JsonProperty("exempt")]
		public const bool Exempt = true;

		[JsonProperty("statusMessage", NullValueHandling = NullValueHandling.Ignore)]
		public string Command;

		[JsonProperty("channel")]
		public string Channel;

		[JsonProperty("username")]
		public string Username;

		[JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
		public string Text;

		[JsonProperty("newStreetLabel", NullValueHandling = NullValueHandling.Ignore)]
		public string NewStreet;

		[JsonProperty("oldStreetLabel", NullValueHandling = NullValueHandling.Ignore)]
		public string OldStreet;

		public Message(Message copy) {
			Command = copy.Command;
			Channel = copy.Channel;
			Username = copy.Username;
			Text = copy.Text;
			NewStreet = copy.NewStreet;
			OldStreet = copy.OldStreet;
		}

		public string[] UserList {
			get {
				if (!Text.StartsWith("Users in this channel:")) {
					return new string[0];
				}

				return Text.Substring(22).Split(',');
			}
		}

		public override string ToString() {
			return string.Format("{0, -50}{1}", Username, Text);
		}
	}
}