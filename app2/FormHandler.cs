using Mail;

namespace Form {
    public class FormHandler
    {
        public void Handle(string toAddress)
        {
            MailSender mailSender = new MailSender();
            mailSender.Send(toAddress, "Forte Acoplamento.");
        }
    }
}