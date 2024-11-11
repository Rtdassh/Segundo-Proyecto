namespace SegundoProyecto
{
    partial class Libros
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
            panel1 = new Panel();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            barraBusqueda = new Models.Test();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSearch);
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(barraBusqueda);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(630, 64);
            panel1.TabIndex = 10;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Top;
            buttonSearch.BackColor = Color.White;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Victor Mono SemiBold", 9.75F, FontStyle.Bold);
            buttonSearch.ForeColor = SystemColors.ButtonHighlight;
            buttonSearch.Image = Properties.Resources.ic__outline_search;
            buttonSearch.ImageAlign = ContentAlignment.TopCenter;
            buttonSearch.Location = new Point(426, 14);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(37, 41);
            buttonSearch.TabIndex = 7;
            buttonSearch.TextAlign = ContentAlignment.BottomCenter;
            buttonSearch.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top;
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Font = new Font("Victor Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.ForeColor = Color.Black;
            textBoxSearch.Location = new Point(146, 27);
            textBoxSearch.MaxLength = 30;
            textBoxSearch.Multiline = true;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(259, 18);
            textBoxSearch.TabIndex = 5;
            // 
            // barraBusqueda
            // 
            barraBusqueda.Anchor = AnchorStyles.Top;
            barraBusqueda.BackColor = Color.Transparent;
            barraBusqueda.BorderColor = Color.FromArgb(45, 106, 79);
            barraBusqueda.BorderHeight = 1;
            barraBusqueda.ForeColor = Color.Coral;
            barraBusqueda.Location = new Point(127, 22);
            barraBusqueda.Name = "barraBusqueda";
            barraBusqueda.Size = new Size(293, 30);
            barraBusqueda.TabIndex = 6;
            // 
            // Libros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "Libros";
            Size = new Size(630, 400);
            Load += Libros_Load;
            Resize += Libros_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBoxSearch;
        private Models.Test barraBusqueda;
        public Button buttonSearch;
    }
}
