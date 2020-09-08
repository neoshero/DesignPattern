using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace designpattern.Normal
{
    public enum  DiscountType
    {
        [Description("9折优惠")]
        Discount,

        [Description("满300减20")]
        FullAndSubtract
    }

    public class SalesOrder
    {
        private DiscountType _discountType;
        private List<decimal> _products;
        public SalesOrder(DiscountType discountType)
        {
            _discountType = discountType;
            _products = new List<decimal>();
        }
        
        //添加一个商品,为了简单设计,只添加价格
        public void AddProduct(decimal price)
        {
            _products.Add(price);
        }
         
        public decimal CaculateCost()
        {
            decimal cost = _products.Sum();

            if(_discountType == DiscountType.Discount)
            {
                cost = cost * 0.9m;
            }

            else if(_discountType == DiscountType.FullAndSubtract)
            {
                if(cost >= 300)
                {
                    cost = cost - 20;
                }
                
            }
           
            return cost;
        }
    }

    public class Program
    {
        void Main()
        {
            var salesOrder = new SalesOrder(DiscountType.Discount);
            salesOrder.AddProduct(90);
            salesOrder.AddProduct(100);
            salesOrder.AddProduct(120);

            var cost = salesOrder.CaculateCost();
            System.Console.WriteLine($"实际需要支付金额{cost}");  
        }
    }
    
}
