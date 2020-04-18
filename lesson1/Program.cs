using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            int i = 0;
            i++;
            Console.WriteLine("请输入您的名字：");

            string name1 = Console.ReadLine();
            Console.WriteLine("再输入一个名字");
            string name2 = Console.ReadLine();
            Console.WriteLine("{0}你好,{1}你好",name1,name2);
            Console.ReadKey();
;
        }
    }
}
