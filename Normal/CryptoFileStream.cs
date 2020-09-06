namespace DesignPattern.Normal
{
    public class CryptoFileStream:FileStream
    {
        public override void Read(int number)
        {
            //解密
            System.Console.WriteLine("文件流解密工作");
            base.Read(number);
        }

        public override void Seek(int position)
        {
            base.Seek(position);
        }

        public override void Write(byte[] bytes)
        {
            //加密
            System.Console.WriteLine("文件流加密工作");
            base.Write(bytes);
        }
    }
}