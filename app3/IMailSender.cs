namespace Interface {
    public interface IMailSender
    {
        void Send(string toAddress, string subject);
    }
}