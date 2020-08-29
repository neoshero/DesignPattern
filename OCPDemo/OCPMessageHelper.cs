namespace designpattern.OCPDemo
{
    /** 开放封闭原则(OCP) 对接口开方 对变化封闭
        对接口开方:我们抽象了一个统一的发送信息接口IMessage,并提供提供的Api SendMessage
        对变化封闭:公路类OCPMessageHelper不关心IMessage的具体类型,只负责调用Api
    **/
    public class OCPMessageHelper
    {
        private readonly IMessage _message;

        public OCPMessageHelper(IMessage message)
        {
            _message = message;
        }

        public void SendMessage(string msg)
        {
            _message.SendMessage(msg);
        }
    }
}