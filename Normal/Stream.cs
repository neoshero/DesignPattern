namespace DesignPattern.Normal
{
    /*  
        在软件开发过程中,我们常常要对数据流的信息进行处理，于是定义一个文件开发的抽象类(Stream),处理数据流信息
        
        第一阶段:我们支持不同的流处理方法,定义了三种处理数据流的方式FileStream(文件流),NetWorkStream(网络流),MemoryStream(内存流)
        第二阶段:我们发现流文件信息太透明,不想文件直接暴露,于是对三种流文件的续写工作进行加密
                然后创建了三个加密功能流文件SecurityFileStream,SecurityNetworkStream,SecurityMemoryStream
        第三阶段:我们想对流进行缓冲处理,于是又添加处理缓冲三个功能BufferFileStream,BufferNetWorkStream,BufferMemoryStream
        这样的设计方式会导致我们的子类无线的增加,随着功能的变化,子类的数量变得非常的庞大,难以维护
    */
    public abstract class Stream
    {
        public abstract void Read(int number);
        
        public abstract void Seek(int position);
      
        public abstract void Write(byte[] bytes);
    }
}