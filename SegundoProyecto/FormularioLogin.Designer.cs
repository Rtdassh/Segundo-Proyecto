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
            panelTop = new Panel();
            buttonMinimize = new Button();
            buttonClose = new Button();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            labelErrorMessage = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
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
            panelTop.Controls.Add(buttonMinimize);
            panelTop.Controls.Add(buttonClose);
            panelTop.Controls.Add(linkLabel1);
            panelTop.Controls.Add(label4);
            panelTop.Controls.Add(labelErrorMessage);
            panelTop.Controls.Add(label3);
            panelTop.Controls.Add(label2);
            panelTop.Controls.Add(button1);
            panelTop.Controls.Add(textBoxPassword);
            panelTop.Controls.Add(textBoxUser);
            panelTop.Controls.Add(label1);
            panelTop.Font = new Font("Victor Mono", 9.75F);
            panelTop.Location = new Point(436, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(262, 414);
            panelTop.TabIndex = 0;
            panelTop.Paint += panelTop_Paint;
            panelTop.MouseDown += panelTop_MouseDown;
            // 
            // buttonMinimize
            // 
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Image = Properties.Resources.material_symbols_light__minimize;
            buttonMinimize.Location = new Point(199, -12);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(27, 42);
            buttonMinimize.TabIndex = 10;
            buttonMinimize.UseVisualStyleBackColor = true;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // buttonClose
            // 
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Image = Properties.Resources.material_symbols_light__close__1_;
            buttonClose.Location = new Point(232, 3);
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
            linkLabel1.Location = new Point(88, 379);
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
            label4.Location = new Point(37, 355);
            label4.Name = "label4";
            label4.Size = new Size(191, 20);
            label4.TabIndex = 7;
            label4.Text = "¿Aún no tienes una cuenta?";
            // 
            // labelErrorMessage
            // 
            labelErrorMessage.AutoSize = true;
            labelErrorMessage.Font = new Font("Victor Mono", 5.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErrorMessage.ForeColor = Color.DarkRed;
            labelErrorMessage.Location = new Point(27, 254);
            labelErrorMessage.MaximumSize = new Size(200, 0);
            labelErrorMessage.Name = "labelErrorMessage";
            labelErrorMessage.Size = new Size(0, 14);
            labelErrorMessage.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Victor Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(25, 192);
            label3.Name = "label3";
            label3.Size = new Size(90, 24);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Victor Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(25, 107);
            label2.Name = "label2";
            label2.Size = new Size(66, 24);
            label2.TabIndex = 4;
            label2.Text = "Usuario";
            // 
            // button1
            // 
            button1.BackColor = Color.Coral;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Victor Mono", 11.9999981F);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(70, 292);
            button1.Name = "button1";
            button1.Size = new Size(124, 40);
            button1.TabIndex = 3;
            button1.Text = "Continuar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Victor Mono", 9.75F);
            textBoxPassword.ForeColor = Color.Black;
            textBoxPassword.Location = new Point(29, 219);
            textBoxPassword.MaxLength = 20;
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(199, 27);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.Enter += textBoxPassword_Enter;
            textBoxPassword.Leave += textBoxPassword_Leave;
            // 
            // textBoxUser
            // 
            textBoxUser.BorderStyle = BorderStyle.None;
            textBoxUser.Font = new Font("Victor Mono", 9.75F);
            textBoxUser.ForeColor = Color.Black;
            textBoxUser.Location = new Point(29, 134);
            textBoxUser.MaxLength = 20;
            textBoxUser.Multiline = true;
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(199, 27);
            textBoxUser.TabIndex = 1;
            textBoxUser.Enter += textBoxUser_Enter;
            textBoxUser.Leave += textBoxUser_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Victor Mono SemiBold", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(29, 40);
            label1.Name = "label1";
            label1.Size = new Size(199, 38);
            label1.TabIndex = 0;
            label1.Text = "Iniciar Sesión";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(439, 414);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pexels_mayis_48519569_8254227;
            pictureBox1.Location = new Point(-17, -43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(456, 503);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // FormularioLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 414);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(383, 414);
            Name = "FormularioLogin";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioLogin";
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
        private Button button1;
        private Label labelErrorMessage;
        private LinkLabel linkLabel1;
        private Label label4;
        private Button buttonClose;
        private Button buttonMinimize;
    }
}