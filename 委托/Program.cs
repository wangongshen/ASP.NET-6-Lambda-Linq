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
            //Fun<T> 声明泛型委托 肯定有返回值 参数可有
            Func<int> Func1 = FuncM1;
            int a = FuncM1();
            Console.WriteLine("aaa:"+a);
            Func<int, int, int, int> Func2=FuncM2;
            int b = FuncM2(1,2,3);
            Console.WriteLine("bbb:"+b);
            Console.WriteLine("-------------多播委托，能绑定多个方法-----无返回值-------------------------------");
            Action action3 = M3;
            action3 += M4;
            action3();
            Console.WriteLine("-------------多播委托，能绑定多个方法-----有返回值-------------------------------");
            Func<int, int, int, int> Func3 = FuncM2;
            Func3 += FuncM3;
            Delegate[] c = Func3.GetInvocationList();
            for (int i = 0; i < c.Length; i++)
            {
                int ss = (c[i] as Func<int,int,int,int>)(1,2,3);
                Console.WriteLine("ccc:" + ss);
            }

        }

        static void M3()
        {
            Console.WriteLine("M3----");
        }
        static void M4()
        {
            Console.WriteLine("M4---");
        }
         static int FuncM1()
        {
            return 1;
        }

        static int FuncM2(int n1,int n2,int n3)
        {
            Console.WriteLine("M2");
            return n1 + n2 + n3;
        }
        static int FuncM3(int n1, int n2, int n3)
        {
            Console.WriteLine("M3");
            return n1 - n2 - n3;
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
