using System;
using System.CodeDom;

namespace Enums
{
    public enum ShippingMethod
    {
        RegularAirMail =1,
        RegisteredAirMail = 2 ,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {   // convert from enum to int
            var method = ShippingMethod.Express;
            Console.WriteLine(method);
            Console.WriteLine((int)method);
            //convert from int to enum
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);
            
            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);
            Console.WriteLine(typeof(ShippingMethod));
        }
    }
}
