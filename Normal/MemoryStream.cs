namespace DesignPattern.Normal
{
    public class MemoryStream:Stream
    {
        public override void Read(int number)
        {
            System.Console.WriteLine("MemoryStream Read");
        }

        public override void Seek(int position)
        {
            System.Console.WriteLine("MemoryStream Seek");
        }

        public override void Write(byte[] bytes)
        {
            System.Console.WriteLine("MemoryStream Write");
        }
    }
}