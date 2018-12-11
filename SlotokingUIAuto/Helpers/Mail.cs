using System.Net.Mail;

namespace SlotokingUIAuto
{
    static class Mail
    {
        public static void SendMail(string path, string text)
        {           
            MailAddress from = new MailAddress("dijust.test@gmail.com", "KingUIAuto");            
            MailAddress to = new MailAddress("amys@cleack.com");           
            MailMessage m = new MailMessage(from, to);          
            m.Subject = text + " run failure";          
            m.Body = "Game run failure" + text;
            Attachment att = new Attachment(path);
            m.Attachments.Add(att);
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);           
            smtp.Credentials = new System.Net.NetworkCredential("dijust.test@gmail.com", "qweasdzxcvvv");
            smtp.EnableSsl = true;
            smtp.Send(m);            
        }        
    }
}
