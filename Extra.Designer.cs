namespace UniCatalog
{
    partial class Extra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Extra));
            label1 = new Label();
            textBox3 = new TextBox();
            richTextBox3 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(130, 23);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(554, 34);
            label1.TabIndex = 2;
            label1.Text = "Programe de formare psihopedagogică";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(24, 274);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(589, 25);
            textBox3.TabIndex = 36;
            textBox3.Text = "Pentru inscriere";
            // 
            // richTextBox3
            // 
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox3.Location = new Point(24, 320);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(753, 269);
            richTextBox3.TabIndex = 35;
            richTextBox3.Text = resources.GetString("richTextBox3.Text");
            // 
            // richTextBox2
            // 
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox2.Location = new Point(24, 188);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(753, 90);
            richTextBox2.TabIndex = 34;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // richTextBox4
            // 
            richTextBox4.BorderStyle = BorderStyle.None;
            richTextBox4.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox4.Location = new Point(24, 71);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(753, 66);
            richTextBox4.TabIndex = 33;
            richTextBox4.Text = "În paralel cu pregătirea de specialitate, studenții oricărei facultăți au oportunitatea să urmeze Programul de pregătire psihopedagogică pentru a deveni cadru didactic.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(280, 85);
            label2.Margin = new Padding(10, 0, 10, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 34);
            label2.TabIndex = 32;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(24, 144);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(589, 25);
            textBox2.TabIndex = 31;
            textBox2.Text = "Program de studii organizat distinct de cel de licență";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(288, -67);
            label3.Margin = new Padding(10, 0, 10, 0);
            label3.Name = "label3";
            label3.Size = new Size(231, 34);
            label3.TabIndex = 30;
            label3.Text = "Discipline Reale";
            // 
            // Extra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 649);
            Controls.Add(textBox3);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox4);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Extra";
            Text = "Extra";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox3;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox4;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
    }
}