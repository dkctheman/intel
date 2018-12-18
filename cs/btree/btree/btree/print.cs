using System;
using System.Collections.Generic;
using System.Text;

namespace btree
{
    class print
    {
        //command line input printing function
        public void printCmdline(string[] args)
        {
            int len = args.Length;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(args[i]);
            }
        }

        public void printNum(int[] array)
        {
            int len = array.Length;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
