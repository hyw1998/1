using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入第一个整数：");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("输入运算符：");
            char str = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("输入第二个整数：");
            int b = Int32.Parse(Console.ReadLine());
            switch (str)
            {
                case '+':
                    Console.WriteLine("两个数和为：{0}", a + b);
                    break;
                case '-':
                    Console.WriteLine("两个数差为：{0}", a - b);
                    break;
                case '*':
                    Console.WriteLine("两个数积为：{0}", a * b);
                    break;
                case '/':
                    Console.WriteLine("两个数商为：{0}", a / b);
                    break;
                default:
                    Console.WriteLine("输入正确的运算符！！");
                    break;

            }
            Console.ReadKey();
        }
    }
}
