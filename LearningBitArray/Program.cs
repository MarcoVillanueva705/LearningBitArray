using System;
using System.Collections;

namespace LearningBitArray
{
    class Program
    {
        static void Main(string[] args)

        {
            //pass the array constructor to the BitArray

            bool[] preload = new bool[3] { true, false, true };

            //BitArray will need to know size initialize with, so pass (3)
            //to the constructor
            //BitArray enemyGrid = new BitArray(3);

            BitArray enemyGrid = new BitArray(preload);

            foreach (var item in enemyGrid)
            {
                Console.WriteLine(item);
            }

        }
    }
}
