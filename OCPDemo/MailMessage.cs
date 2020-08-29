namespace designpattern.OCPDemo
{
    public class MailMessage : IMessage
    {
        public void SendMessage(string msg)
        {
            System.Console.WriteLine($"Info:{msg}");
        }
    }
}