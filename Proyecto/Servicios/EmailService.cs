using System;
using System.Net;
using System.Net.Mail;

namespace Servicios.Email;

public static class EmailSender
{
    private static readonly string remitente = "aerolineasoporte@gmail.com";
    private static readonly string displayName = "Gestión de Usuarios";
    private static readonly string contraseña = "tdem eviu divp agxl";
    private static readonly string hostSmtp = "smtp.gmail.com";
    private static readonly int puerto = 587;

    public static void EnviarBienvenida(string destinatario, string nombre, string usuario, string contrasena)
    {
        string asunto = "Credenciales de Acceso a Tu Sistema";
        string cuerpoHtml;

        try
        {
            string rutaPlantilla = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plantillas\\Plantilla.html");
            cuerpoHtml = File.ReadAllText(rutaPlantilla);

            string tituloEmail = "¡Bienvenido a Tu Sistema de Gestión!";
            string mensajeCuerpo = $"<p>Hola <span class=\"dato\">{nombre}</span>,</p>" +
                                   $"<p>Tu cuenta ha sido creada exitosamente.</p>" +
                                   $"<p>Tu nombre de usuario es: <span class=\"dato\">{usuario}</span></p>" +
                                   $"<p>Tu contraseña genérica es: <span class=\"dato\">{contrasena}</span></p>" +
                                   $"<p>Por favor, inicia sesión y cambia tu contraseña lo antes posible.</p>" +
                                   $"<p>Saludos,<br>Tu Equipo de Gestión</p>";

            cuerpoHtml = cuerpoHtml.Replace("@TITULO", tituloEmail)
                                   .Replace("@CUERPO", mensajeCuerpo);
        }
        catch (Exception)
        {
            // Fallback a texto plano
            cuerpoHtml = $"Hola {nombre},\n\n" +
                         $"Tu cuenta ha sido creada exitosamente.\n" +
                         $"Usuario: {usuario}\n" +
                         $"Contraseña: {contrasena}\n\n" +
                         $"Por favor, inicia sesión y cambia tu contraseña.";
        }

        Enviar(destinatario, asunto, cuerpoHtml);
    }

    private static void Enviar(string destinatario, string asunto, string contenidoHtml)
    {
        try
        {
            var mensaje = new MailMessage
            {
                From = new MailAddress(remitente, displayName),
                Subject = asunto,
                Body = contenidoHtml,
                IsBodyHtml = true
            };
            mensaje.To.Add(destinatario);

            var smtp = new SmtpClient(hostSmtp, puerto)
            {
                Credentials = new NetworkCredential(remitente, contraseña),
                EnableSsl = true
            };

            smtp.Send(mensaje);
        }
        catch (Exception ex)
        {
            throw new Exception("❌ Error al enviar el correo: " + ex.Message);
        }
    }
}

