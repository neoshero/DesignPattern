namespace DesignPattern.Normal
{
    public class BufferMemoryStream:MemoryStream
    {
        public override void Read(int number)
        {
            //缓冲处理
            System.Console.WriteLine("内存流缓冲Read工作");
            base.Read(number);
        }

        public override void Seek(int position)
        {
            base.Seek(position);
        }

        public override void Write(byte[] bytes)
        {
            //缓冲处理
            System.Console.WriteLine("内存流缓冲Read工作");
            base.Write(bytes);
        }
    }
}