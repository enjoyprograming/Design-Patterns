using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Singleton
{
    /// <summary>
    /// 1.简单实现
    /// </summary>
    public sealed class Singleton1
    {
        static Singleton1 instance = null;
        Singleton1()
        {

        }
        public static Singleton1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton1();
                }
                return instance;
            }
        }
        //这种方式的实现对于线程来说并不是安全的，因为在多线程的环境下有可能得到 Singleton 类的多个实例


        //该实现方式主要有两个优点：
        //由于实例是在 Instance 属性方法内部创建的，因此类可以使用附加功能（例如，对子类进行实例化），即使它可能引入不想要
        //的依赖性。
        //直到对象要求产生一个实例才执行实例化；这种方法称为“惰性实例化”。惰性实例化避免了在应用程序启动时实例化不必要的singleton
    }
}
