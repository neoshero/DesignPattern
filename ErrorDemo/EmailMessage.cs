namespace designpattern.ErrorDemo
{
    public class EmailMessage
    {
         public void SendMail(string msg)
        {
            System.Console.WriteLine($"email:Happy Holidays.{msg}");
        }
    }
}