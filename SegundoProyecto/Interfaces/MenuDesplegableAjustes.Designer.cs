namespace SegundoProyecto
{
    partial class MenuDesplegableAjustes
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
            buttonLogOut = new Button();
            button2 = new Button();
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
            buttonOne.Size = new Size(190, 37);
            buttonOne.TabIndex = 4;
            buttonOne.Text = "Cambiar Color";
            buttonOne.TextAlign = ContentAlignment.MiddleRight;
            buttonOne.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonOne.UseVisualStyleBackColor = false;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.Transparent;
            buttonLogOut.BackgroundImageLayout = ImageLayout.None;
            buttonLogOut.Dock = DockStyle.Top;
            buttonLogOut.FlatAppearance.BorderSize = 0;
            buttonLogOut.FlatStyle = FlatStyle.Flat;
            buttonLogOut.Font = new Font("Victor Mono SemiBold", 9.75F, FontStyle.Bold);
            buttonLogOut.ForeColor = Color.Red;
            buttonLogOut.Image = Properties.Resources.line_md__logout__1_1;
            buttonLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogOut.Location = new Point(0, 79);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(190, 60);
            buttonLogOut.TabIndex = 5;
            buttonLogOut.Text = "  Cerrar Sesión";
            buttonLogOut.TextAlign = ContentAlignment.MiddleRight;
            buttonLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Victor Mono SemiBold", 9.75F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Image = Properties.Resources.mdi__account_cog;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(0, 37);
            button2.Name = "button2";
            button2.Size = new Size(190, 42);
            button2.TabIndex = 6;
            button2.Text = "Ajustes";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // MenuDesplegableAjustes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(buttonLogOut);
            Controls.Add(button2);
            Controls.Add(buttonOne);
            Name = "MenuDesplegableAjustes";
            Size = new Size(190, 140);
            Load += MenuDesplegable_Load;
            Paint += MenuDesplegable_Paint;
            ResumeLayout(false);
        }

        #endregion

        public Button buttonOne;
        public Button buttonLogOut;
        public Button button2;
    }
}
