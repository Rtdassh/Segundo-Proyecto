namespace SegundoProyecto.Interfaces
{
    partial class MenuDesplegableCuenta
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
            buttonTwo = new Button();
            buttonOne = new Button();
            SuspendLayout();
            // 
            // buttonTwo
            // 
            buttonTwo.BackColor = Color.Transparent;
            buttonTwo.Dock = DockStyle.Top;
            buttonTwo.FlatAppearance.BorderSize = 0;
            buttonTwo.FlatStyle = FlatStyle.Flat;
            buttonTwo.Font = new Font("Victor Mono SemiBold", 9.75F, FontStyle.Bold);
            buttonTwo.ForeColor = SystemColors.ActiveCaptionText;
            buttonTwo.Image = Properties.Resources.mdi__account_cog;
            buttonTwo.ImageAlign = ContentAlignment.TopCenter;
            buttonTwo.Location = new Point(0, 64);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.Size = new Size(188, 75);
            buttonTwo.TabIndex = 8;
            buttonTwo.Text = "Cambiar \r\nContraseña";
            buttonTwo.TextAlign = ContentAlignment.MiddleRight;
            buttonTwo.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonTwo.UseVisualStyleBackColor = false;
            buttonTwo.Click += buttonTwo_Click;
            // 
            // buttonOne
            // 
            buttonOne.BackColor = Color.Transparent;
            buttonOne.Dock = DockStyle.Top;
            buttonOne.FlatAppearance.BorderSize = 0;
            buttonOne.FlatStyle = FlatStyle.Flat;
            buttonOne.Font = new Font("Victor Mono SemiBold", 9.75F, FontStyle.Bold);
            buttonOne.ForeColor = SystemColors.ActiveCaptionText;
            buttonOne.Image = Properties.Resources.mdi__account_cog;
            buttonOne.ImageAlign = ContentAlignment.TopCenter;
            buttonOne.Location = new Point(0, 0);
            buttonOne.Name = "buttonOne";
            buttonOne.Size = new Size(188, 64);
            buttonOne.TabIndex = 7;
            buttonOne.Text = "Cambiar Foto de Perfil";
            buttonOne.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonOne.UseVisualStyleBackColor = false;
            buttonOne.Click += buttonOne_Click;
            // 
            // MenuDesplegableCuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(buttonTwo);
            Controls.Add(buttonOne);
            Name = "MenuDesplegableCuenta";
            Size = new Size(188, 138);
            ResumeLayout(false);
        }

        #endregion

        public Button buttonTwo;
        public Button buttonOne;
    }
}
