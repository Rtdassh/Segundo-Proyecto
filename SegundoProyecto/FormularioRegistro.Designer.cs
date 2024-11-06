namespace SegundoProyecto
{
    partial class FormularioRegistro
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
            botonRegistrarse = new Models.BotonRedondeado();
            labelErrorMessage = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            label1 = new Label();
            label4 = new Label();
            textBoxConfirmPass = new TextBox();
            label5 = new Label();
            textBoxEmail = new TextBox();
            linkLabel1 = new LinkLabel();
            label6 = new Label();
            buttonMinimize = new Button();
            buttonClose = new Button();
            labelMessageUser = new Label();
            labelMessageEmail = new Label();
            labelMessagePass = new Label();
            labelMessageConfirmPass = new Label();
            pictureBox1 = new PictureBox();
            buttonEyeWatcherPass = new Button();
            buttonEyeWatcherConfirmPass = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // botonRegistrarse
            // 
            botonRegistrarse.BackColor = Color.FromArgb(255, 140, 98);
            botonRegistrarse.BackgroundColor = Color.FromArgb(255, 140, 98);
            botonRegistrarse.BorderColor = Color.DarkGreen;
            botonRegistrarse.BorderRadius = 15;
            botonRegistrarse.BorderSize = 0;
            botonRegistrarse.Cursor = Cursors.Hand;
            botonRegistrarse.Enabled = false;
            botonRegistrarse.FlatAppearance.BorderSize = 0;
            botonRegistrarse.FlatStyle = FlatStyle.Flat;
            botonRegistrarse.Font = new Font("Victor Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonRegistrarse.ForeColor = Color.WhiteSmoke;
            botonRegistrarse.Location = new Point(327, 381);
            botonRegistrarse.Name = "botonRegistrarse";
            botonRegistrarse.Size = new Size(150, 40);
            botonRegistrarse.TabIndex = 13;
            botonRegistrarse.Text = "Registrarse";
            botonRegistrarse.TextColor = Color.WhiteSmoke;
            botonRegistrarse.UseVisualStyleBackColor = false;
            botonRegistrarse.Click += botonRegistrarse_Click;
            // 
            // labelErrorMessage
            // 
            labelErrorMessage.AutoSize = true;
            labelErrorMessage.Font = new Font("Victor Mono", 5.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErrorMessage.ForeColor = Color.DarkRed;
            labelErrorMessage.Location = new Point(193, 238);
            labelErrorMessage.MaximumSize = new Size(200, 0);
            labelErrorMessage.Name = "labelErrorMessage";
            labelErrorMessage.Size = new Size(0, 14);
            labelErrorMessage.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Victor Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(97, 230);
            label3.Name = "label3";
            label3.Size = new Size(90, 24);
            label3.TabIndex = 12;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Victor Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(41, 107);
            label2.Name = "label2";
            label2.Size = new Size(146, 24);
            label2.TabIndex = 11;
            label2.Text = "Nombre de usuario";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Victor Mono", 9.75F);
            textBoxPassword.ForeColor = Color.Black;
            textBoxPassword.Location = new Point(193, 227);
            textBoxPassword.MaxLength = 30;
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(250, 27);
            textBoxPassword.TabIndex = 10;
            textBoxPassword.Enter += textBoxPassword_Enter;
            textBoxPassword.Leave += textBoxPassword_Leave;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BorderStyle = BorderStyle.None;
            textBoxUsername.Font = new Font("Victor Mono", 9.75F);
            textBoxUsername.ForeColor = Color.Black;
            textBoxUsername.Location = new Point(193, 107);
            textBoxUsername.MaxLength = 30;
            textBoxUsername.Multiline = true;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(250, 27);
            textBoxUsername.TabIndex = 8;
            textBoxUsername.Enter += textBoxUsername_Enter;
            textBoxUsername.Leave += textBoxUsername_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Victor Mono", 20.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(54, 54, 54);
            label1.Location = new Point(295, 35);
            label1.Name = "label1";
            label1.Size = new Size(182, 49);
            label1.TabIndex = 7;
            label1.Text = "Regístrate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Victor Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(17, 290);
            label4.Name = "label4";
            label4.Size = new Size(170, 24);
            label4.TabIndex = 15;
            label4.Text = "Confirmar Contraseña";
            // 
            // textBoxConfirmPass
            // 
            textBoxConfirmPass.BorderStyle = BorderStyle.None;
            textBoxConfirmPass.Font = new Font("Victor Mono", 9.75F);
            textBoxConfirmPass.ForeColor = Color.Black;
            textBoxConfirmPass.Location = new Point(193, 287);
            textBoxConfirmPass.MaxLength = 30;
            textBoxConfirmPass.Multiline = true;
            textBoxConfirmPass.Name = "textBoxConfirmPass";
            textBoxConfirmPass.PasswordChar = '*';
            textBoxConfirmPass.Size = new Size(250, 27);
            textBoxConfirmPass.TabIndex = 11;
            textBoxConfirmPass.Enter += textBoxConfirmPass_Enter;
            textBoxConfirmPass.Leave += textBoxConfirmPass_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Victor Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(33, 170);
            label5.Name = "label5";
            label5.Size = new Size(154, 24);
            label5.TabIndex = 17;
            label5.Text = "Correo Electrónico";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Victor Mono", 9.75F);
            textBoxEmail.ForeColor = Color.Black;
            textBoxEmail.Location = new Point(193, 167);
            textBoxEmail.MaxLength = 30;
            textBoxEmail.Multiline = true;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(250, 27);
            textBoxEmail.TabIndex = 9;
            textBoxEmail.Enter += textBoxEmail_Enter;
            textBoxEmail.Leave += textBoxEmail_Leave;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Victor Mono", 9.75F);
            linkLabel1.LinkColor = Color.Coral;
            linkLabel1.Location = new Point(419, 354);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(122, 24);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Iniciar Sesión";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Victor Mono", 9.75F);
            label6.Location = new Point(227, 354);
            label6.Name = "label6";
            label6.Size = new Size(186, 24);
            label6.TabIndex = 21;
            label6.Text = "¿Ya tienes una cuenta?";
            // 
            // buttonMinimize
            // 
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Image = Properties.Resources.material_symbols_light__minimize;
            buttonMinimize.Location = new Point(687, -10);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(27, 39);
            buttonMinimize.TabIndex = 24;
            buttonMinimize.TextAlign = ContentAlignment.TopCenter;
            buttonMinimize.UseVisualStyleBackColor = true;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // buttonClose
            // 
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Image = Properties.Resources.material_symbols_light__close__1_;
            buttonClose.Location = new Point(720, 2);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(27, 27);
            buttonClose.TabIndex = 23;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelMessageUser
            // 
            labelMessageUser.AutoSize = true;
            labelMessageUser.Font = new Font("Victor Mono", 8.249999F);
            labelMessageUser.ForeColor = Color.DarkRed;
            labelMessageUser.Location = new Point(193, 140);
            labelMessageUser.MaximumSize = new Size(350, 0);
            labelMessageUser.Name = "labelMessageUser";
            labelMessageUser.Size = new Size(0, 20);
            labelMessageUser.TabIndex = 25;
            // 
            // labelMessageEmail
            // 
            labelMessageEmail.AutoSize = true;
            labelMessageEmail.Font = new Font("Victor Mono", 8.249999F);
            labelMessageEmail.ForeColor = Color.DarkRed;
            labelMessageEmail.Location = new Point(193, 200);
            labelMessageEmail.MaximumSize = new Size(350, 0);
            labelMessageEmail.Name = "labelMessageEmail";
            labelMessageEmail.Size = new Size(0, 20);
            labelMessageEmail.TabIndex = 26;
            // 
            // labelMessagePass
            // 
            labelMessagePass.AutoSize = true;
            labelMessagePass.Font = new Font("Victor Mono", 8.249999F);
            labelMessagePass.ForeColor = Color.DarkRed;
            labelMessagePass.Location = new Point(195, 261);
            labelMessagePass.MaximumSize = new Size(350, 0);
            labelMessagePass.Name = "labelMessagePass";
            labelMessagePass.Size = new Size(0, 20);
            labelMessagePass.TabIndex = 27;
            // 
            // labelMessageConfirmPass
            // 
            labelMessageConfirmPass.AutoSize = true;
            labelMessageConfirmPass.Font = new Font("Victor Mono", 8.249999F);
            labelMessageConfirmPass.ForeColor = Color.DarkRed;
            labelMessageConfirmPass.Location = new Point(193, 320);
            labelMessageConfirmPass.MaximumSize = new Size(350, 0);
            labelMessageConfirmPass.Name = "labelMessageConfirmPass";
            labelMessageConfirmPass.Size = new Size(0, 20);
            labelMessageConfirmPass.TabIndex = 28;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.man_9066590_1280;
            pictureBox1.Location = new Point(483, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 288);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // buttonEyeWatcherPass
            // 
            buttonEyeWatcherPass.Cursor = Cursors.Hand;
            buttonEyeWatcherPass.FlatAppearance.BorderSize = 0;
            buttonEyeWatcherPass.FlatStyle = FlatStyle.Flat;
            buttonEyeWatcherPass.Image = Properties.Resources.fluent__eye_12_filled__1_;
            buttonEyeWatcherPass.Location = new Point(450, 230);
            buttonEyeWatcherPass.Name = "buttonEyeWatcherPass";
            buttonEyeWatcherPass.Size = new Size(27, 24);
            buttonEyeWatcherPass.TabIndex = 30;
            buttonEyeWatcherPass.UseVisualStyleBackColor = true;
            buttonEyeWatcherPass.MouseDown += buttonEyeWatcherPass_MouseDown;
            buttonEyeWatcherPass.MouseUp += buttonEyeWatcherPass_MouseUp;
            // 
            // buttonEyeWatcherConfirmPass
            // 
            buttonEyeWatcherConfirmPass.Cursor = Cursors.Hand;
            buttonEyeWatcherConfirmPass.FlatAppearance.BorderSize = 0;
            buttonEyeWatcherConfirmPass.FlatStyle = FlatStyle.Flat;
            buttonEyeWatcherConfirmPass.Image = Properties.Resources.fluent__eye_12_filled__1_;
            buttonEyeWatcherConfirmPass.Location = new Point(450, 290);
            buttonEyeWatcherConfirmPass.Name = "buttonEyeWatcherConfirmPass";
            buttonEyeWatcherConfirmPass.Size = new Size(27, 24);
            buttonEyeWatcherConfirmPass.TabIndex = 31;
            buttonEyeWatcherConfirmPass.UseVisualStyleBackColor = true;
            buttonEyeWatcherConfirmPass.MouseDown += buttonEyeWatcherConfirmPass_MouseDown;
            buttonEyeWatcherConfirmPass.MouseUp += buttonEyeWatcherConfirmPass_MouseUp;
            // 
            // FormularioRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(750, 450);
            Controls.Add(buttonEyeWatcherConfirmPass);
            Controls.Add(buttonEyeWatcherPass);
            Controls.Add(labelMessageConfirmPass);
            Controls.Add(labelMessagePass);
            Controls.Add(labelMessageEmail);
            Controls.Add(labelMessageUser);
            Controls.Add(buttonMinimize);
            Controls.Add(buttonClose);
            Controls.Add(linkLabel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxEmail);
            Controls.Add(label4);
            Controls.Add(textBoxConfirmPass);
            Controls.Add(botonRegistrarse);
            Controls.Add(labelErrorMessage);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormularioRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioRegistro";
            Load += FormularioRegistro_Load;
            Paint += FormularioRegistro_Paint;
            MouseDown += FormularioRegistro_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Models.BotonRedondeado botonRegistrarse;
        private Label labelErrorMessage;
        private Label label3;
        private Label label2;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Label label1;
        private Label label4;
        private TextBox textBoxConfirmPass;
        private Label label5;
        private TextBox textBoxEmail;
        private LinkLabel linkLabel1;
        private Label label6;
        private Button buttonMinimize;
        private Button buttonClose;
        private Label labelMessageUser;
        private Label labelMessageEmail;
        private Label labelMessagePass;
        private Label labelMessageConfirmPass;
        private PictureBox pictureBox1;
        private Button buttonEyeWatcherPass;
        private Button buttonEyeWatcherConfirmPass;
    }
}