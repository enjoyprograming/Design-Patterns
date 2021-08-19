using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Singleton
{
    /// <summary>
    /// 2.安全的线程
    /// </summary>
    public sealed class Singleton2
    {
        static Singleton2 instance = null;
        static readonly object padlock = new object();
        Singleton2()
        {

        }

        public static Singleton2 Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton2();
                    }
                    return instance;
                }
            }
        }
        //这种方式的实现对于线程来说是安全的。我们首先创建了一个进程辅助对象，线程在进入时先对辅助对象加锁然后再检测对
        //象是否被创建，这样可以确保只有一个实例被创建，因为在同一个时刻加了锁的那部分程序只有一个线程可以进入。这种情
        //况下，对象实例由最先进入的那个线程创建，后来的线程在进入时（instence == null）为假，不会再去创建对象实例了。
        //但是这种实现方式增加了额外的开销，损失了性能

    }
}
