﻿namespace AbstractFactoryImpl
{
    public class TeleCallerFactory : ChannelFactory
    {
        public override Order CreateElectronicOrder()
        {
            return new ElectronicOrder();
        }

        public override Order CreateFurnitureOrder()
        {
            return new FurnitureOrder();
        }

        public override Order CreateToysOrder()
        {
            return new ToysOrder();
        }
    }
}