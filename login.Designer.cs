namespace UniCatalog
{
    partial class login
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
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            richTextBox5 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(375, 59);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 34);
            label1.TabIndex = 2;
            label1.Text = "Autentificare";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(258, 190);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 28);
            label5.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(271, 281);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 28);
            label6.TabIndex = 7;
            // 
            // richTextBox5
            // 
            richTextBox5.Location = new Point(294, 248);
            richTextBox5.Margin = new Padding(6, 6, 6, 6);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(232, 42);
            richTextBox5.TabIndex = 16;
            richTextBox5.Text = "";
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(294, 160);
            richTextBox4.Margin = new Padding(6, 6, 6, 6);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(232, 43);
            richTextBox4.TabIndex = 15;
            richTextBox4.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 262);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 14;
            label2.Text = "Parola";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 175);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 28);
            label3.TabIndex = 13;
            label3.Text = "User";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(657, 190);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(129, 41);
            button1.TabIndex = 17;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 407);
            Controls.Add(button1);
            Controls.Add(richTextBox5);
            Controls.Add(richTextBox4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "login";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label5;
        private Label label6;
        private RichTextBox richTextBox5;
        private RichTextBox richTextBox4;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}