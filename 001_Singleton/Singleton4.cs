using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Singleton
{
    /// <summary>
    /// 4．静态初始化
    /// </summary>
    public sealed class Singleton4
    {
        static readonly Singleton4 instance = new Singleton4();
        static Singleton4() { }
        Singleton4() { }

        public static Singleton4 Instance
        {
            get
            {

                return instance;
            }
        }

        //        看到上面这段富有戏剧性的代码，我们可能会产生怀疑，这还是 Singleton 模式吗？在此实现中，将在第一次引用类的任何
        //成员时创建实例。公共语言运行库负责处理变量初始化。该类标记为 sealed 以阻止发生派生，而派生可能会增加实例。此
        //外，变量标记为 readonly，这意味着只能在静态初始化期间（此处显示的示例）或在类构造函数中分配变量。
        //该实现与前面的示例类似，不同之处在于它依赖公共语言运行库来初始化变量。它仍然可以用来解决 Singleton 模式试图
        //解决的两个基本问题：全局访问和实例化控制。公共静态属性为访问实例提供了一个全局访问点。此外，由于构造函数是私
        //有的，因此不能在类本身以外实例化 Singleton 类；因此，变量引用的是可以在系统中存在的唯一的实例。
        //由于 Singleton 实例被私有静态成员变量引用，因此在类首次被对 Instance 属性的调用所引用之前，不会发生实例化。
        //这种方法唯一的潜在缺点是，您对实例化机制的控制权较少。在 Design Patterns 形式中，您能够在实例化之前使用非
        //默认的构造函数或执行其他任务。由于在此解决方案中由.NET Framework 负责执行初始化，因此您没有这些选项。在
        //大多数情况下，静态初始化是在.NET 中实现 Singleton 的首选方法
    }
}
