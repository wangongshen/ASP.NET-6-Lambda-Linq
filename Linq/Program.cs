using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        /// <summary>
        ///LINQ与SQL区别
        ///1：linq比sql简单
        ///2：linq可以很好的防治sql注入
        ///3：linq是面向对象的查询，主要在程序内部使用；sql是面向关系型数据库查询
        ///4：从运行效率上来说sql比linq高
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 5, 9, 3 };
            var numberQuery = from num in numbers where num > 5 select num*2;
            foreach (var item in numberQuery) {
                Console.WriteLine(item);
            }

            //Form子句
            string[] values = { "中国", "日本", "塔利班", "英国", "韩国", "美国", "墨西哥" };
            var valQur = from val in values where val.IndexOf("国") > 0 select val;
            foreach (var item in valQur)
            {
                Console.WriteLine(item);
            }
            fromExpDemo();

        }

        static void fromExpDemo()
        {
            List<CustomerInfo> customerInfos = new List<CustomerInfo>();
            customerInfos.Add(new CustomerInfo { Name = "qqqqq", Age = 35, TelTable = new List<string> { "111111", "5435432432" } });
            customerInfos.Add(new CustomerInfo { Name = "wwwww", Age = 36, TelTable = new List<string> { "323232132", "5435432432" } });
            customerInfos.Add(new CustomerInfo { Name = "eeeee", Age = 37, TelTable = new List<string> { "111111", "5435432432" } });
            var query = from CustomerInfo ci in customerInfos
                        from tel in ci.TelTable 
                        where tel.IndexOf("111111") > -1
                        select ci;
            Console.WriteLine("11111111");
            foreach (var item in query)
            {
                Console.WriteLine("xm:"+item.Name);
                foreach (var tel in item.TelTable)
                {
                    Console.WriteLine("tel:"+tel);
                }
            }
        }
    }
}
