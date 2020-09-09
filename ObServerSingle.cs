using System.Threading.Tasks;
namespace designpattern.ObServerSingle
{
    public interface IControl
    {
        void DoWork(int temperature);
    }

    public class WarningLightControl:IControl
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

    public class CookerControl
    {
        private readonly IControl _Control;

        public CookerControl(IControl Control)
        {
            _Control = Control;
        }

        public void OnNotify(int temperature)
        {
            _Control.DoWork(temperature);
        }
    }

    public class Program
    {
        private readonly CookerControl _cookerControl;
        public Program()
        {
            _cookerControl = new CookerControl(new WarningLightControl());
        }

        public void Main()
        {
           for(var temperature = 1; temperature <= 100;temperature++)
           {
               OnUpdate(temperature);
           }
        }

        public void OnUpdate(int temperature)
        {
            _cookerControl.OnNotify(temperature);
        }
    }
    
}