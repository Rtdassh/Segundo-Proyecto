﻿namespace SegundoProyecto
{
    partial class FormularioInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioInicio));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            archivoToolStripMenuItem1 = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            guardarcomoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            imprimirToolStripMenuItem = new ToolStripMenuItem();
            vistapreviadeimpresiónToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            deshacerToolStripMenuItem = new ToolStripMenuItem();
            rehacerToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            cortarToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            pegarToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            seleccionartodoToolStripMenuItem = new ToolStripMenuItem();
            herramientasToolStripMenuItem = new ToolStripMenuItem();
            personalizarToolStripMenuItem = new ToolStripMenuItem();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            contenidoToolStripMenuItem = new ToolStripMenuItem();
            índiceToolStripMenuItem = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            acercadeToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            textBoxUser = new TextBox();
            test1 = new Models.Test();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(203, 153, 126);
            menuStrip1.Font = new Font("Victor Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, archivoToolStripMenuItem1, editarToolStripMenuItem, herramientasToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(741, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.MouseDown += menuStrip1_MouseDown;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Enabled = false;
            toolStripMenuItem1.Image = Properties.Resources.basil__document_outline__1_;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(28, 28);
            // 
            // archivoToolStripMenuItem1
            // 
            archivoToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, abrirToolStripMenuItem, toolStripSeparator, guardarToolStripMenuItem, guardarcomoToolStripMenuItem, toolStripSeparator1, imprimirToolStripMenuItem, vistapreviadeimpresiónToolStripMenuItem, toolStripSeparator2, salirToolStripMenuItem });
            archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            archivoToolStripMenuItem1.ShortcutKeyDisplayString = "";
            archivoToolStripMenuItem1.Size = new Size(78, 28);
            archivoToolStripMenuItem1.Text = "&Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Image = (Image)resources.GetObject("nuevoToolStripMenuItem.Image");
            nuevoToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            nuevoToolStripMenuItem.Size = new Size(280, 28);
            nuevoToolStripMenuItem.Text = "&Nuevo";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Image = (Image)resources.GetObject("abrirToolStripMenuItem.Image");
            abrirToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            abrirToolStripMenuItem.Size = new Size(280, 28);
            abrirToolStripMenuItem.Text = "&Abrir";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(277, 6);
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Image = (Image)resources.GetObject("guardarToolStripMenuItem.Image");
            guardarToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            guardarToolStripMenuItem.Size = new Size(280, 28);
            guardarToolStripMenuItem.Text = "&Guardar";
            // 
            // guardarcomoToolStripMenuItem
            // 
            guardarcomoToolStripMenuItem.Name = "guardarcomoToolStripMenuItem";
            guardarcomoToolStripMenuItem.Size = new Size(280, 28);
            guardarcomoToolStripMenuItem.Text = "Guardar &como";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(277, 6);
            // 
            // imprimirToolStripMenuItem
            // 
            imprimirToolStripMenuItem.Image = (Image)resources.GetObject("imprimirToolStripMenuItem.Image");
            imprimirToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            imprimirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            imprimirToolStripMenuItem.Size = new Size(280, 28);
            imprimirToolStripMenuItem.Text = "&Imprimir";
            // 
            // vistapreviadeimpresiónToolStripMenuItem
            // 
            vistapreviadeimpresiónToolStripMenuItem.Image = (Image)resources.GetObject("vistapreviadeimpresiónToolStripMenuItem.Image");
            vistapreviadeimpresiónToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            vistapreviadeimpresiónToolStripMenuItem.Name = "vistapreviadeimpresiónToolStripMenuItem";
            vistapreviadeimpresiónToolStripMenuItem.Size = new Size(280, 28);
            vistapreviadeimpresiónToolStripMenuItem.Text = "&Vista previa de impresión";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(277, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(280, 28);
            salirToolStripMenuItem.Text = "&Salir";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deshacerToolStripMenuItem, rehacerToolStripMenuItem, toolStripSeparator3, cortarToolStripMenuItem, copiarToolStripMenuItem, pegarToolStripMenuItem, toolStripSeparator4, seleccionartodoToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(70, 28);
            editarToolStripMenuItem.Text = "&Editar";
            // 
            // deshacerToolStripMenuItem
            // 
            deshacerToolStripMenuItem.Name = "deshacerToolStripMenuItem";
            deshacerToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            deshacerToolStripMenuItem.Size = new Size(208, 28);
            deshacerToolStripMenuItem.Text = "&Deshacer";
            // 
            // rehacerToolStripMenuItem
            // 
            rehacerToolStripMenuItem.Name = "rehacerToolStripMenuItem";
            rehacerToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            rehacerToolStripMenuItem.Size = new Size(208, 28);
            rehacerToolStripMenuItem.Text = "&Rehacer";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(205, 6);
            // 
            // cortarToolStripMenuItem
            // 
            cortarToolStripMenuItem.Image = (Image)resources.GetObject("cortarToolStripMenuItem.Image");
            cortarToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            cortarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cortarToolStripMenuItem.Size = new Size(208, 28);
            cortarToolStripMenuItem.Text = "&Cortar";
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Image = (Image)resources.GetObject("copiarToolStripMenuItem.Image");
            copiarToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copiarToolStripMenuItem.Size = new Size(208, 28);
            copiarToolStripMenuItem.Text = "&Copiar";
            // 
            // pegarToolStripMenuItem
            // 
            pegarToolStripMenuItem.Image = (Image)resources.GetObject("pegarToolStripMenuItem.Image");
            pegarToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            pegarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pegarToolStripMenuItem.Size = new Size(208, 28);
            pegarToolStripMenuItem.Text = "&Pegar";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(205, 6);
            // 
            // seleccionartodoToolStripMenuItem
            // 
            seleccionartodoToolStripMenuItem.Name = "seleccionartodoToolStripMenuItem";
            seleccionartodoToolStripMenuItem.Size = new Size(208, 28);
            seleccionartodoToolStripMenuItem.Text = "&Seleccionar todo";
            // 
            // herramientasToolStripMenuItem
            // 
            herramientasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { personalizarToolStripMenuItem, opcionesToolStripMenuItem });
            herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            herramientasToolStripMenuItem.Size = new Size(118, 28);
            herramientasToolStripMenuItem.Text = "&Herramientas";
            // 
            // personalizarToolStripMenuItem
            // 
            personalizarToolStripMenuItem.Name = "personalizarToolStripMenuItem";
            personalizarToolStripMenuItem.Size = new Size(176, 28);
            personalizarToolStripMenuItem.Text = "&Personalizar";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(176, 28);
            opcionesToolStripMenuItem.Text = "&Opciones";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contenidoToolStripMenuItem, índiceToolStripMenuItem, buscarToolStripMenuItem, toolStripSeparator5, acercadeToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(62, 28);
            ayudaToolStripMenuItem.Text = "&Ayuda";
            // 
            // contenidoToolStripMenuItem
            // 
            contenidoToolStripMenuItem.Name = "contenidoToolStripMenuItem";
            contenidoToolStripMenuItem.Size = new Size(176, 28);
            contenidoToolStripMenuItem.Text = "&Contenido";
            // 
            // índiceToolStripMenuItem
            // 
            índiceToolStripMenuItem.Name = "índiceToolStripMenuItem";
            índiceToolStripMenuItem.Size = new Size(176, 28);
            índiceToolStripMenuItem.Text = "Índ&ice";
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(176, 28);
            buscarToolStripMenuItem.Text = "&Buscar";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(173, 6);
            // 
            // acercadeToolStripMenuItem
            // 
            acercadeToolStripMenuItem.Name = "acercadeToolStripMenuItem";
            acercadeToolStripMenuItem.Size = new Size(176, 28);
            acercadeToolStripMenuItem.Text = "&Acerca de...";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ic__outline_search;
            pictureBox1.Location = new Point(504, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(0, 15, 0, 0);
            pictureBox1.Size = new Size(45, 59);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBoxUser);
            panel4.Controls.Add(test1);
            panel4.Location = new Point(191, 46);
            panel4.Name = "panel4";
            panel4.Size = new Size(318, 59);
            panel4.TabIndex = 6;
            // 
            // textBoxUser
            // 
            textBoxUser.BorderStyle = BorderStyle.None;
            textBoxUser.Font = new Font("Victor Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUser.ForeColor = Color.Black;
            textBoxUser.Location = new Point(37, 19);
            textBoxUser.MaxLength = 30;
            textBoxUser.Multiline = true;
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(250, 18);
            textBoxUser.TabIndex = 4;
            // 
            // test1
            // 
            test1.BackColor = Color.Transparent;
            test1.BorderColor = Color.FromArgb(45, 106, 79);
            test1.BorderHeight = 1;
            test1.ForeColor = Color.Coral;
            test1.Location = new Point(18, 14);
            test1.Name = "test1";
            test1.Size = new Size(293, 30);
            test1.TabIndex = 4;
            // 
            // FormularioInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 151);
            Controls.Add(pictureBox1);
            Controls.Add(panel4);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "FormularioInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioInicio";
            Load += FormularioInicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem1;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem guardarcomoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripMenuItem vistapreviadeimpresiónToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem deshacerToolStripMenuItem;
        private ToolStripMenuItem rehacerToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem cortarToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem pegarToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem seleccionartodoToolStripMenuItem;
        private ToolStripMenuItem herramientasToolStripMenuItem;
        private ToolStripMenuItem personalizarToolStripMenuItem;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem contenidoToolStripMenuItem;
        private ToolStripMenuItem índiceToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem acercadeToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private PictureBox pictureBox1;
        private Panel panel4;
        private TextBox textBoxUser;
        private Models.Test test1;
    }
}