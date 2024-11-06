using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SegundoProyecto.Models
{
    public partial class FormularioMensaje : Form
    {

        //Fields
        private Color primaryColor = Color.FromArgb(252, 152, 116);
        private int borderSize = 2;

        //Properties
        public Color PrimaryColor
        {
            get { return primaryColor; }
            set
            {
                primaryColor = value;
                this.panelTitleBar.BackColor = PrimaryColor;//Title Bar Back Color
            }
        }

        //Constructors
        public FormularioMensaje(string text)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = Color.FromArgb(252, 152, 116);
            this.labelMessage.Text = text;
            this.labelCaption.Text = "";
            SetFormSize();
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);//Set Default Buttons
        }
        public FormularioMensaje(string text, string caption)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = Color.FromArgb(252, 152, 116);
            this.labelMessage.Text = text;
            this.labelCaption.Text = caption;
            SetFormSize();
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);//Set Default Buttons
        }
        public FormularioMensaje(string text, string caption, MessageBoxButtons buttons)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.labelMessage.Text = text;
            this.labelCaption.Text = caption;
            SetFormSize();
            SetButtons(buttons, MessageBoxDefaultButton.Button1);//Set [Default Button 1]
        }
        public FormularioMensaje(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.labelMessage.Text = text;
            this.labelCaption.Text = caption;
            SetFormSize();
            SetIcon(icon);
            SetButtons(buttons, MessageBoxDefaultButton.Button1);//Set [Default Button 1]

        }
        public FormularioMensaje(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.labelMessage.Text = text;
            this.labelCaption.Text = caption;
            SetFormSize();
            SetIcon(icon);
            SetButtons(buttons, defaultButton);
        }

        //-> Private Methods
        private void InitializeItems()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);//Set border size
            this.labelMessage.MaximumSize = new Size(350, 0);
            this.buttonClose.DialogResult = DialogResult.Cancel;
            this.button1.DialogResult = DialogResult.OK;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
        }
        private void SetFormSize()
        {
            int widht = this.panelBody.Width;
            int height = this.panelTitleBar.Height + this.panelButtons.Height + this.panelBody.Height;
            this.Size = new Size(widht, height);
        }
        private void SetButtons(MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
        {
            int xCenter = (this.panelButtons.Width - button1.Width) / 2;
            int yCenter = (this.panelButtons.Height - button1.Height) / 2;

            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    //OK Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter, yCenter);
                    button1.Text = "Ok";
                    button1.DialogResult = DialogResult.OK;//Set DialogResult
                    button1.BackColor = Funcionalidades.CambiarBrillo(primaryColor, 0.1);

                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;
                case MessageBoxButtons.OKCancel:
                    //OK Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - (button1.Width / 2) - 5, yCenter);
                    button1.Text = "Ok";
                    button1.DialogResult = DialogResult.OK;//Set DialogResult
                    button1.BackColor = Funcionalidades.CambiarBrillo(primaryColor, -0.1);

                    //Cancel Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter + (button2.Width / 2) + 5, yCenter);
                    button2.Text = "Cancelar";
                    button2.DialogResult = DialogResult.Cancel;//Set DialogResult
                    button2.BackColor = Funcionalidades.CambiarBrillo(primaryColor, 0.2);

                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;

                case MessageBoxButtons.RetryCancel:
                    //Retry Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - (button1.Width / 2) - 5, yCenter);
                    button1.Text = "Intentar de nuevo";
                    button1.DialogResult = DialogResult.Retry;//Set DialogResult
                    button1.BackColor = Funcionalidades.CambiarBrillo(primaryColor, -0.1);
                    //Cancel Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter + (button2.Width / 2) + 5, yCenter);
                    button2.Text = "Cancelar";
                    button2.DialogResult = DialogResult.Cancel;//Set DialogResult
                    button2.BackColor = Funcionalidades.CambiarBrillo(primaryColor, 0.2);

                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;

                case MessageBoxButtons.YesNo:
                    //Yes Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - (button1.Width / 2) - 5, yCenter);
                    button1.Text = "Sí";
                    button1.DialogResult = DialogResult.Yes;//Set DialogResult
                    button1.BackColor = Funcionalidades.CambiarBrillo(primaryColor, -0.1);
                    //No Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter + (button2.Width / 2) + 5, yCenter);
                    button2.Text = "No";
                    button2.DialogResult = DialogResult.No;//Set DialogResult
                    button2.BackColor = Funcionalidades.CambiarBrillo(primaryColor, 0.2);
                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;
                case MessageBoxButtons.YesNoCancel:
                    //Yes Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - button1.Width - 5, yCenter);
                    button1.Text = "Sí";
                    button1.DialogResult = DialogResult.Yes;//Set DialogResult
                    button1.BackColor = Funcionalidades.CambiarBrillo(primaryColor, -0.1);
                    //No Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter, yCenter);
                    button2.Text = "No";
                    button2.DialogResult = DialogResult.No;//Set DialogResult
                    button2.BackColor = Funcionalidades.CambiarBrillo(primaryColor, 0.2);
                    //Cancel Button
                    button3.Visible = true;
                    button3.Location = new Point(xCenter + button2.Width + 5, yCenter);
                    button3.Text = "Cancelar";
                    button3.DialogResult = DialogResult.Cancel;//Set DialogResult
                    button3.BackColor = Funcionalidades.CambiarBrillo(primaryColor, 0.4);

                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;

                case MessageBoxButtons.AbortRetryIgnore:
                    //Abort Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - button1.Width - 5, yCenter);
                    button1.Text = "Anular";
                    button1.DialogResult = DialogResult.Abort;//Set DialogResult
                    button1.BackColor = Funcionalidades.CambiarBrillo(primaryColor, -0.1);
                    //Retry Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter, yCenter);
                    button2.Text = "Intentarlo de nuevo";
                    button2.DialogResult = DialogResult.Retry;//Set DialogResult                    
                    button2.BackColor = Funcionalidades.CambiarBrillo(primaryColor, 0.2);
                    //Ignore Button
                    button3.Visible = true;
                    button3.Location = new Point(xCenter + button2.Width + 5, yCenter);
                    button3.Text = "Ignorar";
                    button3.DialogResult = DialogResult.Ignore;//Set DialogResult
                    button3.BackColor = Color.IndianRed;
                    button3.BackColor = Funcionalidades.CambiarBrillo(primaryColor, 0.4);
                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;
            }
        }
        private void SetDefaultButton(MessageBoxDefaultButton defaultButton)
        {
            switch (defaultButton)
            {
                case MessageBoxDefaultButton.Button1://Focus button 1
                    button1.Select();
                    button1.ForeColor = Color.White;
                    button1.Font = new System.Drawing.Font(button1.Font, FontStyle.Underline);
                    break;
                case MessageBoxDefaultButton.Button2://Focus button 2
                    button2.Select();
                    button2.ForeColor = Color.White;
                    button2.Font = new System.Drawing.Font(button2.Font, FontStyle.Underline);
                    break;
                case MessageBoxDefaultButton.Button3://Focus button 3
                    button3.Select();
                    button3.ForeColor = Color.White;
                    button3.Font = new System.Drawing.Font(button3.Font, FontStyle.Underline);
                    break;
            }
        }
        private void SetIcon(MessageBoxIcon icon)
        {
            switch (icon)
            {
                case MessageBoxIcon.Error: //Error
                    this.pictureBoxIcon.Image = Properties.Resources.error_icon;
                    PrimaryColor = Color.FromArgb(255, 86, 96);
                    this.buttonClose.FlatAppearance.MouseOverBackColor = Color.Crimson;
                    break;
                case MessageBoxIcon.Information: //Information
                    this.pictureBoxIcon.Image = Properties.Resources.info_icon;
                    PrimaryColor = Color.FromArgb(37, 150, 190);
                    break;
                case MessageBoxIcon.Question://Question
                    this.pictureBoxIcon.Image = Properties.Resources.question_icon;
                    PrimaryColor = Color.FromArgb(176, 124, 236);
                    break;
                case MessageBoxIcon.Exclamation://Exclamation
                    this.pictureBoxIcon.Image = Properties.Resources.advertencia_icon;
                    PrimaryColor = Color.FromArgb(255, 176, 46);
                    break;
                case MessageBoxIcon.None: //None
                    this.pictureBoxIcon.Image = Properties.Resources.flat_color_icons__ok1;
                    PrimaryColor = Color.FromArgb(76, 172, 76);
                    break;
            }
        }

        //-> Events Methods

        private void panelTitleBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            Librerias.ReleaseCapture();
            Librerias.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}