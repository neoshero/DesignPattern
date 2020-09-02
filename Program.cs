using System;
using designpattern.Normal;
namespace designpattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Normal();
            TemplateMethod();
            Console.WriteLine("Finish!");
            Console.ReadKey();
        }

        /*
            当程序存在流程开发的时候,框架与应用程序时间紧密联系在一起
            该流程步骤属于早绑定模式
            先知道的FrameWork和Libary,然后主要的流程交给Application(客户端处理)
        */
        public static void Normal()
        {
            var libary = new Libary();
            var app = new Application();

            libary.Step1();
            if(app.Step2())
            {
                libary.Step3();
            }
            for(var i = 0 ; i < 10; i++)
            {
                app.Step4();
            }
            libary.Step5();
        }
        /*
            模板方法给我们将我们流程已经定义好(稳定)
            通过Virtual方法处理变化的点(变化)
        */
        public static void TemplateMethod()
        {
            var app = new designpattern.TemplateMethod.Application();
            app.Run();
        }
    }


}
