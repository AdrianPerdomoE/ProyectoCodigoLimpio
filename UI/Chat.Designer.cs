namespace TrackerUI
{
    partial class Chat
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.bottomChatPanel = new System.Windows.Forms.Panel();
            this.sendButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.messagesSetPanel = new System.Windows.Forms.Panel();
            this.messagesSentListView = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.profileLabel = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.headerPanel.SuspendLayout();
            this.bottomChatPanel.SuspendLayout();
            this.messagesSetPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(110)))));
            this.headerPanel.Controls.Add(this.exitButton);
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(957, 32);
            this.headerPanel.TabIndex = 0;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseUp);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(110)))));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(898, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(59, 32);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(12, 2);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(66, 28);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Chat";
            this.headerLabel.Click += new System.EventHandler(this.headerLabel_Click);
            // 
            // bottomChatPanel
            // 
            this.bottomChatPanel.Controls.Add(this.sendButton);
            this.bottomChatPanel.Controls.Add(this.textBox);
            this.bottomChatPanel.Location = new System.Drawing.Point(57, 507);
            this.bottomChatPanel.Name = "bottomChatPanel";
            this.bottomChatPanel.Size = new System.Drawing.Size(843, 47);
            this.bottomChatPanel.TabIndex = 1;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(110)))));
            this.sendButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sendButton.BackgroundImage")));
            this.sendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sendButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.sendButton.FlatAppearance.BorderSize = 0;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sendButton.ForeColor = System.Drawing.Color.White;
            this.sendButton.Location = new System.Drawing.Point(780, 0);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(63, 47);
            this.sendButton.TabIndex = 2;
            this.sendButton.UseVisualStyleBackColor = false;
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox.ForeColor = System.Drawing.Color.White;
            this.textBox.Location = new System.Drawing.Point(0, 1);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(763, 47);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "Type Something";
            this.textBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseDown);
            // 
            // messagesSetPanel
            // 
            this.messagesSetPanel.Controls.Add(this.messagesSentListView);
            this.messagesSetPanel.Location = new System.Drawing.Point(57, 137);
            this.messagesSetPanel.Name = "messagesSetPanel";
            this.messagesSetPanel.Size = new System.Drawing.Size(843, 341);
            this.messagesSetPanel.TabIndex = 2;
            // 
            // messagesSentListView
            // 
            this.messagesSentListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.messagesSentListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messagesSentListView.ForeColor = System.Drawing.Color.White;
            this.messagesSentListView.Location = new System.Drawing.Point(0, 3);
            this.messagesSentListView.Name = "messagesSentListView";
            this.messagesSentListView.Size = new System.Drawing.Size(843, 338);
            this.messagesSentListView.TabIndex = 0;
            this.messagesSentListView.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.profileLabel);
            this.panel1.Controls.Add(this.profilePictureBox);
            this.panel1.Location = new System.Drawing.Point(57, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 86);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Some user text here";
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.BackColor = System.Drawing.Color.Transparent;
            this.profileLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.profileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(83)))), ((int)(((byte)(163)))));
            this.profileLabel.Location = new System.Drawing.Point(88, 3);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(103, 20);
            this.profileLabel.TabIndex = 2;
            this.profileLabel.Text = "User name";
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Image = global::ProyectoCodigoLimpio.Properties.Resources.profile1;
            this.profilePictureBox.Location = new System.Drawing.Point(0, -3);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(83, 86);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 0;
            this.profilePictureBox.TabStop = false;
            this.profilePictureBox.Click += new System.EventHandler(this.profilePictureBox_Click);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(957, 577);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.messagesSetPanel);
            this.Controls.Add(this.bottomChatPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.bottomChatPanel.ResumeLayout(false);
            this.bottomChatPanel.PerformLayout();
            this.messagesSetPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel headerPanel;
        private Label headerLabel;
        private Button exitButton;
        private Panel bottomChatPanel;
        private TextBox textBox;
        private Panel messagesSetPanel;
        private ListView messagesSentListView;
        private Button sendButton;
        private Panel panel1;
        private Label label1;
        private Label profileLabel;
        private PictureBox profilePictureBox;
    }
}