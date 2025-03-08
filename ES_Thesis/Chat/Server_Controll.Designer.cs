namespace ES_Thesis.Chat
{
    partial class Server_Controll
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.messageList = new System.Windows.Forms.ListBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnConDis = new System.Windows.Forms.Button();
            this.btnServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageList
            // 
            this.messageList.FormattingEnabled = true;
            this.messageList.HorizontalScrollbar = true;
            this.messageList.Location = new System.Drawing.Point(12, 12);
            this.messageList.Name = "messageList";
            this.messageList.Size = new System.Drawing.Size(470, 290);
            this.messageList.TabIndex = 1;
            // 
            // sendButton
            // 
            this.sendButton.Enabled = false;
            this.sendButton.Location = new System.Drawing.Point(382, 303);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(100, 29);
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // inputBox
            // 
            this.inputBox.Enabled = false;
            this.inputBox.Location = new System.Drawing.Point(12, 308);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(363, 20);
            this.inputBox.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnConDis
            // 
            this.btnConDis.Location = new System.Drawing.Point(12, 334);
            this.btnConDis.Name = "btnConDis";
            this.btnConDis.Size = new System.Drawing.Size(100, 29);
            this.btnConDis.TabIndex = 7;
            this.btnConDis.Text = "Connect";
            this.btnConDis.UseVisualStyleBackColor = true;
            this.btnConDis.Click += new System.EventHandler(this.btnConDis_Click);
            // 
            // btnServer
            // 
            this.btnServer.Location = new System.Drawing.Point(118, 334);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(100, 29);
            this.btnServer.TabIndex = 8;
            this.btnServer.Text = "Start Server";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // Server_Controll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 373);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.btnConDis);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.messageList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Server_Controll";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox messageList;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button btnConDis;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnServer;
    }
}