using System.Collections.Generic;

namespace designpattern.ObServerMaster
{
    public interface IControll
    {
        void DoWork(int temperature);
    }

    public class SafeControll:IControll
    {
        public void DoWork(int temperature)
        {
            if(temperature >= 100)
            {
                System.Console.WriteLine($"电磁炉已经停止工作");
            }
        }
    } 
    
    public class WarningLightControll:IControll
    {
        public void DoWork(int temperature)
        {
            if(temperature < 40)
            {
                System.Console.WriteLine($"指示灯提示,灯边绿了");
            }
            else if(temperature >= 40 && temperature <= 80)
            {
                System.Console.WriteLine($"指示灯提示,灯边黄了");
            }
            else if(temperature > 80)
            {
                System.Console.WriteLine($"指示灯提示,灯变红了");
            }
        }
    }

    public class CookerControll
    {
        private IList<IControll> _list;

        public CookerControll()
        {
            _list = new List<IControll>();
        }

        public void AddControll(IControll contrll)
        {
            _list.Add(contrll);
        }

        public void RemoveControll(IControll controll)
        {
            _list.Remove(controll);
        }

        public void OnNotify(int temperature)
        {
            if(_list != null)
            {
                foreach(var controll in _list)
                {
                    controll.DoWork(temperature);
                }
            }
           
        }
    }

    public class Program
    {
        public readonly CookerControll _cookerControll;

        public Program()
        {
            _cookerControll = new CookerControll();
            _cookerControll.AddControll(new SafeControll());
            _cookerControll.AddControll(new WarningLightControll());
        }
        public void Main()
        {
            for(var temperature = 1;temperature <= 100 ;temperature++)
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