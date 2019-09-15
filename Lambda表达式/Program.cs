using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda表达式
{
    class Program
    {
        //Lambda表达式就是一个匿名函数

        static void Main(string[] args)
        {
            //无参数、表达式
            Action a = () => {
                Console.WriteLine("aaaaaaa");
            };
            a();
            //1个参数
            Action<int> b = m => {
                int n = m * 2;
                Console.WriteLine(n);
            };
            b(3);
            //1个参数有返回值
            Func<int, int> c = m => {
                int n = m + 1;
                return n;
            };
            int q=c(5);
            Console.WriteLine(q);
            //多个参数，有返回值
            Func<int, int, int> d = (m,n) => {
                return m+n;
            };

            int t = d(2,4);
            Console.WriteLine(t);
        }
    }
}
