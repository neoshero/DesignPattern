namespace designpattern.Normal
{
    public class CookerControl
    {
        private readonly TemperatureControl _temperatureControl;

        public CookerControl(TemperatureControl temperatureControl)
        {
            _temperatureControl = temperatureControl;
        }

        public void OnNotify(int temperature)
        {
            _temperatureControl.DoWork(temperature);
        }
    }

    public class TemperatureControl
    {
        public void DoWork(int temperature)
        {
            System.Console.WriteLine($"温度控件提示,当前温度{temperature}");
        }
    }

    public class Program
    {
        private readonly CookerControl _cookerControl;
        public Program()
        {
            _cookerControl = new CookerControl(new TemperatureControl());
        }

        public void Main()
        {
            for(var temperature = 1;temperature <= 100; temperature++)
            {
                OnUpdate(temperature);
            }
            
        }

        public void  OnUpdate(int temperature)
        {
            _cookerControl.OnNotify(temperature);
        }
    }
    
}