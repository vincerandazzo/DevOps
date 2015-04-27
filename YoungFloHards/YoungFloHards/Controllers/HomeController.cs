using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;
using YoungFloHards.Models;

namespace YoungFloHards.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubmitContactUsForm(ContactUs contactModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MailMessage msg = new MailMessage();
                    SmtpClient smtp = new SmtpClient("smtpout.secureserver.net");
                    smtp.Credentials = new System.Net.NetworkCredential("silijon", "jonathon58");
                    MailAddress from = new MailAddress(contactModel.Email.ToString());
                    StringBuilder sb = new StringBuilder();

                    smtp.Host = "mail.youngflohards.com";
                    smtp.Port = 25;
                    msg.To.Add("info@youngflohards.com");
                    msg.From = from;
                    msg.Subject = "Contact Inquiry with the Young Flo Hards";
                    msg.IsBodyHtml = false;
                    sb.Append("Name: " + contactModel.Name);
                    sb.Append(Environment.NewLine);
                    sb.Append("Email: " + contactModel.Email);
                    sb.Append(Environment.NewLine);
                    sb.Append("Message: " + contactModel.Message);
                    msg.Body = sb.ToString();
                    smtp.Send(msg);
                    msg.Dispose();
                }
                catch (Exception e)
                {
                    var error = e.Message;
                    TempData["ContactResult"] = "error";
                    return RedirectToAction("Index");
                }
            }
            TempData["ContactResult"] = "success";
            return RedirectToAction("Index");
        }
    }
}