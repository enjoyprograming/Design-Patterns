using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _001_Singleton.SigletonCounter
{
    public class CountSigleton
    {
        static CountSigleton uniCounter = new CountSigleton();
        private int totNum = 0;
        private CountSigleton() {
            Thread.Sleep(2000);
        }

        static public CountSigleton Instance() {
            return uniCounter;
        }

        public void Add() {
            totNum++;
        }

        public int GetCounter() {
            return totNum;
        }


    }

}
