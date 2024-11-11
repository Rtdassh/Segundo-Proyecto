namespace SegundoProyecto.Interfaces
{
    partial class MiCuenta
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            buttonChangeProfilePicture = new Models.BotonRedondeado();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(146, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 320);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonChangeProfilePicture
            // 
            buttonChangeProfilePicture.BackColor = Color.FromArgb(45, 106, 79);
            buttonChangeProfilePicture.BackgroundColor = Color.FromArgb(45, 106, 79);
            buttonChangeProfilePicture.BorderColor = Color.DarkGreen;
            buttonChangeProfilePicture.BorderRadius = 15;
            buttonChangeProfilePicture.BorderSize = 0;
            buttonChangeProfilePicture.FlatAppearance.BorderSize = 0;
            buttonChangeProfilePicture.FlatStyle = FlatStyle.Flat;
            buttonChangeProfilePicture.Font = new Font("Victor Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonChangeProfilePicture.ForeColor = Color.White;
            buttonChangeProfilePicture.Location = new Point(197, 329);
            buttonChangeProfilePicture.Name = "buttonChangeProfilePicture";
            buttonChangeProfilePicture.Size = new Size(225, 40);
            buttonChangeProfilePicture.TabIndex = 1;
            buttonChangeProfilePicture.Text = "Cambiar Foto de Perfil";
            buttonChangeProfilePicture.TextColor = Color.White;
            buttonChangeProfilePicture.UseVisualStyleBackColor = false;
            buttonChangeProfilePicture.Click += btnCropImage_Click;
            // 
            // MiCuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonChangeProfilePicture);
            Controls.Add(pictureBox1);
            Name = "MiCuenta";
            Size = new Size(630, 400);
            Load += MiCuenta_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Models.BotonRedondeado buttonChangeProfilePicture;
    }
}
