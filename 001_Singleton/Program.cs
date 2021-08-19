using System;

namespace _001_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            //Singleton 模式要求一个类有且仅有一个实例，并且提供了一个全局的访问点。


            //功能：实现多线程计数器的客户端
            SigletonPattern.CountMutilThread cmt = new SigletonPattern.CountMutilThread();
            cmt.StartMain();
            Console.ReadLine();

            //            总结
            //            Singleton 设计模式是一个非常有用的机制，可用于在面向对象的应用程序中提供单个访问点。文中通过五种实现方式的比
            //较和一个完整的示例，完成了对 Singleton 模式的一个总结和探索。用一句广告词来概括 Singleton 模式就是“简约而不简
            //单”。
            //工厂方法模式（Factory Method
        }
    }
}
