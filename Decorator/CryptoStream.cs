namespace DesignPattern.Decorator
{
    public class CryptoStream:DecoratorStream
    {
        public CryptoStream(Stream stream):base(stream)
        {
            
        }

        public override void Read(int number)
        {
            System.Console.WriteLine("SecurityStream Read");
            base.Read(number);
        }

        public override void Seek(int position)
        {
            System.Console.WriteLine("SecurityStream Seek");
            base.Seek(position);
        }

        public override void Write(byte[] bytes)
        {
            System.Console.WriteLine("SecurityStream Read");
            base.Write(bytes);
        }
    }
}