namespace SegundoProyecto
{
    partial class BookCardMaximized
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
            panel2 = new Panel();
            labelPages = new Label();
            labelReleaseDate = new Label();
            labelOriginalTitle = new Label();
            labelTitle = new Label();
            pbCover = new PictureBox();
            panel1 = new Panel();
            botonPrestar = new Models.BotonRedondeado();
            botonRegresar = new Models.BotonRedondeado();
            labelDescription = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCover).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(labelPages);
            panel2.Controls.Add(labelReleaseDate);
            panel2.Controls.Add(labelOriginalTitle);
            panel2.Controls.Add(labelTitle);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(244, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(356, 211);
            panel2.TabIndex = 7;
            // 
            // labelPages
            // 
            labelPages.Anchor = AnchorStyles.None;
            labelPages.AutoSize = true;
            labelPages.Font = new Font("Victor Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPages.Location = new Point(9, 173);
            labelPages.MaximumSize = new Size(160, 0);
            labelPages.Name = "labelPages";
            labelPages.Size = new Size(52, 22);
            labelPages.TabIndex = 3;
            labelPages.Text = "label1";
            // 
            // labelReleaseDate
            // 
            labelReleaseDate.Anchor = AnchorStyles.None;
            labelReleaseDate.AutoSize = true;
            labelReleaseDate.Font = new Font("Victor Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelReleaseDate.Location = new Point(9, 118);
            labelReleaseDate.MaximumSize = new Size(160, 0);
            labelReleaseDate.Name = "labelReleaseDate";
            labelReleaseDate.Size = new Size(52, 22);
            labelReleaseDate.TabIndex = 2;
            labelReleaseDate.Text = "label1";
            // 
            // labelOriginalTitle
            // 
            labelOriginalTitle.Anchor = AnchorStyles.None;
            labelOriginalTitle.AutoSize = true;
            labelOriginalTitle.Font = new Font("Victor Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOriginalTitle.Location = new Point(9, 58);
            labelOriginalTitle.MaximumSize = new Size(160, 0);
            labelOriginalTitle.Name = "labelOriginalTitle";
            labelOriginalTitle.Size = new Size(52, 22);
            labelOriginalTitle.TabIndex = 1;
            labelOriginalTitle.Text = "label1";
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.None;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Victor Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(9, 9);
            labelTitle.MaximumSize = new Size(160, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(52, 22);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "label1";
            // 
            // pbCover
            // 
            pbCover.Dock = DockStyle.Left;
            pbCover.Image = Properties.Resources.not_found;
            pbCover.Location = new Point(0, 0);
            pbCover.Margin = new Padding(6);
            pbCover.Name = "pbCover";
            pbCover.Padding = new Padding(5, 0, 0, 0);
            pbCover.Size = new Size(244, 211);
            pbCover.SizeMode = PictureBoxSizeMode.Zoom;
            pbCover.TabIndex = 6;
            pbCover.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(botonPrestar);
            panel1.Controls.Add(botonRegresar);
            panel1.Controls.Add(labelDescription);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 211);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 189);
            panel1.TabIndex = 5;
            // 
            // botonPrestar
            // 
            botonPrestar.BackColor = Color.FromArgb(45, 106, 79);
            botonPrestar.BackgroundColor = Color.FromArgb(45, 106, 79);
            botonPrestar.BorderColor = Color.DarkGreen;
            botonPrestar.BorderRadius = 15;
            botonPrestar.BorderSize = 0;
            botonPrestar.FlatAppearance.BorderSize = 0;
            botonPrestar.FlatStyle = FlatStyle.Flat;
            botonPrestar.Font = new Font("Victor Mono", 8.999999F);
            botonPrestar.ForeColor = Color.White;
            botonPrestar.Location = new Point(278, 137);
            botonPrestar.Name = "botonPrestar";
            botonPrestar.Size = new Size(150, 40);
            botonPrestar.TabIndex = 3;
            botonPrestar.Text = "Prestar";
            botonPrestar.TextColor = Color.White;
            botonPrestar.UseVisualStyleBackColor = false;
            botonPrestar.Click += botonPrestar_Click;
            // 
            // botonRegresar
            // 
            botonRegresar.BackColor = Color.FromArgb(88, 129, 87);
            botonRegresar.BackgroundColor = Color.FromArgb(88, 129, 87);
            botonRegresar.BorderColor = Color.DarkGreen;
            botonRegresar.BorderRadius = 15;
            botonRegresar.BorderSize = 0;
            botonRegresar.FlatAppearance.BorderSize = 0;
            botonRegresar.FlatStyle = FlatStyle.Flat;
            botonRegresar.Font = new Font("Victor Mono", 8.999999F);
            botonRegresar.ForeColor = Color.White;
            botonRegresar.Location = new Point(447, 137);
            botonRegresar.Name = "botonRegresar";
            botonRegresar.Size = new Size(150, 40);
            botonRegresar.TabIndex = 2;
            botonRegresar.Text = "Regresar";
            botonRegresar.TextColor = Color.White;
            botonRegresar.UseVisualStyleBackColor = false;
            botonRegresar.Click += botonRegresar_Click;
            // 
            // labelDescription
            // 
            labelDescription.Anchor = AnchorStyles.None;
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Victor Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescription.Location = new Point(12, 16);
            labelDescription.MaximumSize = new Size(550, 100);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(52, 22);
            labelDescription.TabIndex = 1;
            labelDescription.Text = "label1";
            // 
            // BookCardMaximized
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 400);
            Controls.Add(panel2);
            Controls.Add(pbCover);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookCardMaximized";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookCardMaximized";
            Load += BookCardMaximized_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCover).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label labelPages;
        private Label labelReleaseDate;
        private Label labelOriginalTitle;
        private Label labelTitle;
        private PictureBox pbCover;
        private Panel panel1;
        private Label labelDescription;
        private Models.BotonRedondeado botonRegresar;
        private Models.BotonRedondeado botonPrestar;
    }
}