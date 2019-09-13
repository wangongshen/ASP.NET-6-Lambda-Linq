using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    class Program
    {
        /// <summary>
        /// 委托：委托是一个数据类型，可以接受方法，通过委托可以将方法像参数一样传递；
        /// </summary>

        //声明无参委托
        public delegate void MyDelegate();
        //声明有参委托
        public delegate void MyDelegate01(int Num);
        public delegate void MyDelegate02(string str);
        public delegate void MyDelegate03<T>(T del);


        static void Main(string[] args)
        {
            MyDelegate md = show;
            Console.WriteLine("-------------直接执行--------------");
            Console.WriteLine("123456");
            md();//调用委托
            md.Invoke(); //调用委托
            Console.WriteLine("654321");
            Console.WriteLine("------------将委托用参数方式传递---------------");
            DelegateCC(md);
            Console.WriteLine("------------Action委托（非泛型）-----------------------------");
            Action action = show;
            action();
            Console.WriteLine("------------Action委托（泛型）--有参数无返回值---------------------------");
            Action<string> action1 = show; //不用声明直接能用
            Action<int> action2 = show;
            action1("string");
            action2(123); 
            Console.WriteLine("------------Func委托（泛型）----------------------------");


        }


        public static void show()
        {
            Console.WriteLine("执行方法");
        }

        public static void show(string str)
        {
            Console.WriteLine("执行方法:"+str);
        }

        public static void show(int num)
        {
            Console.WriteLine("执行方法:"+num);
        }
        public static void show(bool bl)
        {
            Console.WriteLine("执行方法:" + bl);
        }
        public static void DelegateCC(MyDelegate delagate)
        {
            Console.WriteLine("1111111111");
            if (delagate!=null)//委托是一个对象，有可能为空
            {
                delagate();
            }
            Console.WriteLine("3333333333");
        }
    }
}
