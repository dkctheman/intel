using System;
using System.Collections.Generic;
using System.Text;

namespace btree
{
    class random
    {

        public int[] randNum (int len, int min, int max)
        {

            Random r = new Random();
            int[] array = new int[len];

            for(int i=0; i<len; i++)
            {
                array[i] = r.Next(min, max);
            }

            return array;
        }

    }
}
