namespace UniCatalog
{
    partial class masterat
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
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(209, 20);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(412, 34);
            label1.TabIndex = 0;
            label1.Text = "Programe de studii - Masterat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 99);
            label2.Name = "label2";
            label2.Size = new Size(179, 34);
            label2.TabIndex = 1;
            label2.Text = "Matematica";
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(89, 136);
            button1.Name = "button1";
            button1.Size = new Size(688, 41);
            button1.TabIndex = 2;
            button1.Text = "Structuri matematice fundamentale";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 199);
            label3.Name = "label3";
            label3.Size = new Size(170, 34);
            label3.TabIndex = 3;
            label3.Text = "Informatica";
            // 
            // button2
            // 
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(89, 252);
            button2.Name = "button2";
            button2.Size = new Size(688, 41);
            button2.TabIndex = 4;
            button2.Text = "Aplicatii pentru telefonul mobil si tehnologii internet in E-business";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(89, 312);
            button3.Name = "button3";
            button3.Size = new Size(688, 41);
            button3.TabIndex = 5;
            button3.Text = "Tehnologii internet(in limba engleza)";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(89, 370);
            button4.Name = "button4";
            button4.Size = new Size(688, 41);
            button4.TabIndex = 6;
            button4.Text = "Tehnologii moderne in ingineria sistemelor soft";
            button4.UseVisualStyleBackColor = true;
            // 
            // masterat
            // 
            AutoScaleDimensions = new SizeF(16F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 492);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(6, 5, 6, 5);
            Name = "masterat";
            Text = "Programe de studii - Masterat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}