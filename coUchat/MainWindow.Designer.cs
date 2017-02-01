namespace coUchat {
    partial class MainWindow {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.UsernameEntry = new System.Windows.Forms.TextBox();
			this.ConnectBtn = new System.Windows.Forms.Button();
			this.ServerLive = new System.Windows.Forms.RadioButton();
			this.ServerDev = new System.Windows.Forms.RadioButton();
			this.ServerLocal = new System.Windows.Forms.RadioButton();
			this.ServerOpts = new System.Windows.Forms.GroupBox();
			this.ChannelList = new System.Windows.Forms.ListBox();
			this.StatusBar = new System.Windows.Forms.StatusStrip();
			this.StatusText = new System.Windows.Forms.ToolStripStatusLabel();
			this.ChatButton = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.ServerOpts.SuspendLayout();
			this.StatusBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// UsernameEntry
			// 
			this.UsernameEntry.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.UsernameEntry.Location = new System.Drawing.Point(3, 59);
			this.UsernameEntry.MaxLength = 50;
			this.UsernameEntry.Name = "UsernameEntry";
			this.UsernameEntry.Size = new System.Drawing.Size(152, 25);
			this.UsernameEntry.TabIndex = 4;
			this.UsernameEntry.Text = "Username";
			this.UsernameEntry.TextChanged += new System.EventHandler(this.UsernameEntry_TextChanged);
			// 
			// ConnectBtn
			// 
			this.ConnectBtn.Location = new System.Drawing.Point(161, 59);
			this.ConnectBtn.Name = "ConnectBtn";
			this.ConnectBtn.Size = new System.Drawing.Size(120, 25);
			this.ConnectBtn.TabIndex = 5;
			this.ConnectBtn.Text = "Connect";
			this.ConnectBtn.UseVisualStyleBackColor = true;
			this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
			// 
			// ServerLive
			// 
			this.ServerLive.AutoSize = true;
			this.ServerLive.Checked = true;
			this.ServerLive.Location = new System.Drawing.Point(12, 19);
			this.ServerLive.Name = "ServerLive";
			this.ServerLive.Size = new System.Drawing.Size(79, 17);
			this.ServerLive.TabIndex = 1;
			this.ServerLive.TabStop = true;
			this.ServerLive.Text = "Live Server";
			this.ServerLive.UseVisualStyleBackColor = true;
			// 
			// ServerDev
			// 
			this.ServerDev.AutoSize = true;
			this.ServerDev.Location = new System.Drawing.Point(97, 19);
			this.ServerDev.Name = "ServerDev";
			this.ServerDev.Size = new System.Drawing.Size(79, 17);
			this.ServerDev.TabIndex = 2;
			this.ServerDev.Text = "Dev Server";
			this.ServerDev.UseVisualStyleBackColor = true;
			// 
			// ServerLocal
			// 
			this.ServerLocal.AutoSize = true;
			this.ServerLocal.Location = new System.Drawing.Point(182, 19);
			this.ServerLocal.Name = "ServerLocal";
			this.ServerLocal.Size = new System.Drawing.Size(85, 17);
			this.ServerLocal.TabIndex = 3;
			this.ServerLocal.Text = "Local Server";
			this.ServerLocal.UseVisualStyleBackColor = true;
			// 
			// ServerOpts
			// 
			this.ServerOpts.Controls.Add(this.ServerLive);
			this.ServerOpts.Controls.Add(this.ServerLocal);
			this.ServerOpts.Controls.Add(this.ServerDev);
			this.ServerOpts.Location = new System.Drawing.Point(3, 3);
			this.ServerOpts.Name = "ServerOpts";
			this.ServerOpts.Size = new System.Drawing.Size(278, 50);
			this.ServerOpts.TabIndex = 5;
			this.ServerOpts.TabStop = false;
			this.ServerOpts.Text = "Connect To";
			// 
			// ChannelList
			// 
			this.ChannelList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ChannelList.Enabled = false;
			this.ChannelList.FormattingEnabled = true;
			this.ChannelList.Items.AddRange(new object[] {
            "Global Chat",
            "Local Chat"});
			this.ChannelList.Location = new System.Drawing.Point(3, 3);
			this.ChannelList.Name = "ChannelList";
			this.ChannelList.Size = new System.Drawing.Size(278, 109);
			this.ChannelList.TabIndex = 6;
			this.ChannelList.SelectedValueChanged += new System.EventHandler(this.ChannelList_SelectedValueChanged);
			// 
			// StatusBar
			// 
			this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusText});
			this.StatusBar.Location = new System.Drawing.Point(0, 239);
			this.StatusBar.Name = "StatusBar";
			this.StatusBar.Size = new System.Drawing.Size(284, 22);
			this.StatusBar.SizingGrip = false;
			this.StatusBar.TabIndex = 7;
			// 
			// StatusText
			// 
			this.StatusText.Name = "StatusText";
			this.StatusText.Size = new System.Drawing.Size(39, 17);
			this.StatusText.Text = "Status";
			// 
			// ChatButton
			// 
			this.ChatButton.Enabled = false;
			this.ChatButton.Location = new System.Drawing.Point(3, 93);
			this.ChatButton.Name = "ChatButton";
			this.ChatButton.Size = new System.Drawing.Size(278, 23);
			this.ChatButton.TabIndex = 7;
			this.ChatButton.Text = "Join Selected Street";
			this.ChatButton.UseVisualStyleBackColor = true;
			this.ChatButton.Click += new System.EventHandler(this.ChatButton_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.ServerOpts);
			this.splitContainer1.Panel1.Controls.Add(this.ChatButton);
			this.splitContainer1.Panel1.Controls.Add(this.UsernameEntry);
			this.splitContainer1.Panel1.Controls.Add(this.ConnectBtn);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.ChannelList);
			this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(3);
			this.splitContainer1.Size = new System.Drawing.Size(284, 239);
			this.splitContainer1.SplitterDistance = 120;
			this.splitContainer1.TabIndex = 9;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.StatusBar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(300, 800);
			this.MinimumSize = new System.Drawing.Size(300, 300);
			this.Name = "MainWindow";
			this.Text = "CoU Chat Client";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
			this.ServerOpts.ResumeLayout(false);
			this.ServerOpts.PerformLayout();
			this.StatusBar.ResumeLayout(false);
			this.StatusBar.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameEntry;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.RadioButton ServerLive;
        private System.Windows.Forms.RadioButton ServerDev;
        private System.Windows.Forms.RadioButton ServerLocal;
        private System.Windows.Forms.GroupBox ServerOpts;
        private System.Windows.Forms.ListBox ChannelList;
        private System.Windows.Forms.StatusStrip StatusBar;
		private System.Windows.Forms.Button ChatButton;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ToolStripStatusLabel StatusText;
	}
}

