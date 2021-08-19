using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Singleton
{
    /// <summary>
    /// 使用静态变量实现单例 ------饿汉模式（线程安全）
    /// </summary>
    public class Singleton3
    {
        /// <summary>
        /// 饿汉式，也就是在程序运行时都已经进行了初始化操作，后续只是调用而已。
        /// </summary>
        private static Singleton3 instance = new Singleton3();

        private Singleton3()
        {

        }

        public static Singleton3 GetInstance()
        {
            return instance;
        }

        //饿汉式顾名思义就是提前都恶的不行了，在程序刚开始启动的时候就已经将其进行了实例化，后续只管调用。
        //这种不是懒加载，无论程序是否会用到这个类，它都会提早的进行实例化。
    }
}
