using _001_Singleton.SigletonCounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _001_Singleton.SigletonPattern
{
    public class CountMutilThread
    {
        public CountMutilThread() { }


        public static void DoSomeWork() {
            string results = "";
            CountSigleton MyCounter = CountSigleton.Instance();
            for (int i = 0; i < 5; i++)
            {
                MyCounter.Add();
            }

            results += "线程";
            results += Thread.CurrentThread.Name.ToString() + "--）";
            results += "当前的计数：";
            results += MyCounter.GetCounter().ToString();
            results += "\n";
            Console.WriteLine(results);

            results = "";
        }

        public void StartMain() {
            Thread thread0 = Thread.CurrentThread;
            thread0.Name = "Thread 0";
            Thread thread1 = new Thread(new ThreadStart(DoSomeWork));

            thread1.Name = "Thread 1";

            Thread thread2 = new Thread(new ThreadStart(DoSomeWork));
            thread2.Name = "Thread 2";

            Thread thread3 = new Thread(new ThreadStart(DoSomeWork));
            thread3.Name = "Thread 3";

            thread1.Start();
            thread2.Start();
            thread3.Start();

            DoSomeWork();
        }
    }
}
