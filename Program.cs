using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { -102, 114, 18987, 9,100 };

            ArraySort(mas, SortAlgorithmType.Insertion, OrderBy.Asc);
            Console.WriteLine(String.Join(" ",mas));

        }

        static void ArraySort<T>(T [] mas,SortAlgorithmType sat,OrderBy ob) where T:IComparable 
        {
            int length = mas.Length;
      
            int CompareToMy(T x1,T x2) {
                switch (ob)
            {
                case OrderBy.Asc:
                        return x1.CompareTo(x2);
                    break;
                case OrderBy.Deasc:
                        return -x1.CompareTo(x2);
                        break;
            }
                return 0;
            
            }


            

            switch (sat)
            {
                case SortAlgorithmType.Selection:
   for (int i = 0; i < length; i++)
                    {
                        for (int j = i+1; j < length; j++)
                        {
                            if (CompareToMy(mas[i], mas[j]) > 0)
                                Swap(ref mas[i], ref mas[j]);
                           

                        }
                    }

                    break;
                case SortAlgorithmType.Bubble:

                    for (int i = 0; i < length; i++)
                    {
                        for (int j = 0; j < length-i-1; j++)
                        {
                            if (CompareToMy(mas[j], mas[j+1]) > 0)
                                Swap(ref mas[j], ref mas[j+1]);
                        }
                    }

                    break;
                case SortAlgorithmType.Insertion:

                    for (int i = 1; i < length; ++i)
                    {
                        T temp = mas[i];
                        int j = i-1;
                        while (j >= 0 && CompareToMy(mas[j], temp) > 0) {
                            mas[j + 1] = mas[j]; 
                            j--;
                        }
                        mas[j + 1] = temp; 
                    }
                    break;
            }


        }

        static  void   Swap <T>   (ref T x1, ref T x2) {
        T temp = x1;
        x1 = x2;
        x2 = temp;
    }
    enum SortAlgorithmType {
        Selection, Bubble, Insertion
    }
    enum OrderBy {
        Asc, Deasc
    }

    }

}