﻿namespace UniCatalog
{
    partial class Licenta
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(171, 24);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(395, 34);
            label1.TabIndex = 1;
            label1.Text = "Programe de studii - Licență";
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(41, 107);
            button1.Name = "button1";
            button1.Size = new Size(688, 41);
            button1.TabIndex = 3;
            button1.Text = "Automatica si informtica aplicata";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(41, 173);
            button2.Name = "button2";
            button2.Size = new Size(688, 41);
            button2.TabIndex = 4;
            button2.Text = "Robotica";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(41, 247);
            button3.Name = "button3";
            button3.Size = new Size(688, 41);
            button3.TabIndex = 5;
            button3.Text = "Tehnologia informatie";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(41, 308);
            button4.Name = "button4";
            button4.Size = new Size(688, 41);
            button4.TabIndex = 6;
            button4.Text = "Calculatoare";
            button4.UseVisualStyleBackColor = true;
            // 
            // Licenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Licenta";
            Text = "Licenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}