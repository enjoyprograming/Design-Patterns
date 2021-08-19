using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Singleton
{
    /// <summary>
    /// 单例模式（常规用法，线程不安全）
    /// </summary>
    public class Singleton1
    {
        /// <summary>
        /// 私有构造函数
        /// </summary>
        private Singleton1()
        {

        }
        /// <summary>
        /// 静态局部变量
        /// </summary>
        private static Singleton1 _instance = null;

        /// <summary>
        /// 静态的全局唯一访问扣
        /// 只能得到缓存的静态局部变量实例，无法重新新建
        /// </summary>
        /// <returns></returns>
        public static Singleton1 GetInstance() 
        {
            if (_instance==null)
            {
                _instance = new Singleton1();
            }
            return _instance;
        
        }

        //懒汉模式一(线程不安全)
        //此方法满足了懒加载，但是如果多个访问者同时进行访问获取对象，就会出现多个实例对象，就不是单例模式了，
        //所以此方法在多线程场景是不实用的。
    }
}
