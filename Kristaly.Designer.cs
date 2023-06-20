namespace UniCatalog
{
    partial class Kristaly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kristaly));
            pictureBox3 = new PictureBox();
            richTextBox1 = new RichTextBox();
            label5 = new Label();
            richTextBox2 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.Location = new Point(43, 66);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(155, 192);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(226, 66);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(562, 195);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(43, 22);
            label5.Name = "label5";
            label5.Size = new Size(230, 34);
            label5.TabIndex = 14;
            label5.Text = "Kristaly Dominic";
            // 
            // richTextBox2
            // 
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Location = new Point(32, 267);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(756, 195);
            richTextBox2.TabIndex = 15;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // Kristaly
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox2);
            Controls.Add(label5);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox3);
            Name = "Kristaly";
            Text = "Kristaly";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private RichTextBox richTextBox1;
        private Label label5;
        private RichTextBox richTextBox2;
    }
}