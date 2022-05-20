using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLogit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("КА - тип сосудистого поражения коронарных артерий по данным коронароангиографии");
            Console.WriteLine("1 - двухсосудистое, трехсосудистое поражение коронарных артерий");
            Console.WriteLine("0 - однососудистое поражение коронарных артерий и отсутствие");
            Console.WriteLine("Введите 0 или 1 для КА: ");
            string KAnum = Console.ReadLine();
            int KA = Convert.ToInt32(KAnum);
            Console.WriteLine("НП - неконтролируемый прием ИПП и НПВП");
            Console.WriteLine("1 - да");
            Console.WriteLine("0 - нет");
            Console.WriteLine("Введите 0 или 1 для НП: ");
            string NPnum = Console.ReadLine();
            int NP = Convert.ToInt32(NPnum);
            Console.WriteLine("ДС - процент стенозирования брахиоцефальных артерий по данным дуплексного сканирования");
            Console.WriteLine("1 - стенозирование брахиоцефальных артерий более 20%");
            Console.WriteLine("0 - стенозирование брахиоцефальных артерий менее 20%");
            Console.WriteLine("Введите 0 или 1 для ДС: ");
            string DSnum = Console.ReadLine();
            int DS = Convert.ToInt32(DSnum);
            Console.WriteLine("ХБ - инфицированность H. pylori");
            Console.WriteLine("1 - да");
            Console.WriteLine("0 - нет");
            Console.WriteLine("Введите 0 или 1 для ХБ: ");
            string HBnum = Console.ReadLine();
            int HB = Convert.ToInt32(HBnum);

            double z = -10.47 + (2.15 * KA) + (5.35 * NP) + (2.08 * DS) + (3.82 * HB); // результат z

            double E = 2.7;

            double ez = Math.Pow(E, z); // возведение в степень (z)

            double y = ez / (1 + ez);

            double result_y = y * 100;

            int s = 2; // округление

            double result_y1 = Math.Round(result_y, s); // результат y

            Console.WriteLine("Z=" + Math.Round(z, s));// вывод 
            Console.WriteLine("Y=" + result_y1);// вывод 
            Console.ReadKey();
        }
    }
}
