namespace designpattern.OCPDemo
{
    public class MobileMessage : IMessage
    {
        public void SendMessage(string msg)
        {
            System.Console.WriteLine($"Info:{msg}");
        }
    }
}