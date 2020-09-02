namespace designpattern.Strategy
    {
    public interface ITax
    {
        decimal CaculateTax();
    }

    public class AmericanTax : ITax
    {
        public decimal CaculateTax()
        {
            return 0;
        }
    }

    public class FranceTax:ITax
    {
         public decimal CaculateTax()
        {
            return 0;
        } 
    }

    public class EnglandTax:ITax
    {
         public decimal CaculateTax()
        {
            return 0;
        } 
    }

    public class SalesOrder
    {
        private readonly ITax _tax;
        public SalesOrder()
        {
            //这里需要使用到工厂模式 后续再修改
            //_tax = StrategyFactory.CreateStrategy();
        }

        public decimal CaculateTax()
        {
            //这里实现了多肽,会根据不同的国家创建不同的税率算法
            return _tax.CaculateTax();
        }
    }
}