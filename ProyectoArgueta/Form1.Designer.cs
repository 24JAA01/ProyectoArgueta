﻿namespace ProyectoArgueta
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(333, 98);
            button1.Name = "button1";
            button1.Size = new Size(113, 23);
            button1.TabIndex = 0;
            button1.Text = "METROS ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(333, 137);
            button2.Name = "button2";
            button2.Size = new Size(113, 23);
            button2.TabIndex = 1;
            button2.Text = "PULGADAS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(333, 177);
            button3.Name = "button3";
            button3.Size = new Size(113, 23);
            button3.TabIndex = 2;
            button3.Text = "PIES";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(333, 218);
            button4.Name = "button4";
            button4.Size = new Size(113, 23);
            button4.TabIndex = 3;
            button4.Text = "MILLAS";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(333, 259);
            button5.Name = "button5";
            button5.Size = new Size(113, 23);
            button5.TabIndex = 5;
            button5.Text = "YARDAS";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(333, 301);
            button6.Name = "button6";
            button6.Size = new Size(113, 23);
            button6.TabIndex = 6;
            button6.Text = "KILOMETROS";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(333, 345);
            button7.Name = "button7";
            button7.Size = new Size(113, 23);
            button7.TabIndex = 7;
            button7.Text = "CENTIMETROS";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(188, 9);
            label1.Name = "label1";
            label1.Size = new Size(387, 24);
            label1.TabIndex = 8;
            label1.Text = "CONVERSOR UNIDAD DE LONGITUD ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(203, 45);
            label2.Name = "label2";
            label2.Size = new Size(344, 30);
            label2.TabIndex = 9;
            label2.Text = "Jose Miguel Argueta Alvarado VA 05";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label1;
        private Label label2;
    }
}
