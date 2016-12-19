using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            double dist, time;
            double speed;
            Console.WriteLine("Enter the distance travelled in km");
            dist = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the time taken to travel in hrs");
            time = Convert.ToDouble(Console.ReadLine());
            speed = dist / time;
            Console.WriteLine("The speed with which it is travelled {0} km/hr", speed);
            Console.ReadLine();
        }
    }
}
