namespace coUchat {
	partial class ChatWindow {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.StatusBar = new System.Windows.Forms.StatusStrip();
			this.ConnectStatus = new System.Windows.Forms.ToolStripSplitButton();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.UserView = new System.Windows.Forms.TreeView();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.MessageView = new System.Windows.Forms.RichTextBox();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.MessageEntry = new System.Windows.Forms.TextBox();
			this.SendButton = new System.Windows.Forms.Button();
			this.StatusBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			this.SuspendLayout();
			// 
			// StatusBar
			// 
			this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectStatus});
			this.StatusBar.Location = new System.Drawing.Point(0, 259);
			this.StatusBar.Name = "StatusBar";
			this.StatusBar.Size = new System.Drawing.Size(464, 22);
			this.StatusBar.SizingGrip = false;
			this.StatusBar.TabIndex = 0;
			this.StatusBar.Text = "statusStrip1";
			// 
			// ConnectStatus
			// 
			this.ConnectStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.ConnectStatus.DropDownButtonWidth = 0;
			this.ConnectStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ConnectStatus.Name = "ConnectStatus";
			this.ConnectStatus.Size = new System.Drawing.Size(93, 20);
			this.ConnectStatus.Text = "Not Connected";
			this.ConnectStatus.ButtonClick += new System.EventHandler(this.ConnectStatus_ButtonClick);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.UserView);
			this.splitContainer1.Panel1MinSize = 100;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Panel2MinSize = 100;
			this.splitContainer1.Size = new System.Drawing.Size(464, 259);
			this.splitContainer1.SplitterDistance = 150;
			this.splitContainer1.TabIndex = 1;
			// 
			// UserView
			// 
			this.UserView.Cursor = System.Windows.Forms.Cursors.Hand;
			this.UserView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.UserView.HotTracking = true;
			this.UserView.Indent = 15;
			this.UserView.ItemHeight = 24;
			this.UserView.Location = new System.Drawing.Point(0, 0);
			this.UserView.Name = "UserView";
			this.UserView.ShowLines = false;
			this.UserView.ShowPlusMinus = false;
			this.UserView.ShowRootLines = false;
			this.UserView.Size = new System.Drawing.Size(150, 259);
			this.UserView.TabIndex = 3;
			this.UserView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.UserView_AfterSelect);
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer2.IsSplitterFixed = true;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.MessageView);
			this.splitContainer2.Panel1MinSize = 100;
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
			this.splitContainer2.Panel2MinSize = 20;
			this.splitContainer2.Size = new System.Drawing.Size(310, 259);
			this.splitContainer2.SplitterDistance = 230;
			this.splitContainer2.TabIndex = 0;
			// 
			// MessageView
			// 
			this.MessageView.BackColor = System.Drawing.Color.White;
			this.MessageView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MessageView.Location = new System.Drawing.Point(0, 0);
			this.MessageView.Name = "MessageView";
			this.MessageView.ReadOnly = true;
			this.MessageView.Size = new System.Drawing.Size(310, 230);
			this.MessageView.TabIndex = 2;
			this.MessageView.Text = "";
			// 
			// splitContainer3
			// 
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.IsSplitterFixed = true;
			this.splitContainer3.Location = new System.Drawing.Point(0, 0);
			this.splitContainer3.Name = "splitContainer3";
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add(this.MessageEntry);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.SendButton);
			this.splitContainer3.Size = new System.Drawing.Size(310, 25);
			this.splitContainer3.SplitterDistance = 251;
			this.splitContainer3.TabIndex = 0;
			// 
			// MessageEntry
			// 
			this.MessageEntry.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MessageEntry.Enabled = false;
			this.MessageEntry.Location = new System.Drawing.Point(0, 0);
			this.MessageEntry.MaxLength = 1000;
			this.MessageEntry.Name = "MessageEntry";
			this.MessageEntry.Size = new System.Drawing.Size(251, 20);
			this.MessageEntry.TabIndex = 1;
			this.MessageEntry.Enter += new System.EventHandler(this.MessageEntry_Enter);
			this.MessageEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MessageEntry_KeyPress);
			// 
			// SendButton
			// 
			this.SendButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SendButton.Enabled = false;
			this.SendButton.Location = new System.Drawing.Point(0, 0);
			this.SendButton.Name = "SendButton";
			this.SendButton.Size = new System.Drawing.Size(55, 25);
			this.SendButton.TabIndex = 0;
			this.SendButton.TabStop = false;
			this.SendButton.Text = "Send";
			this.SendButton.UseVisualStyleBackColor = true;
			// 
			// ChatWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(464, 281);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.StatusBar);
			this.MinimumSize = new System.Drawing.Size(480, 320);
			this.Name = "ChatWindow";
			this.Text = "CoU Chat";
			this.StatusBar.ResumeLayout(false);
			this.StatusBar.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel1.PerformLayout();
			this.splitContainer3.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
			this.splitContainer3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip StatusBar;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TreeView UserView;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.RichTextBox MessageView;
		private System.Windows.Forms.ToolStripSplitButton ConnectStatus;
		private System.Windows.Forms.TextBox MessageEntry;
		private System.Windows.Forms.Button SendButton;
		private System.Windows.Forms.SplitContainer splitContainer3;
	}
}