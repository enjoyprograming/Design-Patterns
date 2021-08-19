using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Singleton
{
    /// <summary>
    ///  单例模式（常规用法，线程安全）
    /// </summary>
    public class Singleton2
    {
        /// <summary>
        /// 私有构造函数
        /// </summary>
        private Singleton2()
        {

        }
        /// <summary>
        /// 静态局部变量
        /// </summary>
        private static Singleton2 _instance = null;
        /// <summary>
        /// 声明锁 锁同步
        /// </summary>
        private static readonly object _lock = new object();

        /// <summary>
        /// 静态的全局唯一访问口
        /// 只能得到缓存的静态局部变量实例，无法重新新建
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Singleton2 GetInstance(string value)
        {
            if (_instance==null)//双重判空，确保在多线程状态下只创建一个实例对象
            {
                lock (_lock)//加锁，确保其每次只能由一个对象进行访问
                {
                    if (_instance==null)
                    {
                        _instance = new Singleton2();
                        _instance.Value = value;
                    }
                }
            }
            return _instance;
        }

        public string Value { get; set; }

        //懒汉模式二（线程安全）
    }
}
