using System.Collections.Generic;
using System.Linq;

namespace designpattern.Strategy
{
    //抽象一个
    public interface IDiscountStrategy
    {
        decimal CaculateCost(IList<decimal> products);
    }

    //买300减20
    public class FullAndSubstract : IDiscountStrategy
    {
        public decimal CaculateCost(IList<decimal> products)
        {
            decimal cost = 0m;
            if(products != null)
            {   
                cost = products.Sum();
                if(cost >= 300)
                {
                    cost = cost - 20;
                }
            }
            
            return cost;
        }
    }
    
    //满300送礼物
    public class FullAndPresent : IDiscountStrategy
    {
        public decimal CaculateCost(IList<decimal> products)
        {
            
            decimal cost = 0m;
            if(products != null)
            {   
                cost = products.Sum();
                if(cost >= 300)
                {
                    //赠送30的礼品
                    products.Add(30);
                }
            }
            
            return cost;
        }
    }

    //全场9折优惠
    public class Discount : IDiscountStrategy
    {
        public decimal CaculateCost(IList<decimal> products)
        {
            decimal cost = 0m;
            if(products != null)
            {   
                cost = products.Sum();
                cost = cost * 0.9m;
            }
            
            return cost;
        }
    }

    public class SalesOrder
    {
        private readonly IDiscountStrategy _discountStrategy;
        private List<decimal> _products;
        public SalesOrder(IDiscountStrategy discountStrategy)
        {
            //后续用工厂方法处理销售策略对象,让它灵活的创建策略对象
            _discountStrategy = discountStrategy;
            _products = new List<decimal>();
        }

        public void AddProduct(decimal price)
        {
            _products.Add(price);
        }

        public decimal CaculateCost()
        {
            //创建了统一的策略方法,面向接口编程
            return _discountStrategy.CaculateCost(_products);
        }
    }

    public class Program
    {
        public void Main()
        {
            //根据实际情况选择了一种打折的促销方法
            SalesOrder salesOrder = new SalesOrder(new FullAndSubstract());
            salesOrder.AddProduct(95);
            salesOrder.AddProduct(115);
            salesOrder.AddProduct(100);

            var cost = salesOrder.CaculateCost();
            
            System.Console.WriteLine($"实际需要支付金额{cost}");  
        }
    }
}