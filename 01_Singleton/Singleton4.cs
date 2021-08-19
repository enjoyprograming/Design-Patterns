using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Singleton
{
    /// <summary>
    /// 利用静态构造函数实现单例模式（线程安全）
    /// </summary>
    public class Singleton4
    {
        private static Singleton4 _Singleton4 = null;
        static Singleton4() {
            _Singleton4 = new Singleton4();
        }

        public static Singleton4 CreateInstance()
        {
            return _Singleton4;
        }

        //单例模式常用的就大体介绍完了，我们在平时的使用过程中需要根据不同的业务逻辑来选择不同的实现方式，不能说哪一种最好，也不能说哪一种不好，只是它们使用的场景不同而已。
    }
}
