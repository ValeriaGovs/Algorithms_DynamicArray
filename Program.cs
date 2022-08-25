using System;
using System.Collections;
using System.Diagnostics;

namespace Algorithms_DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Console.WriteLine("SingleArray ");
            IArray<int> single = new SingleArray<int>();
            testPut(single, 1_000);
            testPut(single, 10_000);
            testPut(single, 100_000);
            Console.WriteLine("_____________");
            Console.WriteLine("");


            Console.WriteLine("VectorArray ");
            IArray<int> vector = new VectorArray<int>(100);

            testPut(vector, 1_000);
            testPut(vector, 10_000);
            testPut(vector, 100_000);
            Console.WriteLine("_____________");
            Console.WriteLine("");


            IArray<int> factor = new FactorArray<int>();
            Console.WriteLine("FactorArray ");
            testPut(factor, 1_000);
            testPut(factor, 10_000);
            testPut(factor, 100_000);
            Console.WriteLine("_____________");
            Console.WriteLine("");

            /*
                        IArray<int> matrix = new MatrixArray<int>();

                        testPut(matrix, 1_000);
                        testPut(matrix, 10_000);
                        testPut(matrix, 100_000);
                        testPut(matrix, 1_000_000);
            */

            ArrayList list = new ArrayList();
            Console.WriteLine("ArrayList ");
            testPut_list(list,1000);
            testPut_list(list, 10_000);
            testPut_list(list, 100_000);
            Console.WriteLine("_____________");
            Console.WriteLine("");


        }


        private static void testPut(IArray<int> array, int total)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i=0; i< total; i++)
            {
                array.add(i,0);
            }

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime - добавление по индексу {0} {1} {2} ", array, total, elapsedTime);


            for (int i = 0; i < total; i++)
            {
                array.delete(0, 0);
            }

            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime - удаление по индексу {0} {1} {2} ", array, total, elapsedTime);
        }


        private static void testPut_list(ArrayList array, int total)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < total; i++)
            {
                array.Insert(0,i);
            }

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime - добавление по индексу {0} {1} {2} ", array, total, elapsedTime);


            for (int i = 0; i < total; i++)
            {
                array.RemoveAt( 0);
            }

            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime - удаление по индексу {0} {1} {2} ", array, total, elapsedTime);
        }
    }
}
