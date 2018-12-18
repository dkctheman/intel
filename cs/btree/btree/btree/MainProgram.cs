using System;

namespace btree
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            int[] array;                 
            print p = new print();
            random r = new random();

            int len = args.Length;

            if(len < 3)
            {
                Console.WriteLine("need to specify 3 numbers");
                return;
            }

         

            array = r.randNum(Int32.Parse(args[0]), Int32.Parse(args[1]), Int32.Parse(args[2]));

            p.printNum(array);

        
        }




       
    }
}
