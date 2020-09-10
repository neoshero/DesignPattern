namespace DesignPattern.Decorator
{
    public class CryptoStream:DecoratorStream
    {
        public CryptoStream(Stream stream):base(stream)
        {
            
        }

        public override void Read(int number)
        {
            System.Console.WriteLine("CryptoStream Read");
            base.Read(number);
        }

        public override void Seek(int position)
        {
            System.Console.WriteLine("CryptoStream Seek");
            base.Seek(position);
        }

        public override void Write(byte[] bytes)
        {
            System.Console.WriteLine("CryptoStream Read");
            base.Write(bytes);
        }
    }
}