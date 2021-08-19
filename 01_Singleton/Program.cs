using System;
using System.Threading;

namespace _01_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("多线程进行访问");
            Thread processOne = new Thread(() =>
            {
                TestSingleton("张三");
            });
            Thread processTwo = new Thread(() =>
            {
                TestSingleton("李四");
            });
            processOne.Start();
            processTwo.Start();

            processOne.Join();
            processTwo.Join();

            Console.ReadKey();

            //可以看到在我们模拟的多线程访问过程中，即使设置的阿辉和阿七，最后输出的也只有阿辉，也就是说只能创建一个实例对象。
            //可以看到懒加载就是程序刚开始不实例化，只有在被调用或者需要使用它的时候才进行实例化操作，这就是懒加载。


            //https://www.cnblogs.com/netxiaohui/p/15145605.html


        }

        static void TestSingleton(string value)
        {
            Singleton2 s = Singleton2.GetInstance(value);
            Console.WriteLine(s.Value);
        }
    }
}
