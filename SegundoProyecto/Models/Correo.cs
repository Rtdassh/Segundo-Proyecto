using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.Security;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProyecto.Models
{
    internal class Correo
    {
        private string myEmail = "greencircuit3000@gmail.com";
        private string MyPassword = "";
        private string MyAlias = "Josu";
        private MailMessage? mCorreo;

        public void CrearCuerpoCorreo(string destinatario)
        {
            mCorreo = new MailMessage();
            mCorreo.From = new MailAddress(myEmail, MyAlias, System.Text.Encoding.UTF8);
            mCorreo.To.Add(destinatario);
            mCorreo.Subject = "Registro a Biblioteca";
            mCorreo.Body = "Agradecemos tu confianza en nuestra biblioteca ";
            mCorreo.IsBodyHtml = true;
            mCorreo.Priority = MailPriority.Normal;

            Enviar();
        }

        private void Enviar()
        {
            try
            {
                SmtpClient smtp = new SmtpClient
                {
                    UseDefaultCredentials = false,
                    Port = 587,
                    Host = "smtp.gmail.com",
                    Credentials = new NetworkCredential(myEmail, MyPassword),
                    EnableSsl = true
                };
                ServicePointManager.ServerCertificateValidationCallback = (s, certificate, chain, sslPolicyErrors) => true;
                smtp.Send(mCorreo!);
                MessageBox.Show("Enviado");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

    }
}
