using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manhlole_Assignment
{
    class Program
    {

        static void Main(string[] args)
        {
            int rows=4, col=4, count = 0, columnCount = 0;
            int rowCount = 0;
            //Two dimentional array
            int[,] a = new int[rows, col];

            int size = a.Length;
            //single dimentional array
            int[] b = new int[size];

            //converting two dimetional to single dimentional array
            Console.WriteLine("enter the elements");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                    b[count++] = a[i, j];
                }
            }
           //Count the Number of once in the in column wise
            Console.WriteLine("The array elements = ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    //column count of the given data
                    if (a[i,j] == 1)
                    {
                        ++columnCount;
                    }
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
            //count the number of once present in the RowWise 

            for (int k = 0; k < b.GetUpperBound(0); k++)
            {
                if (b[k] == 1 && b[k + 1] == 1)
                {
                    ++rowCount; //5
                }
            }
            Console.WriteLine(columnCount);
            Console.WriteLine(rowCount);
            //finding the difference columnCount-rowCount gives the minium no of potholes
            Console.WriteLine("Minimum count is " +(columnCount-rowCount));
            Console.ReadLine();
        }
    }
}

/*
 * 1
0
1
0
0
1
1
1
1
1
1
0
1
0
1
0*/

