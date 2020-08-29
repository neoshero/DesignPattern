using System;
using designpattern.ErrorDemo;
using designpattern.OCPDemo;

namespace designpattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  ErrorDemo   
            var messageHelper = new MessageHelper(MessageType.Email);
            messageHelper.SendMessage("Email information.");

            var phoneHelper = new MessageHelper(MessageType.Phone);
            phoneHelper.SendMessage("Phone information.");
            #endregion

            #region OCP
            IMessage message = new MailMessage();
            var ocpMessageHelper = new OCPMessageHelper(message);
            ocpMessageHelper.SendMessage("Email information.");

            message = new MobileMessage();
            var ocpMobileHelper = new OCPMessageHelper(message);
            ocpMobileHelper.SendMessage("Phone information.");
            #endregion
        }
    }
}
