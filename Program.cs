using System.Security.Cryptography;
using System.IO;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Normal Method 
            var file = new DesignPattern.Normal.CryptoFileStream();
            var network = new DesignPattern.Normal.CryptoNetworkStream();

            file.Read(12);
            network.Read(12);

            //Decorator Method
            var fileStream = new DesignPattern.Decorator.FileStream();
            var networkStream = new DesignPattern.Decorator.NetWorkStream(); 
            
            var filecrypto = new DesignPattern.Decorator.CryptoStream(fileStream);
            var networkcrypto = new DesignPattern.Decorator.CryptoStream(networkStream);

            filecrypto.Read(12);
            networkcrypto.Read(12);

            //Decorator Method (内存流加密又缓冲)
            var memory = new DesignPattern.Decorator.MemoryStream();
            var crypto = new DesignPattern.Decorator.CryptoStream(memory);
            var buffer = new DesignPattern.Decorator.BufferStream(crypto);
            
            buffer.Read(12);
        }
    }
}
