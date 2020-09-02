namespace designpattern.Normal
{
    public enum  Tax
    {
        England,
        American,
        France
    }

    public class SalesOrder
    {
        public Tax _tax;

        //当我们需要计算税率的国家越来越多,程序维护与拓展性大大降低
        public decimal CaculateTax()
        {
        if(_tax == Tax.American)
        {
            //doWrok
        }
        else if(_tax == Tax.England)
        {
            //doWork
        }
        else if(_tax == Tax.France)
        {
            //doWork
        }
        return 0m;
        }
    }
    
}
