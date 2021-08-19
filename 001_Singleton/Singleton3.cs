using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Singleton
{
    /// <summary>
    /// 3.双重锁定
    /// </summary>
    public sealed class Singleton3
    {
        static Singleton3 instance = null;
        static readonly object padlock = null;
        Singleton3()
        {

        }
        public static Singleton3 Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton3();
                        }
                    }
                }
                return instance;
            }
        }


        //这种实现方式对多线程来说是安全的，同时线程不是每次都加锁，只有判断对象实例没有被创建时它才加锁，有了我们上面
        //第一部分的里面的分析，我们知道，加锁后还得再进行对象是否已被创建的判断。它解决了线程并发问题，同时避免在每个
        //Instance 属性方法的调用中都出现独占锁定。它还允许您将实例化延迟到第一次访问对象时发生。实际上，应用程序很少
        //需要这种类型的实现。大多数情况下我们会用静态初始化。这种方式仍然有很多缺点：无法实现延迟初始化。
    }
}
