namespace DesignPattern.Normal
{
    public class CryptoNetworkStream:NetworkStream
    {
        public override void Read(int number)
        {
            //解密
            System.Console.WriteLine("网络流解密工作");
            base.Read(number);
        }

        public override void Seek(int position)
        {
            base.Seek(position);
        }

        public override void Write(byte[] bytes)
        {
            //加密
            System.Console.WriteLine("网络流加密工作");
            base.Write(bytes);
        }
    }
}