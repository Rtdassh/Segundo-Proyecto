namespace SegundoProyecto.Models
{
    partial class FormularioMensaje
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
            panelTitleBar = new Panel();
            labelCaption = new Label();
            buttonClose = new Button();
            panelBody = new Panel();
            pictureBoxIcon = new PictureBox();
            labelMessage = new Label();
            panelButtons = new Panel();
            button3 = new BotonRedondeado();
            button2 = new BotonRedondeado();
            button1 = new BotonRedondeado();
            panelTitleBar.SuspendLayout();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitleBar
            // 
            panelTitleBar.Controls.Add(labelCaption);
            panelTitleBar.Controls.Add(buttonClose);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(442, 30);
            panelTitleBar.TabIndex = 0;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown_1;
            // 
            // labelCaption
            // 
            labelCaption.AutoSize = true;
            labelCaption.Font = new Font("Victor Mono", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCaption.Location = new Point(12, 3);
            labelCaption.Name = "labelCaption";
            labelCaption.Size = new Size(58, 24);
            labelCaption.TabIndex = 11;
            labelCaption.Text = "label1";
            // 
            // buttonClose
            // 
            buttonClose.Dock = DockStyle.Right;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Image = Properties.Resources.material_symbols_light__close__1_;
            buttonClose.Location = new Point(404, 0);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(38, 30);
            buttonClose.TabIndex = 10;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // panelBody
            // 
            panelBody.BackColor = Color.White;
            panelBody.Controls.Add(pictureBoxIcon);
            panelBody.Controls.Add(labelMessage);
            panelBody.Dock = DockStyle.Top;
            panelBody.Location = new Point(0, 30);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(442, 105);
            panelBody.TabIndex = 1;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Location = new Point(12, 24);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(58, 52);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIcon.TabIndex = 13;
            pictureBoxIcon.TabStop = false;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.BackColor = Color.Transparent;
            labelMessage.Font = new Font("Victor Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMessage.ForeColor = Color.Black;
            labelMessage.Location = new Point(82, 24);
            labelMessage.MaximumSize = new Size(350, 0);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(42, 24);
            labelMessage.TabIndex = 12;
            labelMessage.Text = "Test";
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(button3);
            panelButtons.Controls.Add(button2);
            panelButtons.Controls.Add(button1);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(0, 135);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(442, 47);
            panelButtons.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 140, 98);
            button3.BackgroundColor = Color.FromArgb(255, 140, 98);
            button3.BorderColor = Color.DarkGreen;
            button3.BorderRadius = 15;
            button3.BorderSize = 0;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Victor Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.WhiteSmoke;
            button3.Location = new Point(298, 9);
            button3.Name = "button3";
            button3.Size = new Size(101, 30);
            button3.TabIndex = 16;
            button3.Text = "1";
            button3.TextColor = Color.WhiteSmoke;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 140, 98);
            button2.BackgroundColor = Color.FromArgb(255, 140, 98);
            button2.BorderColor = Color.DarkGreen;
            button2.BorderRadius = 15;
            button2.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Victor Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(168, 9);
            button2.Name = "button2";
            button2.Size = new Size(101, 30);
            button2.TabIndex = 15;
            button2.Text = "1";
            button2.TextColor = Color.WhiteSmoke;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 140, 98);
            button1.BackgroundColor = Color.FromArgb(255, 140, 98);
            button1.BorderColor = Color.DarkGreen;
            button1.BorderRadius = 15;
            button1.BorderSize = 0;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Victor Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(38, 9);
            button1.Name = "button1";
            button1.Size = new Size(101, 30);
            button1.TabIndex = 14;
            button1.Text = "1";
            button1.TextColor = Color.WhiteSmoke;
            button1.UseVisualStyleBackColor = false;
            // 
            // FormularioMensaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 182);
            Controls.Add(panelButtons);
            Controls.Add(panelBody);
            Controls.Add(panelTitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormularioMensaje";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mensaje";
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitleBar;
        private Panel panelBody;
        private Panel panelButtons;
        private Button buttonClose;
        private Label labelMessage;
        private BotonRedondeado button3;
        private BotonRedondeado button2;
        private BotonRedondeado button1;
        private Label labelCaption;
        private PictureBox pictureBoxIcon;
    }
}