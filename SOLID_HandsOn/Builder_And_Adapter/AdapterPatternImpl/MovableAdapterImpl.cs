using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternImpl
{
    public class MovableAdapterImpl : IMovableAdapter
    {
        private IMovable _luxaryCar;

        public MovableAdapterImpl(IMovable luxaryCar)
        {
            _luxaryCar = luxaryCar;
        }

        public double GetPrice()
        {
            return ConvertUSDToEuro(_luxaryCar.GetPrice());
        }

        public double GetSpeed()
        {
            return ConvertMPHtoKPH(_luxaryCar.GetSpeed());
        }

        private double ConvertMPHtoKPH(double mph)
        {
            return mph * 1.60934;
        }

        private double ConvertUSDToEuro(double usd)
        {
            return usd * 1.19;
        }
    }
}