namespace DesignPattern.Decorator
{
    public class FileStream:Stream
    {
        public override void Read(int number)
        {
            System.Console.WriteLine("FileStream Read");
        }

        public override void Seek(int position)
        {
            System.Console.WriteLine("FileStream Seek");
        }

        public override void Write(byte[] bytes)
        {
            System.Console.WriteLine("FileStream Read");
        }
    }
}