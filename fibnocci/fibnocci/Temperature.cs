using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibnocci
{
    internal class Temperature
    {
    public void celsius()
        {
            double fahrenheit = 0.00;
            
            double celsius = ((fahrenheit * 9/5)+32);
            Console.WriteLine("\n Entered value for celsius");
            Console.ReadLine();
            Console.WriteLine("Celsius: " + celsius);
            Console.WriteLine("\n Entered value for fahrenheit");
            Console.ReadLine();
            fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit);

            Console.ReadLine();
        }
    }
}
