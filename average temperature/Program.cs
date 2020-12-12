using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average_temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите максимальную температуру за сегодня");
            int maxT = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите минимальную температуру за сегодня");
            int minT = Convert.ToInt32(Console.ReadLine());
            var aveT = (maxT + minT)/2;
            Console.WriteLine($"средняя температура сегодня {aveT}");
        }
    }
}
