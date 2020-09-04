namespace designpattern.Normal
{
    public class CookerControll
    {
        private readonly TemperatureControll _temperatureControll;

        public CookerControll(TemperatureControll temperatureControll)
        {
            _temperatureControll = temperatureControll;
        }

        public void OnNotify(int temperature)
        {
            _temperatureControll.DoWork(temperature);
        }
    }

    public class TemperatureControll
    {
        public void DoWork(int temperature)
        {
            System.Console.WriteLine($"温度控件提示,当前温度{temperature}");
        }
    }

    public class Program
    {
        private readonly CookerControll _cookerControll;
        public Program()
        {
            _cookerControll = new CookerControll(new TemperatureControll());
        }

        public void Main()
        {
            for(var temperature = 1;temperature <= 100; temperature++)
            {
                OnNotify(temperature);
            }
            
        }

        public void  OnNotify(int temperature)
        {
            _cookerControll.OnNotify(temperature);
        }
    }
    
}