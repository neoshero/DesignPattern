using System.Threading.Tasks;
namespace designpattern.ObServerSingle
{
    public interface IControll
    {
        void DoWork(int temperature);
    }

    public class WarningLightControll:IControll
    {
        public void DoWork(int temperature)
        {
             if(temperature < 40)
            {
                System.Console.WriteLine($"指示灯提示,绿灯亮了");
            }
            else if(temperature >= 40 && temperature <= 80)
            {
                System.Console.WriteLine($"指示灯提示,黄灯亮了");
            }
            else if(temperature > 80)
            {
                System.Console.WriteLine($"指示灯提示,红灯亮了");
            }
        }
    }

    public class CookerControll
    {
        private readonly IControll _controll;

        public CookerControll(IControll controll)
        {
            _controll = controll;
        }

        public void OnNotify(int temperature)
        {
            _controll.DoWork(temperature);
        }
    }

    public class Program
    {
        private readonly CookerControll _cookerControll;
        public Program()
        {
            _cookerControll = new CookerControll(new WarningLightControll());
        }

        public void Main()
        {
           for(var temperature = 1; temperature <= 100;temperature++)
           {
               OnNotify(temperature);
           }
        }

        public void OnNotify(int temperature)
        {
            _cookerControll.OnNotify(temperature);
        }
    }
    
}