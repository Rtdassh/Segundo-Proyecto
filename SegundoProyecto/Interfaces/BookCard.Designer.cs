namespace SegundoProyecto.Interfaces
{
    partial class BookCard
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
            labelTitle = new Label();
            pbCover = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCover).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelTitle);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 175);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(177, 65);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.None;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Victor Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(14, 3);
            labelTitle.MaximumSize = new Size(160, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(52, 22);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "label1";
            // 
            // pbCover
            // 
            pbCover.Dock = DockStyle.Fill;
            pbCover.Image = Properties.Resources.not_found;
            pbCover.Location = new Point(0, 0);
            pbCover.Margin = new Padding(6);
            pbCover.Name = "pbCover";
            pbCover.Padding = new Padding(5, 0, 0, 0);
            pbCover.Size = new Size(177, 175);
            pbCover.SizeMode = PictureBoxSizeMode.Zoom;
            pbCover.TabIndex = 1;
            pbCover.TabStop = false;
            pbCover.Click += pbCover_Click;
            // 
            // BookCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pbCover);
            Controls.Add(panel1);
            Name = "BookCard";
            Size = new Size(177, 240);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCover).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelTitle;
        private PictureBox pbCover;
    }
}
