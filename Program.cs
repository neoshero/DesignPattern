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
            // var security = new DesignPattern.Normal.SecurityFileStream();
            // security.Read(12);

            //Decorator Method
            var networkStream = new DesignPattern.Decorator.NetWorkStream(); 
            var crypto = new DesignPattern.Decorator.CryptoStream(networkStream);
            var buffer = new DesignPattern.Decorator.BufferStream(crypto);
            buffer.Read(1);

            // CryptoStream

        }
    }
}
