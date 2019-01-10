using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arraya = new[] { 8, 7, -1, 4 };
            int[] arrayb = new[] { 3, 10, };
            Console.WriteLine(comparearrays(ref arraya, ref arrayb));

            Random r = new Random();
            int size = int.Parse(Console.ReadLine());
            arraya = new int[size];
            arrayb = new int[size];
            for (int i = 0; i < size; i++)
            {
                arraya[i] = r.Next(5);
                arrayb[i] = r.Next(5);
            }

            for (int i = 0; i < arraya.Length; i++)
            {
                Console.Write(arraya[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < arrayb.Length; i++)
            {
                Console.Write(arrayb[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine(comparearrays(ref arraya, ref arrayb));


        }

        private static int comparearrays(ref int[] arraya, ref int[] arrayb)
        {
            int countera = 0;
            int counterb = 0;
            int counter = 0;
            if (arraya.Length > arrayb.Length)
            {
                for (int i = 0; i < arrayb.Length; i++)
                {
                    if (arraya[i] > arrayb[i])
                    {
                        countera++;
                    }
                    else if (arraya[i] < arrayb[i])
                    {
                        counterb++;
                    }
                    else if(arraya[i] == arrayb[i])
                    {
                        countera++;
                        counterb++;
                    }
                }

                if(countera>counterb)
                {
                    counter= 1;
                }
                else if(counterb==countera)
                {
                    counter = 0;
                }
                else if(countera<counterb)
                {
                    counter = -1;
                }
            }
            if (arraya.Length < arrayb.Length)
            {
                for (int i = 0; i < arraya.Length; i++)
                {
                    if (arraya[i] > arrayb[i])
                    {
                        countera++;
                    }
                    else if (arraya[i] < arrayb[i])
                    {
                        counterb++;
                    }
                    else if (arraya[i] == arrayb[i])
                    {
                        countera++;
                        counterb++;
                    }
                }

                if (countera > counterb)
                {
                    counter = 1;
                }
                else if (counterb == countera)
                {
                    counter = 0;
                }
                else if (countera < counterb)
                {
                    counter = -1;
                }
            }
            if (arraya.Length == arrayb.Length)
            {
                for (int i = 0; i < arrayb.Length; i++)
                {
                    if (arraya[i] > arrayb[i])
                    {
                        countera++;
                    }
                    else if (arraya[i] < arrayb[i])
                    {
                        counterb++;
                    }
                    else if (arraya[i] == arrayb[i])
                    {
                        countera++;
                        counterb++;
                    }
                }

                if (countera > counterb)
                {
                    counter = 1;
                }
                else if (counterb == countera)
                {
                    counter = 0;
                }
                else if (countera < counterb)
                {
                    counter = -1;
                }
            }
            return counter;
        }

    }
}
