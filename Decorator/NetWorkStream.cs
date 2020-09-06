namespace DesignPattern.Decorator
{
    public class NetWorkStream:Stream
    {
        public override void Read(int number)
        {
            System.Console.WriteLine("NetWorkStream Read");
        }

        public override void Seek(int position)
        {
            System.Console.WriteLine("NetWorkStream Seek");
        }

        public override void Write(byte[] bytes)
        {
            System.Console.WriteLine("NetWorkStream Read");
        }
    }
}