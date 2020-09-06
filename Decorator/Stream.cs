namespace DesignPattern.Decorator
{
    /*  装配模式
        第一阶段 首先针对不同的流进行处理FileStream,MemoryStream,NetWorkStream (单一职责)
        第二阶段 增加了流的加密工作,我们设计了一个开方的类DecoratorStream,来应对额外的变化(拓展)
        第三阶段 设计两个灵活的加密方法CryptoStream,BufferStream(组装,复用)
    */
    public abstract class Stream
    {
        public virtual void Read(int number)
        {
            System.Console.WriteLine("Stream Read");
        }
        public virtual void Seek(int position)
        {
            System.Console.WriteLine("Stream Seek");
        }
        public virtual void Write(byte[] bytes)
        {
            System.Console.WriteLine("Stream Write");
        }
    }
}