namespace AbstractFactoryImpl
{
    public abstract class ChannelFactory
    {
        public abstract Order CreateElectronicOrder();

        public abstract Order CreateFurnitureOrder();

        public abstract Order CreateToysOrder();
    }
}