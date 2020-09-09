using System.Collections.Generic;

namespace designpattern.ObServerMaster
{
    public interface IControl
    {
        void DoWork(int temperature);
    }

    public class SafeControl:IControl
    {
        public void DoWork(int temperature)
        {
            if(temperature >= 100)
            {
                System.Console.WriteLine($"电磁炉已经停止工作");
            }
        }
    } 
    
    public class WarningLightControl:IControl
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

    public class CookerControl
    {
        private IList<IControl> _list;

        public CookerControl()
        {
            _list = new List<IControl>();
        }

        public void AddControl(IControl contrll)
        {
            _list.Add(contrll);
        }

        public void RemoveControl(IControl Control)
        {
            _list.Remove(Control);
        }

        public void OnNotify(int temperature)
        {
            if(_list != null)
            {
                foreach(var Control in _list)
                {
                    Control.DoWork(temperature);
                }
            }
           
        }
    }

    public class Program
    {
        public readonly CookerControl _cookerControl;

        public Program()
        {
            _cookerControl = new CookerControl();
            _cookerControl.AddControl(new SafeControl());
            _cookerControl.AddControl(new WarningLightControl());
        }
        public void Main()
        {
            for(var temperature = 1;temperature <= 100 ;temperature++)
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