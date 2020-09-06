namespace DesignPattern.Normal
{
    public class NetworkStream:Stream
    {
        public override void Read(int number)
        {
            System.Console.WriteLine("NetworkStream Read");
        }

        public override void Seek(int position)
        {
            System.Console.WriteLine("NetworkStream Seek");
        }

        public override void Write(byte[] bytes)
        {
            System.Console.WriteLine("NetworkStream Write");
        }
    }
}