using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Singleton
{
    /// <summary>
    /// 5.延迟初始化
    /// </summary>
    public sealed class Singleton5
    {
        Singleton5() { }
        public static Singleton5 Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        class Nested
        {
            static Nested() { }
            internal static readonly Singleton5 instance = new Singleton5();
        }


        //        这里，初始化工作有 Nested 类的一个静态成员来完成，这样就实现了延迟初始化，并具有很多的优势，是值得推荐的一种
        //实现方式。

        //        实现要点
        //Singleton 模式是限制而不是改进类的创建。
        //Singleton 类中的实例构造器可以设置为 Protected 以允许子类派生。
        //Singleton 模式一般不要支持 Icloneable 接口，因为这可能导致多个对象实例，与 Singleton 模式的初衷违背。
        //Singleton 模式一般不要支持序列化，这也有可能导致多个对象实例，这也与 Singleton 模式的初衷违背。
        //Singleton 只考虑了对象创建的管理，没有考虑到销毁的管理，就支持垃圾回收的平台和对象的开销来讲，我们一般没必要对其销
        //毁进行特殊的管理。
        //理解和扩展 Singleton 模式的核心是“如何控制用户使用 new 对一个类的构造器的任意调用”。
        //可以很简单的修改一个 Singleton，使它有少数几个实例，这样做是允许的而且是有意义的。

        //            优点
        //实例控制：Singleton 会阻止其他对象实例化其自己的 Singleton 对象的副本，从而确保所有对象都访问唯一实例
        //灵活性：因为类控制了实例化过程，所以类可以更加灵活修改实例化过程
        //缺点
        //开销：虽然数量很少，但如果每次对象请求引用时都要检查是否存在类的实例，将仍然需要一些开销。可以通过使用静态初始化
        //解决此问题，上面的五种实现方式中已经说过了。
        //可能的开发混淆：使用 singleton 对象（尤其在类库中定义的对象）时，开发人员必须记住自己不能使用 new 关键字实例化对象。因为可
        //能无法访问库源代码，因此应用程序开发人员可能会意外发现自己无法直接实例化此类。
        //对象的生存期：Singleton 不能解决删除单个对象的问题。在提供内存管理的语言中（例如基于.NET Framework 的语言），只有
        //Singleton 类能够导致实例被取消分配，因为它包含对该实例的私有引用。在某些语言中（如 C++），其他类可以删除
        //对象实例，但这样会导致 Singleton 类中出现悬浮引用。
        //适用性
        //当类只能有一个实例而且客户可以从一个众所周知的访问点访问它时。
        //当这个唯一实例应该是通过子类化可扩展的，并且客户应该无需更改代码就能使用一个扩展的实例时。
    }
}
