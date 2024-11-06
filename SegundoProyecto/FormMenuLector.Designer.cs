namespace SegundoProyecto
{
    partial class FormMenuLector
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
            Button buttonBooks;
            panel1 = new Panel();
            button2 = new Button();
            button4 = new Button();
            buttonMenu = new Button();
            buttonConfigUsers = new Button();
            panel2 = new Panel();
            buttonMinimize = new Button();
            buttonMax = new Button();
            buttonClose = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            buttonBooks = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // buttonBooks
            // 
            buttonBooks.Dock = DockStyle.Top;
            buttonBooks.FlatAppearance.BorderSize = 0;
            buttonBooks.FlatStyle = FlatStyle.Flat;
            buttonBooks.ForeColor = SystemColors.ButtonHighlight;
            buttonBooks.Image = Properties.Resources.akar_icons__book;
            buttonBooks.ImageAlign = ContentAlignment.TopCenter;
            buttonBooks.Location = new Point(0, 90);
            buttonBooks.Name = "buttonBooks";
            buttonBooks.Padding = new Padding(8, 10, 0, 0);
            buttonBooks.Size = new Size(148, 90);
            buttonBooks.TabIndex = 4;
            buttonBooks.Text = "Libros";
            buttonBooks.TextAlign = ContentAlignment.BottomCenter;
            buttonBooks.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonBooks.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 106, 79);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(buttonMenu);
            panel1.Controls.Add(buttonBooks);
            panel1.Controls.Add(buttonConfigUsers);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Victor Mono", 9.75F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(148, 450);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = Properties.Resources.ph__hand_withdraw_duotone;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(0, 360);
            button2.Name = "button2";
            button2.Padding = new Padding(8, 10, 0, 0);
            button2.Size = new Size(148, 90);
            button2.TabIndex = 8;
            button2.Text = "Préstamos";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Image = Properties.Resources.carbon__report;
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(0, 270);
            button4.Name = "button4";
            button4.Padding = new Padding(8, 10, 0, 0);
            button4.Size = new Size(148, 90);
            button4.TabIndex = 7;
            button4.Text = "Reportes\r\n";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.TextImageRelation = TextImageRelation.ImageAboveText;
            button4.UseVisualStyleBackColor = true;
            // 
            // buttonMenu
            // 
            buttonMenu.Dock = DockStyle.Top;
            buttonMenu.FlatAppearance.BorderSize = 0;
            buttonMenu.FlatStyle = FlatStyle.Flat;
            buttonMenu.ForeColor = SystemColors.ButtonHighlight;
            buttonMenu.Image = Properties.Resources.mingcute__home_4_fill;
            buttonMenu.ImageAlign = ContentAlignment.TopCenter;
            buttonMenu.Location = new Point(0, 180);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Padding = new Padding(8, 10, 0, 0);
            buttonMenu.Size = new Size(148, 90);
            buttonMenu.TabIndex = 6;
            buttonMenu.Text = "Menú";
            buttonMenu.TextAlign = ContentAlignment.BottomCenter;
            buttonMenu.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonMenu.UseVisualStyleBackColor = true;
            // 
            // buttonConfigUsers
            // 
            buttonConfigUsers.Dock = DockStyle.Top;
            buttonConfigUsers.FlatAppearance.BorderSize = 0;
            buttonConfigUsers.FlatStyle = FlatStyle.Flat;
            buttonConfigUsers.ForeColor = SystemColors.ButtonHighlight;
            buttonConfigUsers.Image = Properties.Resources.mdi__account_cog;
            buttonConfigUsers.ImageAlign = ContentAlignment.TopCenter;
            buttonConfigUsers.Location = new Point(0, 0);
            buttonConfigUsers.Name = "buttonConfigUsers";
            buttonConfigUsers.Padding = new Padding(8, 10, 0, 0);
            buttonConfigUsers.Size = new Size(148, 90);
            buttonConfigUsers.TabIndex = 3;
            buttonConfigUsers.Text = "Usuarios";
            buttonConfigUsers.TextAlign = ContentAlignment.BottomCenter;
            buttonConfigUsers.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonConfigUsers.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonMinimize);
            panel2.Controls.Add(buttonMax);
            panel2.Controls.Add(buttonClose);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Victor Mono", 9.75F);
            panel2.Location = new Point(148, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(602, 31);
            panel2.TabIndex = 2;
            // 
            // buttonMinimize
            // 
            buttonMinimize.Dock = DockStyle.Right;
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Image = Properties.Resources.material_symbols_light__minimize;
            buttonMinimize.Location = new Point(463, 0);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(45, 31);
            buttonMinimize.TabIndex = 12;
            buttonMinimize.TextAlign = ContentAlignment.TopCenter;
            buttonMinimize.UseVisualStyleBackColor = true;
            // 
            // buttonMax
            // 
            buttonMax.Dock = DockStyle.Right;
            buttonMax.FlatAppearance.BorderSize = 0;
            buttonMax.FlatStyle = FlatStyle.Flat;
            buttonMax.Image = Properties.Resources.humbleicons__maximize__4_;
            buttonMax.Location = new Point(508, 0);
            buttonMax.Name = "buttonMax";
            buttonMax.Size = new Size(52, 31);
            buttonMax.TabIndex = 13;
            buttonMax.UseVisualStyleBackColor = true;
            buttonMax.Click += button3_Click;
            // 
            // buttonClose
            // 
            buttonClose.Dock = DockStyle.Right;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Image = Properties.Resources.material_symbols_light__close__1_;
            buttonClose.Location = new Point(560, 0);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(42, 31);
            buttonClose.TabIndex = 11;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = Properties.Resources.mdi__account_circle__1_;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(526, 0);
            button1.Name = "button1";
            button1.Padding = new Padding(8, 10, 0, 0);
            button1.Size = new Size(76, 79);
            button1.TabIndex = 4;
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(148, 31);
            panel3.Name = "panel3";
            panel3.Size = new Size(602, 79);
            panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.tabler__search__3_;
            pictureBox1.Location = new Point(305, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(0, 15, 0, 0);
            pictureBox1.Size = new Size(45, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox1);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(305, 79);
            panel4.TabIndex = 4;
            panel4.Visible = false;
            // 
            // FormMenuLector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenuLector";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenuLector";
            Load += FormMenuLector_Load;
            SizeChanged += FormMenuLector_SizeChanged;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        public Button button4;
        public Button buttonMenu;
        public Button buttonBooks;
        public Button buttonConfigUsers;
        private Panel panel2;
        public Button button2;
        private TextBox textBox1;
        public Button button1;
        private Button buttonMinimize;
        private Button buttonClose;
        private Button buttonMax;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox1;
    }
}