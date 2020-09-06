namespace DesignPattern.Decorator
{
    public class BufferStream:DecoratorStream
    {
        public BufferStream(Stream stream):base(stream)
        {
            
        }

        public override void Read(int number)
        {
            System.Console.WriteLine("BufferStream Read");
            base.Read(number);
        }

        public override void Seek(int position)
        {
            System.Console.WriteLine("BufferStream Seek");
            base.Seek(position);
        }

        public override void Write(byte[] bytes)
        {
            System.Console.WriteLine("BufferStream Read");
            base.Write(bytes);
        }
    }
}