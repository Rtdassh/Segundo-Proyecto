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
            botonRedondeado1 = new Models.BotonRedondeado();
            labelErrorMessage = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxPassword = new TextBox();
            textBoxUser = new TextBox();
            label1 = new Label();
            label4 = new Label();
            textBoxConfirmPass = new TextBox();
            label5 = new Label();
            textBoxEmail = new TextBox();
            SuspendLayout();
            // 
            // botonRedondeado1
            // 
            botonRedondeado1.BackColor = Color.FromArgb(255, 140, 98);
            botonRedondeado1.BackgroundColor = Color.FromArgb(255, 140, 98);
            botonRedondeado1.BorderColor = Color.DarkGreen;
            botonRedondeado1.BorderRadius = 15;
            botonRedondeado1.BorderSize = 0;
            botonRedondeado1.FlatAppearance.BorderSize = 0;
            botonRedondeado1.FlatStyle = FlatStyle.Flat;
            botonRedondeado1.Font = new Font("Victor Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonRedondeado1.ForeColor = Color.WhiteSmoke;
            botonRedondeado1.Location = new Point(263, 340);
            botonRedondeado1.Name = "botonRedondeado1";
            botonRedondeado1.Size = new Size(150, 40);
            botonRedondeado1.TabIndex = 10;
            botonRedondeado1.Text = "Registrarse";
            botonRedondeado1.TextColor = Color.WhiteSmoke;
            botonRedondeado1.UseVisualStyleBackColor = false;
            // 
            // labelErrorMessage
            // 
            labelErrorMessage.AutoSize = true;
            labelErrorMessage.Font = new Font("Victor Mono", 5.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErrorMessage.ForeColor = Color.DarkRed;
            labelErrorMessage.Location = new Point(263, 183);
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
            label3.Location = new Point(167, 175);
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
            label2.Location = new Point(111, 80);
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
            textBoxPassword.Location = new Point(263, 172);
            textBoxPassword.MaxLength = 20;
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(199, 27);
            textBoxPassword.TabIndex = 9;
            // 
            // textBoxUser
            // 
            textBoxUser.BorderStyle = BorderStyle.None;
            textBoxUser.Font = new Font("Victor Mono", 9.75F);
            textBoxUser.ForeColor = Color.Black;
            textBoxUser.Location = new Point(263, 80);
            textBoxUser.MaxLength = 20;
            textBoxUser.Multiline = true;
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(199, 27);
            textBoxUser.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Victor Mono SemiBold", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(263, 25);
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
            label4.Location = new Point(87, 226);
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
            textBoxConfirmPass.Location = new Point(263, 223);
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
            label5.Location = new Point(103, 127);
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
            textBoxEmail.Location = new Point(263, 124);
            textBoxEmail.MaxLength = 20;
            textBoxEmail.Multiline = true;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(199, 27);
            textBoxEmail.TabIndex = 16;
            textBoxEmail.Leave += textBoxEmail_Leave;
            // 
            // FormularioRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(698, 414);
            Controls.Add(label5);
            Controls.Add(textBoxEmail);
            Controls.Add(label4);
            Controls.Add(textBoxConfirmPass);
            Controls.Add(botonRedondeado1);
            Controls.Add(labelErrorMessage);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUser);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormularioRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioRegistro";
            Load += FormularioRegistro_Load;
            MouseDown += FormularioRegistro_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Models.BotonRedondeado botonRedondeado1;
        private Label labelErrorMessage;
        private Label label3;
        private Label label2;
        private TextBox textBoxPassword;
        private TextBox textBoxUser;
        private Label label1;
        private Label label4;
        private TextBox textBoxConfirmPass;
        private Label label5;
        private TextBox textBoxEmail;
    }
}