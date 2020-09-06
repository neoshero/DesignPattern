namespace DesignPattern.Decorator
{
    /*
        遵循重构的原则,当子类存在相同的方法
    */
    public class DecoratorStream:Stream
    {
        private readonly Stream _stream;
        public DecoratorStream(Stream stream)
        {
            _stream = stream;
        }

        public override void Read(int number)
        {
          
            _stream.Read(number);
        }

        public override void Seek(int position)
        {
            _stream.Seek(position);
        }

        public override void Write(byte[] bytes)
        {
            _stream.Write(bytes);
        }
    }
}