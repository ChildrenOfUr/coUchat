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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatWindow));
			this.StatusBar = new System.Windows.Forms.StatusStrip();
			this.StatusButton = new System.Windows.Forms.ToolStripSplitButton();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.UserView = new System.Windows.Forms.TreeView();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.MsgView = new System.Windows.Forms.RichTextBox();
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
            this.StatusButton});
			this.StatusBar.Location = new System.Drawing.Point(0, 259);
			this.StatusBar.Name = "StatusBar";
			this.StatusBar.Size = new System.Drawing.Size(464, 22);
			this.StatusBar.SizingGrip = false;
			this.StatusBar.TabIndex = 0;
			// 
			// StatusButton
			// 
			this.StatusButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.StatusButton.DropDownButtonWidth = 0;
			this.StatusButton.Image = ((System.Drawing.Image)(resources.GetObject("StatusButton.Image")));
			this.StatusButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.StatusButton.Name = "StatusButton";
			this.StatusButton.Size = new System.Drawing.Size(44, 20);
			this.StatusButton.Text = "Status";
			this.StatusButton.ButtonClick += new System.EventHandler(this.StatusButton_ButtonClick);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
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
			this.UserView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.UserView.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.UserView.Indent = 15;
			this.UserView.ItemHeight = 24;
			this.UserView.Location = new System.Drawing.Point(0, 0);
			this.UserView.Name = "UserView";
			this.UserView.ShowLines = false;
			this.UserView.ShowPlusMinus = false;
			this.UserView.ShowRootLines = false;
			this.UserView.Size = new System.Drawing.Size(150, 259);
			this.UserView.TabIndex = 3;
			this.UserView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.UserView_NodeMouseDoubleClick);
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
			this.splitContainer2.Panel1.Controls.Add(this.MsgView);
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
			// MsgView
			// 
			this.MsgView.BackColor = System.Drawing.Color.White;
			this.MsgView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MsgView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MsgView.Location = new System.Drawing.Point(0, 0);
			this.MsgView.Name = "MsgView";
			this.MsgView.ReadOnly = true;
			this.MsgView.Size = new System.Drawing.Size(310, 230);
			this.MsgView.TabIndex = 0;
			this.MsgView.Text = "";
			// 
			// splitContainer3
			// 
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
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
			this.MessageEntry.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.MessageEntry.Location = new System.Drawing.Point(0, 0);
			this.MessageEntry.MaxLength = 100;
			this.MessageEntry.Name = "MessageEntry";
			this.MessageEntry.Size = new System.Drawing.Size(251, 25);
			this.MessageEntry.TabIndex = 1;
			// 
			// SendButton
			// 
			this.SendButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SendButton.Enabled = false;
			this.SendButton.Location = new System.Drawing.Point(0, 0);
			this.SendButton.MaximumSize = new System.Drawing.Size(55, 25);
			this.SendButton.MinimumSize = new System.Drawing.Size(55, 25);
			this.SendButton.Name = "SendButton";
			this.SendButton.Size = new System.Drawing.Size(55, 25);
			this.SendButton.TabIndex = 0;
			this.SendButton.TabStop = false;
			this.SendButton.Text = "Send";
			this.SendButton.UseVisualStyleBackColor = true;
			this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
			// 
			// ChatWindow
			// 
			this.AcceptButton = this.SendButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(464, 281);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.StatusBar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(480, 320);
			this.Name = "ChatWindow";
			this.Text = "CoU Chat";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatWindow_FormClosing);
			this.Shown += new System.EventHandler(this.ChatWindow_Shown);
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
		private System.Windows.Forms.TextBox MessageEntry;
		private System.Windows.Forms.Button SendButton;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.ToolStripSplitButton StatusButton;
		private System.Windows.Forms.RichTextBox MsgView;
	}
}