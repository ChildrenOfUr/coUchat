
// This file has been generated by the GUI designer. Do not modify.
namespace coUchat
{
	public partial class Dialog
	{
		private global::Gtk.Label DialogText;

		private global::Gtk.Button CloseButton;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget coUchat.Dialog
			this.Name = "coUchat.Dialog";
			this.Title = global::Mono.Unix.Catalog.GetString("Message from CoU Chat");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.BorderWidth = ((uint)(12));
			this.Resizable = false;
			this.DefaultWidth = 320;
			this.DefaultHeight = 120;
			this.DestroyWithParent = true;
			this.Role = "";
			// Internal child coUchat.Dialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.Spacing = 12;
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.DialogText = new global::Gtk.Label();
			this.DialogText.Name = "DialogText";
			w1.Add(this.DialogText);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(w1[this.DialogText]));
			w2.Position = 0;
			// Internal child coUchat.Dialog.ActionArea
			global::Gtk.HButtonBox w3 = this.ActionArea;
			w3.Name = "dialog1_ActionArea";
			w3.Spacing = 10;
			w3.BorderWidth = ((uint)(5));
			w3.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(1));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.CloseButton = new global::Gtk.Button();
			this.CloseButton.CanDefault = true;
			this.CloseButton.CanFocus = true;
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.UseStock = true;
			this.CloseButton.UseUnderline = true;
			this.CloseButton.Label = "gtk-ok";
			this.AddActionWidget(this.CloseButton, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w4 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w3[this.CloseButton]));
			w4.Expand = false;
			w4.Fill = false;
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Show();
			this.CloseButton.Clicked += new global::System.EventHandler(this.OnCloseButtonClicked);
		}
	}
}