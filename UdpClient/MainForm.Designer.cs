namespace UdpClient
{
    partial class MainForm
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
            this.MessageDisplayTextBox = new System.Windows.Forms.RichTextBox();
            this.MsgGroupBox = new System.Windows.Forms.GroupBox();
            this.MessageTextBox = new System.Windows.Forms.RichTextBox();
            this.SendMsgButton = new System.Windows.Forms.Button();
            this.CloseWindowButton = new System.Windows.Forms.Button();
            this.MsgGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageDisplayTextBox
            // 
            this.MessageDisplayTextBox.Location = new System.Drawing.Point(5, 4);
            this.MessageDisplayTextBox.Name = "MessageDisplayTextBox";
            this.MessageDisplayTextBox.Size = new System.Drawing.Size(576, 248);
            this.MessageDisplayTextBox.TabIndex = 0;
            this.MessageDisplayTextBox.Text = "";
            // 
            // MsgGroupBox
            // 
            this.MsgGroupBox.Controls.Add(this.MessageTextBox);
            this.MsgGroupBox.Location = new System.Drawing.Point(5, 258);
            this.MsgGroupBox.Name = "MsgGroupBox";
            this.MsgGroupBox.Size = new System.Drawing.Size(576, 127);
            this.MsgGroupBox.TabIndex = 1;
            this.MsgGroupBox.TabStop = false;
            this.MsgGroupBox.Text = "发送消息";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(8, 21);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(562, 96);
            this.MessageTextBox.TabIndex = 0;
            this.MessageTextBox.Text = "";
            this.MessageTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            // 
            // SendMsgButton
            // 
            this.SendMsgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendMsgButton.Location = new System.Drawing.Point(500, 391);
            this.SendMsgButton.Name = "SendMsgButton";
            this.SendMsgButton.Size = new System.Drawing.Size(75, 23);
            this.SendMsgButton.TabIndex = 2;
            this.SendMsgButton.Text = "发送";
            this.SendMsgButton.UseVisualStyleBackColor = true;
            this.SendMsgButton.Click += new System.EventHandler(this.OnSendMsgButtonClick);
            // 
            // CloseWindowButton
            // 
            this.CloseWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseWindowButton.Location = new System.Drawing.Point(406, 391);
            this.CloseWindowButton.Name = "CloseWindowButton";
            this.CloseWindowButton.Size = new System.Drawing.Size(75, 23);
            this.CloseWindowButton.TabIndex = 2;
            this.CloseWindowButton.Text = "关闭";
            this.CloseWindowButton.UseVisualStyleBackColor = true;
            this.CloseWindowButton.Click += new System.EventHandler(this.OnCloseWindowButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 425);
            this.Controls.Add(this.CloseWindowButton);
            this.Controls.Add(this.SendMsgButton);
            this.Controls.Add(this.MsgGroupBox);
            this.Controls.Add(this.MessageDisplayTextBox);
            this.Name = "MainForm";
            this.Text = "通信客户端";
            this.MsgGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox MessageDisplayTextBox;
        private System.Windows.Forms.GroupBox MsgGroupBox;
        private System.Windows.Forms.RichTextBox MessageTextBox;
        private System.Windows.Forms.Button SendMsgButton;
        private System.Windows.Forms.Button CloseWindowButton;
    }
}

