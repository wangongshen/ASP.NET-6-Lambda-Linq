using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 匿名方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //匿名类
            var Test = new { Name="支付",Age=21};
            Console.WriteLine("我的名字是{0}，{1}岁", Test.Name, Test.Age);
            //匿名方法（无返回值无参数）
            Action M1 = delegate ()
            {
                Console.WriteLine("无返回值无参数");
            };
            M1();
            //匿名方法（有参数无返回值）
            Action<string> M2 = delegate (string str)
            {
                Console.WriteLine("有参数，无返回值："+str);
            };
            M2("123");
            //匿名方法（有参数，有返回值）
            Func<string, int, string> M3 = delegate (string  n1,int n2) {
                Console.WriteLine("================");
                return n1+n2;
            };
            string str3=M3("qqq",21);
            Console.WriteLine(str3);
        }  
    }
}
