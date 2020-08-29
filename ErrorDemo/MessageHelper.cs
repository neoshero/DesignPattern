namespace designpattern.ErrorDemo
{
    /** 发送信息业务 
        第一次添加邮件业务,我们创建了一个邮件对象
        第二次添加手机短信业务,创我们创建一个手机短信对象
        随着业务增加,业务代码越来越多,无法应对越来越多的变化,变得难以维护
    **/
    public class MessageHelper
    {
        private readonly EmailMessage _emailMessage;
        private readonly PhoneMessage _phoneMessage;

        private readonly MessageType _messageType;
        public MessageHelper(MessageType messageType)
        {
            _messageType = messageType;
            switch(messageType)
            {
                case MessageType.Email: _emailMessage = new EmailMessage();break;
                case MessageType.Phone: _phoneMessage = new PhoneMessage();break;
            }
        }

        public void SendMessage(string msg)
        {
            switch(_messageType)
            {
                case MessageType.Email: _emailMessage.SendMail(msg);break;
                case MessageType.Phone: _phoneMessage.SendPhone(msg);break;
            }
        }
       
    }

    
}