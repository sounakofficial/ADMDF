namespace AbstractFactoryImpl
{
    public class Client
    {
        private Order _order;

        public Client(ChannelFactory factory, ProductType productType)
        {
            if (productType == ProductType.Electronic_Products)
            {
                _order = factory.CreateElectronicOrder();
            }
            else if (productType == ProductType.Furniture)
            {
                _order = factory.CreateFurnitureOrder();
            }
            else if (productType == ProductType.Toys)
            {
                _order = factory.CreateToysOrder();
            }

            _order.productType = productType;

            if (factory is ECommerceFactory)
            {
                _order.channel = Channel.E_commerce_website;
            }
            else if (factory is TeleCallerFactory)
            {
                _order.channel = Channel.Tele_caller_Agents_Application;
            }
        }

        public Order GetOrder()
        {
            return _order;
        }
    }
}