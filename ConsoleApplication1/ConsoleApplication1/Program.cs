using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            //定义一个变数
            int n = int.Parse(Console.ReadLine());

            //在屏幕上打一个数
            int a = 0;

            // 设立初始值
            while (a < n)
            {
                a += 1;
                int r1 = rand.Next(1, 43);
                int r2 = rand.Next(1, 43);
                int r3 = rand.Next(1, 43);
                int r4 = rand.Next(1, 43);
                int r5 = rand.Next(1, 43);
                int r6 = rand.Next(1, 43);
                Console.WriteLine("{0:0} {1:0} {2:0} {3:0} {4:0} {5:0}", r1, r2, r3, r4, r5, r6);
            }



            //回圈及输出
            Console.ReadLine();

            //停止

        }
    }
}
