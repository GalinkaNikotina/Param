using System;

namespace Param
{
    class Program
    {
        public class AClass1<T>
        {
            private T[] imyArray = new T[20];
        }
        public class M
        {
            static void Main(string[] args)
            {
                AClass1<string> K = new AClass1<string>();
                AClass1<int> K2 = new AClass1<int>();
            }
        }
    }
}
  