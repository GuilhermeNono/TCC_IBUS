using IBuS_6._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System.Text;

namespace IBuS_6._0.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(SendMail.Models.MailModel _objModelMail)
        {
            if (ModelState.IsValid)
            {
                //Instância classe email
                MailMessage mail = new MailMessage();
                mail.To.Add(_objModelMail.To = "IBuS.contato@gmail.com");
                mail.From = new MailAddress(_objModelMail.From);
                mail.Subject = _objModelMail.Subject;
                string Body = getBody(_objModelMail.Body, _objModelMail.From);
                mail.Body = Body;
                mail.IsBodyHtml = true;

                //Instância smtp do servidor, neste caso o gmail.
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential
                ("IBuS.contato@gmail.com", "");// Login e senha do e-mail.
                smtp.EnableSsl = true;
                smtp.Send(mail);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        private string getBody(string body, string from)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<div>");
            sb.Append("<h2>Recebemos sua mensagem</h2>");

            sb.Append("<p>");
            sb.Append(body);
            sb.Append("</p>");

            sb.Append("<h3>E-mail do usuário</h3>");
            sb.Append("<h5>");
            sb.Append(from);
            sb.Append("</h5>");

            sb.Append("<p style='color: blue;'>Em breve entraremos em contato</p>");
            
            sb.Append("</div>");

            return sb.ToString();

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Mapa()
        {
            return View();
        }
    }
}