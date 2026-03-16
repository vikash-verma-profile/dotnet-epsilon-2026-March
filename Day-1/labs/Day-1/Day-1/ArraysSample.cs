using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    internal class ArraysSample
    {
        static void Main2(string[] args)
        {
            int[] arrayInts=new int[2];
            arrayInts[0]=1;
            arrayInts[1]=2;
            foreach (int i in arrayInts)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("==============Matrix===========");

            int[,]arraySample=new int[2,2];
            int counter = 1;
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    arraySample[row, col] = counter;
                    counter++;
                }
            }
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write($"{arraySample[row,col]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("==============Jagged===========");
            counter = 1;
            int[][] arrayList = new int[2][];

            for (int i = 0; i < 2; i++)
            {
                int[] dummyArray = new int[] { counter, counter+1, counter + 2};
                arrayList[i] = dummyArray;
                counter++;
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arrayList[i][j]+",");
                }
                Console.WriteLine();
            }
        }
    }
}
