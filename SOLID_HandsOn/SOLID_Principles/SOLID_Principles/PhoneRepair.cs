using System;

namespace SOLID_Principles
{
    public class PhoneRepair : IPhoneRepair
    {
        public void ProcessPhoneRepair(string modelName)
        {
             Console.WriteLine(string.Format("{0} repair accepted!", modelName));
        }
    }
}