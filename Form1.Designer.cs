
namespace WinFormsPictureBox
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
            pictureBox1 = new PictureBox();
            button4 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(51, 316);
            button1.Name = "button1";
            button1.Size = new Size(159, 42);
            button1.TabIndex = 0;
            button1.Text = "Primavera";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Khaki;
            button2.Font = new Font("Segoe Script", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(230, 316);
            button2.Name = "button2";
            button2.Size = new Size(159, 42);
            button2.TabIndex = 1;
            button2.Text = "Verano";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.Font = new Font("Segoe Script", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(585, 316);
            button3.Name = "button3";
            button3.Size = new Size(159, 42);
            button3.TabIndex = 2;
            button3.Text = "Invierno";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.otoño;
            pictureBox1.Location = new Point(171, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(490, 266);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.RosyBrown;
            button4.Font = new Font("Segoe Script", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(405, 316);
            button4.Name = "button4";
            button4.Size = new Size(159, 42);
            button4.TabIndex = 4;
            button4.Text = "Otoño";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(216, 383);
            label1.Name = "label1";
            label1.Size = new Size(421, 29);
            label1.TabIndex = 5;
            label1.Text = "Danna Cristina Castro Hernández";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private Button button4;
        private Label label1;
    }
}
