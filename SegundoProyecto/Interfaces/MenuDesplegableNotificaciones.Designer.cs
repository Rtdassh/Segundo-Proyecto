namespace SegundoProyecto.Interfaces
{
    partial class MenuDesplegableNotificaciones
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
            buttonOne = new Button();
            button1 = new Button();
            SuspendLayout();
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
            buttonOne.TabIndex = 5;
            buttonOne.Text = "Cambiar Foto de Perfil";
            buttonOne.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonOne.UseVisualStyleBackColor = false;
            buttonOne.Click += buttonOne_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Victor Mono SemiBold", 9.75F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Image = Properties.Resources.mdi__account_cog;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(0, 64);
            button1.Name = "button1";
            button1.Size = new Size(188, 79);
            button1.TabIndex = 6;
            button1.Text = "Cambiar \r\nContraseña";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // MenuDesplegableNotificaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(button1);
            Controls.Add(buttonOne);
            Name = "MenuDesplegableNotificaciones";
            Size = new Size(188, 138);
            ResumeLayout(false);
        }

        #endregion

        public Button buttonOne;
        public Button button1;
    }
}
