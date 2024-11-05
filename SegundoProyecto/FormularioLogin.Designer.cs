namespace SegundoProyecto
{
    partial class FormularioLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioLogin));
            panelTop = new Panel();
            labelMessageUser = new Label();
            botonRedondeado1 = new Models.BotonRedondeado();
            buttonMinimize = new Button();
            buttonClose = new Button();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            labelMessagePassword = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxPassword = new TextBox();
            textBoxUser = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panelTop.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(labelMessageUser);
            panelTop.Controls.Add(botonRedondeado1);
            panelTop.Controls.Add(buttonMinimize);
            panelTop.Controls.Add(buttonClose);
            panelTop.Controls.Add(linkLabel1);
            panelTop.Controls.Add(label4);
            panelTop.Controls.Add(labelMessagePassword);
            panelTop.Controls.Add(label3);
            panelTop.Controls.Add(label2);
            panelTop.Controls.Add(textBoxPassword);
            panelTop.Controls.Add(textBoxUser);
            panelTop.Controls.Add(label1);
            panelTop.Font = new Font("Victor Mono", 8.249999F);
            panelTop.Location = new Point(436, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(316, 450);
            panelTop.TabIndex = 0;
            panelTop.Paint += panelTop_Paint;
            panelTop.MouseDown += panelTop_MouseDown;
            // 
            // labelMessageUser
            // 
            labelMessageUser.AutoSize = true;
            labelMessageUser.Font = new Font("Victor Mono", 8.249999F);
            labelMessageUser.ForeColor = Color.DarkRed;
            labelMessageUser.Location = new Point(35, 180);
            labelMessageUser.MaximumSize = new Size(266, 0);
            labelMessageUser.Name = "labelMessageUser";
            labelMessageUser.Size = new Size(0, 20);
            labelMessageUser.TabIndex = 11;
            // 
            // botonRedondeado1
            // 
            botonRedondeado1.BackColor = Color.FromArgb(255, 140, 98);
            botonRedondeado1.BackgroundColor = Color.FromArgb(255, 140, 98);
            botonRedondeado1.BorderColor = Color.DarkGreen;
            botonRedondeado1.BorderRadius = 15;
            botonRedondeado1.BorderSize = 0;
            botonRedondeado1.Enabled = false;
            botonRedondeado1.FlatAppearance.BorderSize = 0;
            botonRedondeado1.FlatStyle = FlatStyle.Flat;
            botonRedondeado1.Font = new Font("Victor Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonRedondeado1.ForeColor = Color.WhiteSmoke;
            botonRedondeado1.Location = new Point(89, 319);
            botonRedondeado1.Name = "botonRedondeado1";
            botonRedondeado1.Size = new Size(150, 40);
            botonRedondeado1.TabIndex = 3;
            botonRedondeado1.Text = "Continuar";
            botonRedondeado1.TextColor = Color.WhiteSmoke;
            botonRedondeado1.UseVisualStyleBackColor = false;
            botonRedondeado1.Click += botonRedondeado1_Click;
            // 
            // buttonMinimize
            // 
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Image = Properties.Resources.material_symbols_light__minimize;
            buttonMinimize.Location = new Point(255, -16);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(27, 46);
            buttonMinimize.TabIndex = 10;
            buttonMinimize.TextAlign = ContentAlignment.TopCenter;
            buttonMinimize.UseVisualStyleBackColor = true;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // buttonClose
            // 
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Image = Properties.Resources.material_symbols_light__close__1_;
            buttonClose.Location = new Point(286, 3);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(27, 27);
            buttonClose.TabIndex = 9;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Victor Mono", 8.249999F);
            linkLabel1.LinkColor = SystemColors.MenuHighlight;
            linkLabel1.Location = new Point(124, 405);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(86, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registrarse";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Victor Mono", 8.249999F);
            label4.Location = new Point(78, 380);
            label4.Name = "label4";
            label4.Size = new Size(191, 20);
            label4.TabIndex = 7;
            label4.Text = "¿Aún no tienes una cuenta?";
            // 
            // labelMessagePassword
            // 
            labelMessagePassword.AutoSize = true;
            labelMessagePassword.Font = new Font("Victor Mono", 8.249999F);
            labelMessagePassword.ForeColor = Color.DarkRed;
            labelMessagePassword.Location = new Point(35, 274);
            labelMessagePassword.MaximumSize = new Size(266, 0);
            labelMessagePassword.Name = "labelMessagePassword";
            labelMessagePassword.Size = new Size(0, 20);
            labelMessagePassword.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Victor Mono", 9.75F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(32, 212);
            label3.Name = "label3";
            label3.Size = new Size(90, 24);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Victor Mono", 9.75F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(32, 117);
            label2.Name = "label2";
            label2.Size = new Size(138, 24);
            label2.TabIndex = 4;
            label2.Text = "Usuario o Correo";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Victor Mono", 9.75F);
            textBoxPassword.ForeColor = Color.Black;
            textBoxPassword.Location = new Point(32, 239);
            textBoxPassword.MaxLength = 30;
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(250, 27);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            textBoxPassword.Enter += textBoxPassword_Enter;
            textBoxPassword.Leave += textBoxPassword_Leave;
            // 
            // textBoxUser
            // 
            textBoxUser.BorderStyle = BorderStyle.None;
            textBoxUser.Font = new Font("Victor Mono", 9.75F);
            textBoxUser.ForeColor = Color.Black;
            textBoxUser.Location = new Point(32, 144);
            textBoxUser.MaxLength = 30;
            textBoxUser.Multiline = true;
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(250, 27);
            textBoxUser.TabIndex = 1;
            textBoxUser.TextChanged += textBoxUser_TextChanged;
            textBoxUser.Enter += textBoxUser_Enter;
            textBoxUser.Leave += textBoxUser_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Victor Mono", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(54, 54, 54);
            label1.Location = new Point(56, 42);
            label1.Name = "label1";
            label1.Size = new Size(215, 44);
            label1.TabIndex = 0;
            label1.Text = "Iniciar Sesión";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(439, 450);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pexels_mayis_48519569_8254227;
            pictureBox1.Location = new Point(-17, -43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(474, 516);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // FormularioLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 450);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(383, 414);
            Name = "FormularioLogin";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteca ";
            Load += FormularioLogin_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBoxPassword;
        private TextBox textBoxUser;
        private Label label3;
        private Label label2;
        private Label labelMessagePassword;
        private LinkLabel linkLabel1;
        private Label label4;
        private Button buttonClose;
        private Button buttonMinimize;
        private Models.BotonRedondeado botonRedondeado1;
        private Label labelMessageUser;
    }
}