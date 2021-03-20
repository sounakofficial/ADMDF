using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryImpl
{
    public abstract class Order
    {
        public Channel channel { get; set; }
        public ProductType productType { get; set; }

        public abstract void ProcessOrder();
    }
}