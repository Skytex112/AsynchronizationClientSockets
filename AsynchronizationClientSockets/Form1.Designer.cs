namespace AsynchronizationClientSockets
{
    partial class Form1
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
            msgBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            AnswerTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // msgBox
            // 
            msgBox.Location = new Point(420, 78);
            msgBox.Name = "msgBox";
            msgBox.Size = new Size(210, 27);
            msgBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(484, 288);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ConnectButAsync;
            // 
            // button2
            // 
            button2.Location = new Point(484, 374);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Send Info";
            button2.UseVisualStyleBackColor = true;
            button2.Click += SENDAsync;
            // 
            // button3
            // 
            button3.Location = new Point(484, 409);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "Disconnect";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Disconnect_buttonAsync;
            // 
            // AnswerTextBox
            // 
            AnswerTextBox.Location = new Point(420, 111);
            AnswerTextBox.Multiline = true;
            AnswerTextBox.Name = "AnswerTextBox";
            AnswerTextBox.ReadOnly = true;
            AnswerTextBox.Size = new Size(210, 122);
            AnswerTextBox.TabIndex = 4;
            AnswerTextBox.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(503, 36);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 5;
            label1.Text = "Practice";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(342, 81);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 6;
            label2.Text = "sending";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 111);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 7;
            label3.Text = "Recieveing";
            // 
            // button4
            // 
            button4.Location = new Point(484, 323);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 8;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = true;
            button4.Click += UpdateButton;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AnswerTextBox);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(msgBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox msgBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox AnswerTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button4;
    }
}
