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
            radioButtonLector = new RadioButton();
            radioButtonBibliotecario = new RadioButton();
            labelRol = new Label();
            linkLabel1 = new LinkLabel();
            label6 = new Label();
            buttonMinimize = new Button();
            buttonClose = new Button();
            tabControl1 = new TabControl();
            tabPageLector = new TabPage();
            tabPageBibliotecario = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // botonRegistrarse
            // 
            botonRegistrarse.BackColor = Color.FromArgb(255, 140, 98);
            botonRegistrarse.BackgroundColor = Color.FromArgb(255, 140, 98);
            botonRegistrarse.BorderColor = Color.DarkGreen;
            botonRegistrarse.BorderRadius = 15;
            botonRegistrarse.BorderSize = 0;
            botonRegistrarse.Enabled = false;
            botonRegistrarse.FlatAppearance.BorderSize = 0;
            botonRegistrarse.FlatStyle = FlatStyle.Flat;
            botonRegistrarse.Font = new Font("Victor Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonRegistrarse.ForeColor = Color.WhiteSmoke;
            botonRegistrarse.Location = new Point(279, 340);
            botonRegistrarse.Name = "botonRegistrarse";
            botonRegistrarse.Size = new Size(150, 40);
            botonRegistrarse.TabIndex = 10;
            botonRegistrarse.Text = "Registrarse";
            botonRegistrarse.TextColor = Color.WhiteSmoke;
            botonRegistrarse.UseVisualStyleBackColor = false;
            // 
            // labelErrorMessage
            // 
            labelErrorMessage.AutoSize = true;
            labelErrorMessage.Font = new Font("Victor Mono", 5.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErrorMessage.ForeColor = Color.DarkRed;
            labelErrorMessage.Location = new Point(254, 188);
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
            label3.Location = new Point(158, 180);
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
            label2.Location = new Point(102, 73);
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
            textBoxPassword.Location = new Point(254, 177);
            textBoxPassword.MaxLength = 20;
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(199, 27);
            textBoxPassword.TabIndex = 9;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BorderStyle = BorderStyle.None;
            textBoxUsername.Font = new Font("Victor Mono", 9.75F);
            textBoxUsername.ForeColor = Color.Black;
            textBoxUsername.Location = new Point(254, 73);
            textBoxUsername.MaxLength = 20;
            textBoxUsername.Multiline = true;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(199, 27);
            textBoxUsername.TabIndex = 8;
            textBoxUsername.Enter += textBoxUsername_Enter;
            textBoxUsername.Leave += textBoxUsername_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Victor Mono SemiBold", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(282, 22);
            label1.Name = "label1";
            label1.Size = new Size(147, 38);
            label1.TabIndex = 7;
            label1.Text = "Regístrate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Victor Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(78, 239);
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
            textBoxConfirmPass.Location = new Point(254, 236);
            textBoxConfirmPass.MaxLength = 20;
            textBoxConfirmPass.Multiline = true;
            textBoxConfirmPass.Name = "textBoxConfirmPass";
            textBoxConfirmPass.PasswordChar = '*';
            textBoxConfirmPass.Size = new Size(199, 27);
            textBoxConfirmPass.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Victor Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(94, 125);
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
            textBoxEmail.Location = new Point(254, 122);
            textBoxEmail.MaxLength = 20;
            textBoxEmail.Multiline = true;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(199, 27);
            textBoxEmail.TabIndex = 16;
            textBoxEmail.Leave += textBoxEmail_Leave;
            // 
            // radioButtonLector
            // 
            radioButtonLector.AutoSize = true;
            radioButtonLector.Font = new Font("Victor Mono", 8.999999F);
            radioButtonLector.Location = new Point(496, 129);
            radioButtonLector.Name = "radioButtonLector";
            radioButtonLector.Size = new Size(70, 26);
            radioButtonLector.TabIndex = 18;
            radioButtonLector.TabStop = true;
            radioButtonLector.Text = "Lector";
            radioButtonLector.UseVisualStyleBackColor = true;
            // 
            // radioButtonBibliotecario
            // 
            radioButtonBibliotecario.AutoSize = true;
            radioButtonBibliotecario.Font = new Font("Victor Mono", 8.999999F);
            radioButtonBibliotecario.Location = new Point(496, 97);
            radioButtonBibliotecario.Name = "radioButtonBibliotecario";
            radioButtonBibliotecario.Size = new Size(119, 26);
            radioButtonBibliotecario.TabIndex = 19;
            radioButtonBibliotecario.TabStop = true;
            radioButtonBibliotecario.Text = "Bibliotecario";
            radioButtonBibliotecario.UseVisualStyleBackColor = true;
            // 
            // labelRol
            // 
            labelRol.AutoSize = true;
            labelRol.Font = new Font("Victor Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRol.ForeColor = Color.Black;
            labelRol.Location = new Point(496, 70);
            labelRol.Name = "labelRol";
            labelRol.Size = new Size(114, 24);
            labelRol.TabIndex = 20;
            labelRol.Text = "Escoje un rol";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Victor Mono", 8.249999F);
            linkLabel1.LinkColor = Color.Coral;
            linkLabel1.Location = new Point(358, 308);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(107, 20);
            linkLabel1.TabIndex = 22;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Iniciar Sesión";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Victor Mono", 8.249999F);
            label6.Location = new Point(189, 308);
            label6.Name = "label6";
            label6.Size = new Size(163, 20);
            label6.TabIndex = 21;
            label6.Text = "¿Ya tienes una cuenta?";
            // 
            // buttonMinimize
            // 
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Image = Properties.Resources.material_symbols_light__minimize;
            buttonMinimize.Location = new Point(635, -10);
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
            buttonClose.Location = new Point(668, 2);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(27, 27);
            buttonClose.TabIndex = 23;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageLector);
            tabControl1.Controls.Add(tabPageBibliotecario);
            tabControl1.Location = new Point(496, 180);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(204, 239);
            tabControl1.TabIndex = 25;
            tabControl1.TabStop = false;
            tabControl1.Visible = false;
            // 
            // tabPageLector
            // 
            tabPageLector.Location = new Point(4, 24);
            tabPageLector.Name = "tabPageLector";
            tabPageLector.Padding = new Padding(3);
            tabPageLector.Size = new Size(196, 211);
            tabPageLector.TabIndex = 0;
            tabPageLector.Text = "tabPageLector";
            tabPageLector.UseVisualStyleBackColor = true;
            // 
            // tabPageBibliotecario
            // 
            tabPageBibliotecario.Location = new Point(4, 24);
            tabPageBibliotecario.Name = "tabPageBibliotecario";
            tabPageBibliotecario.Padding = new Padding(3);
            tabPageBibliotecario.Size = new Size(196, 211);
            tabPageBibliotecario.TabIndex = 1;
            tabPageBibliotecario.Text = "tabPageBibliotecario";
            tabPageBibliotecario.UseVisualStyleBackColor = true;
            // 
            // FormularioRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(700, 420);
            Controls.Add(tabControl1);
            Controls.Add(buttonMinimize);
            Controls.Add(buttonClose);
            Controls.Add(linkLabel1);
            Controls.Add(label6);
            Controls.Add(labelRol);
            Controls.Add(radioButtonBibliotecario);
            Controls.Add(radioButtonLector);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormularioRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioRegistro";
            Load += FormularioRegistro_Load;
            MouseDown += FormularioRegistro_MouseDown;
            tabControl1.ResumeLayout(false);
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
        private RadioButton radioButtonLector;
        private RadioButton radioButtonBibliotecario;
        private Label labelRol;
        private LinkLabel linkLabel1;
        private Label label6;
        private Button buttonMinimize;
        private Button buttonClose;
        private TabControl tabControl1;
        private TabPage tabPageLector;
        private TabPage tabPageBibliotecario;
    }
}