using System;

namespace myfirst
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int len = args.Length;
            test t1 = new test();
            for (int i=0; i<len; i++){
                t1.sayhello(args[i]);
            }
            
           
        }
    }
}
