using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public int calcul(int x)
        {
            if (x < 0)           return x + 3;
            else if (x >= 3)     return 6 - x;
            else                 return 5 - 2 * x * x;
        }
        static void Main(string[] args)
        {
            Program n = new Program();
            Console.WriteLine("请输入X的值：");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("所得Y的值为{0}", n.calcul(a));
                Console.ReadKey();
         }

    }
 }
