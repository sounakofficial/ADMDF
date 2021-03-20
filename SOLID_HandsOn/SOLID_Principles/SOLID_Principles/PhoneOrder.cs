
using System;

namespace SOLID_Principles
{
    public class PhoneOrder : IOrder
    {
        public void ProcessOrder(string modelName)
        {
           Console.WriteLine(string.Format("{0} order accepted!", modelName));

        }
    }
}