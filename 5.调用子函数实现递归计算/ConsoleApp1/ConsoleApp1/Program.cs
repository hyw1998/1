using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {/*递归调用计算阶乘*/
        public int factorial(int num)
        {
            int result;

            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = factorial(num - 1) * num;
                return result;
            }
        }
        static void Main(string[] args)
        {
            Program n = new Program();
            Console.WriteLine("请输入X的值：");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X的阶乘值为{0}", n.factorial(a));
            Console.ReadKey();
        }
     }
}
