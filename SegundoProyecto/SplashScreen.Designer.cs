namespace SegundoProyecto
{
    partial class SplashScreen
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
            components = new System.ComponentModel.Container();
            timerSplashScreen = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // timerSplashScreen
            // 
            timerSplashScreen.Tick += timerSplashScreen_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._40163478_87031511;
            pictureBox1.Location = new Point(-1, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(425, 288);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Bebas Neue", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(52, 58, 64);
            label1.Location = new Point(252, 127);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(159, 96);
            label1.TabIndex = 2;
            label1.Text = "Biblioteca\r\nOxlajuj\r\n";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Sora", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(52, 58, 64);
            label2.Location = new Point(76, 9);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(217, 17);
            label2.TabIndex = 3;
            label2.Text = "Ilustración diseñada por Freepik.com";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Sora", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(52, 58, 64);
            label3.Location = new Point(268, 223);
            label3.Margin = new Padding(0);
            label3.MaximumSize = new Size(200, 0);
            label3.Name = "label3";
            label3.Size = new Size(120, 33);
            label3.TabIndex = 4;
            label3.Text = "Cargando";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(204, 167, 103);
            ClientSize = new Size(420, 277);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashScreen";
            Load += SplashScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timerSplashScreen;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}