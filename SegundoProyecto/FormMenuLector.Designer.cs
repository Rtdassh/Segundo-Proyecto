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
            panelMenuLateral = new Panel();
            buttonReportes = new Button();
            buttonPrestamos = new Button();
            buttonMenu = new Button();
            buttonConfigUsers = new Button();
            panelOptionsBar = new Panel();
            button5 = new Button();
            button3 = new Button();
            button1 = new Button();
            buttonMinimize = new Button();
            buttonMax = new Button();
            buttonClose = new Button();
            panelSubMenu = new Panel();
            buttonBooks = new Button();
            panelMenuLateral.SuspendLayout();
            panelOptionsBar.SuspendLayout();
            SuspendLayout();
            // 
            // buttonBooks
            // 
            buttonBooks.BackColor = Color.FromArgb(45, 106, 79);
            buttonBooks.Dock = DockStyle.Top;
            buttonBooks.FlatAppearance.BorderSize = 0;
            buttonBooks.FlatStyle = FlatStyle.Flat;
            buttonBooks.Font = new Font("Victor Mono SemiBold", 9.75F, FontStyle.Bold);
            buttonBooks.ForeColor = SystemColors.ButtonHighlight;
            buttonBooks.Image = Properties.Resources.akar_icons__book;
            buttonBooks.ImageAlign = ContentAlignment.TopCenter;
            buttonBooks.Location = new Point(0, 88);
            buttonBooks.Name = "buttonBooks";
            buttonBooks.Padding = new Padding(4, 10, 0, 0);
            buttonBooks.Size = new Size(120, 90);
            buttonBooks.TabIndex = 4;
            buttonBooks.Text = "Libros";
            buttonBooks.TextAlign = ContentAlignment.BottomCenter;
            buttonBooks.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonBooks.UseVisualStyleBackColor = false;
            buttonBooks.Click += buttonBooks_Click;
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.BackColor = Color.FromArgb(45, 106, 79);
            panelMenuLateral.Controls.Add(buttonReportes);
            panelMenuLateral.Controls.Add(buttonPrestamos);
            panelMenuLateral.Controls.Add(buttonMenu);
            panelMenuLateral.Controls.Add(buttonBooks);
            panelMenuLateral.Controls.Add(buttonConfigUsers);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Font = new Font("Victor Mono", 9.75F);
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(120, 450);
            panelMenuLateral.TabIndex = 1;
            // 
            // buttonReportes
            // 
            buttonReportes.BackColor = Color.FromArgb(45, 106, 79);
            buttonReportes.Dock = DockStyle.Top;
            buttonReportes.FlatAppearance.BorderSize = 0;
            buttonReportes.FlatStyle = FlatStyle.Flat;
            buttonReportes.Font = new Font("Victor Mono SemiBold", 9.75F, FontStyle.Bold);
            buttonReportes.ForeColor = SystemColors.ButtonHighlight;
            buttonReportes.Image = Properties.Resources.carbon__report;
            buttonReportes.ImageAlign = ContentAlignment.TopCenter;
            buttonReportes.Location = new Point(0, 356);
            buttonReportes.Name = "buttonReportes";
            buttonReportes.Padding = new Padding(4, 10, 0, 0);
            buttonReportes.Size = new Size(120, 94);
            buttonReportes.TabIndex = 7;
            buttonReportes.Text = "Reportes\r\n";
            buttonReportes.TextAlign = ContentAlignment.BottomCenter;
            buttonReportes.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonReportes.UseVisualStyleBackColor = false;
            buttonReportes.Click += buttonReportes_Click;
            // 
            // buttonPrestamos
            // 
            buttonPrestamos.BackColor = Color.FromArgb(45, 106, 79);
            buttonPrestamos.Dock = DockStyle.Top;
            buttonPrestamos.FlatAppearance.BorderSize = 0;
            buttonPrestamos.FlatStyle = FlatStyle.Flat;
            buttonPrestamos.Font = new Font("Victor Mono SemiBold", 9.75F, FontStyle.Bold);
            buttonPrestamos.ForeColor = SystemColors.ButtonHighlight;
            buttonPrestamos.Image = Properties.Resources.ph__hand_withdraw_duotone;
            buttonPrestamos.ImageAlign = ContentAlignment.TopCenter;
            buttonPrestamos.Location = new Point(0, 268);
            buttonPrestamos.Name = "buttonPrestamos";
            buttonPrestamos.Padding = new Padding(4, 10, 0, 0);
            buttonPrestamos.Size = new Size(120, 88);
            buttonPrestamos.TabIndex = 8;
            buttonPrestamos.Text = "Préstamos";
            buttonPrestamos.TextAlign = ContentAlignment.BottomCenter;
            buttonPrestamos.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonPrestamos.UseVisualStyleBackColor = false;
            buttonPrestamos.Click += buttonPrestamos_Click;
            // 
            // buttonMenu
            // 
            buttonMenu.BackColor = Color.FromArgb(45, 106, 79);
            buttonMenu.Dock = DockStyle.Top;
            buttonMenu.FlatAppearance.BorderSize = 0;
            buttonMenu.FlatStyle = FlatStyle.Flat;
            buttonMenu.Font = new Font("Victor Mono SemiBold", 9.75F, FontStyle.Bold);
            buttonMenu.ForeColor = SystemColors.ButtonHighlight;
            buttonMenu.Image = Properties.Resources.mingcute__home_4_fill;
            buttonMenu.ImageAlign = ContentAlignment.TopCenter;
            buttonMenu.Location = new Point(0, 178);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Padding = new Padding(4, 10, 0, 0);
            buttonMenu.Size = new Size(120, 90);
            buttonMenu.TabIndex = 6;
            buttonMenu.Text = "Menú";
            buttonMenu.TextAlign = ContentAlignment.BottomCenter;
            buttonMenu.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonMenu.UseVisualStyleBackColor = false;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // buttonConfigUsers
            // 
            buttonConfigUsers.BackColor = Color.FromArgb(45, 106, 79);
            buttonConfigUsers.Dock = DockStyle.Top;
            buttonConfigUsers.FlatAppearance.BorderSize = 0;
            buttonConfigUsers.FlatStyle = FlatStyle.Flat;
            buttonConfigUsers.Font = new Font("Victor Mono SemiBold", 9.75F, FontStyle.Bold);
            buttonConfigUsers.ForeColor = SystemColors.ButtonHighlight;
            buttonConfigUsers.Image = Properties.Resources.mdi__account_cog;
            buttonConfigUsers.ImageAlign = ContentAlignment.TopCenter;
            buttonConfigUsers.Location = new Point(0, 0);
            buttonConfigUsers.Name = "buttonConfigUsers";
            buttonConfigUsers.Padding = new Padding(4, 10, 0, 0);
            buttonConfigUsers.Size = new Size(120, 88);
            buttonConfigUsers.TabIndex = 3;
            buttonConfigUsers.Text = "Usuarios";
            buttonConfigUsers.TextAlign = ContentAlignment.BottomCenter;
            buttonConfigUsers.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonConfigUsers.UseVisualStyleBackColor = false;
            buttonConfigUsers.Click += buttonConfigUsers_Click;
            // 
            // panelOptionsBar
            // 
            panelOptionsBar.Controls.Add(button5);
            panelOptionsBar.Controls.Add(button3);
            panelOptionsBar.Controls.Add(button1);
            panelOptionsBar.Controls.Add(buttonMinimize);
            panelOptionsBar.Controls.Add(buttonMax);
            panelOptionsBar.Controls.Add(buttonClose);
            panelOptionsBar.Dock = DockStyle.Top;
            panelOptionsBar.Font = new Font("Victor Mono", 9.75F);
            panelOptionsBar.Location = new Point(120, 0);
            panelOptionsBar.Name = "panelOptionsBar";
            panelOptionsBar.Size = new Size(630, 50);
            panelOptionsBar.TabIndex = 2;
            panelOptionsBar.MouseDown += panelOptionsBar_MouseDown;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Right;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Image = Properties.Resources.mdi__account_circle__5_;
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.Location = new Point(295, 0);
            button5.Name = "button5";
            button5.Padding = new Padding(0, 5, 0, 0);
            button5.Size = new Size(60, 50);
            button5.TabIndex = 7;
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Right;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Image = Properties.Resources.tabler__bell_filled__1_;
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(355, 0);
            button3.Name = "button3";
            button3.Padding = new Padding(0, 7, 0, 0);
            button3.Size = new Size(66, 50);
            button3.TabIndex = 6;
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = Properties.Resources.ic__round_settings__1_;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(421, 0);
            button1.Name = "button1";
            button1.Padding = new Padding(0, 6, 0, 0);
            button1.Size = new Size(60, 50);
            button1.TabIndex = 4;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            // 
            // buttonMinimize
            // 
            buttonMinimize.Dock = DockStyle.Right;
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Image = Properties.Resources.material_symbols_light__minimize;
            buttonMinimize.Location = new Point(481, 0);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(45, 50);
            buttonMinimize.TabIndex = 12;
            buttonMinimize.TextAlign = ContentAlignment.TopCenter;
            buttonMinimize.UseVisualStyleBackColor = true;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // buttonMax
            // 
            buttonMax.Dock = DockStyle.Right;
            buttonMax.FlatAppearance.BorderSize = 0;
            buttonMax.FlatStyle = FlatStyle.Flat;
            buttonMax.Image = Properties.Resources.humbleicons__maximize__4_;
            buttonMax.Location = new Point(526, 0);
            buttonMax.Name = "buttonMax";
            buttonMax.Size = new Size(52, 50);
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
            buttonClose.Location = new Point(578, 0);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(52, 50);
            buttonClose.TabIndex = 11;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // panelSubMenu
            // 
            panelSubMenu.Dock = DockStyle.Fill;
            panelSubMenu.Location = new Point(120, 50);
            panelSubMenu.Name = "panelSubMenu";
            panelSubMenu.Size = new Size(630, 400);
            panelSubMenu.TabIndex = 3;
            // 
            // FormMenuLector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(750, 450);
            Controls.Add(panelSubMenu);
            Controls.Add(panelOptionsBar);
            Controls.Add(panelMenuLateral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenuLector";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenuLector";
            Load += FormMenuLector_Load;
            SizeChanged += FormMenuLector_SizeChanged;
            panelMenuLateral.ResumeLayout(false);
            panelOptionsBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenuLateral;
        public Button buttonReportes;
        public Button buttonMenu;
        public Button buttonBooks;
        public Button buttonConfigUsers;
        private Panel panelOptionsBar;
        public Button buttonPrestamos;
        public Button button1;
        private Button buttonMinimize;
        private Button buttonClose;
        private Button buttonMax;
        public Button button3;
        public Button button5;
        private Panel panelSubMenu;
    }
}