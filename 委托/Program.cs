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
        //public delegate void MyDelegate(int num);

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

        }


        public static void show()
        {
            Console.WriteLine("执行方法");
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
