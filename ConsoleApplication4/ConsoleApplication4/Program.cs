using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = 0;
            int[,] myArr = new int[4, 10] {{2,4,4,7,6,5,2,2,3,4}, 
                                           {4,3,6,5,4,7,6,6,5,3}, 
                                           {2,4,2,3,5,7,4,3,3,2},
                                           {4,5,6,6,10,4,3,3,2,3}};

            Console.WriteLine("Исходный массив чисел: ");


            int[] myArr1 = new int[40];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    myArr1[l] = myArr[i, j];
                    l++;
                    Console.Write("{0}\t", myArr[i, j]);
                }
            }

            //в одно
            Console.Write("Перевод с 2х мерного в одно \n");
            foreach (var item in myArr1)
                Console.Write(item);
            Console.Write("\n\n");

            //сортировка
            Array.Sort(myArr1);
            Console.Write("Сортировка масива \n");
            foreach (var item in myArr1)
                Console.Write(item);
            Console.Write("\n");

            int minElement = myArr1[0];
            int maxElement = myArr1[0];
            foreach (int element in myArr1)
            {
                if (element < minElement)
                {
                    minElement = element;
                }
                else if (maxElement < element)
                {
                    maxElement = element;
                }
            }

            Console.WriteLine("\nМинимальное значение {0}\nМаксимальное значение {1}\n", minElement, maxElement);


            //количество повторений
            int Count = 0;
            for (int i = 0; i < myArr1.Length; i++)
            {
                for (int j = 0; j < myArr1.Length; j++)
                {
                    if (myArr1[i] == myArr1[j])
                        Count++;
                }             
                Console.WriteLine("Элемент {0} встречается в массиве {1} раз", myArr1[i], Count);
                Count = 0;
                
            }
            Console.WriteLine();


            //среднее ареф строки
            float d, c;
            d = 0;
            c = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                    {
                        c += myArr[i, j];
                    }

                d = c / 10;
                Console.WriteLine("Среднее арифметическое {0} строки = {1}", i + 1, d);
                
            }
            Console.WriteLine();
            //среднее ареф столбца
            c = 0;
            d = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    c += myArr[j, i];
                }
                d = c / 4;
                c = 0;
                Console.WriteLine("Среднее арифметическое {0} столбца = {1}", i + 1, d);
            }
            float h = 0;
            for (int i = 0; i < myArr1.Length; i++)
            {
                Array.Sort(myArr1);
                int g = myArr1.Length - 1;
                if (g % 2 == 0)
                {
                    h = (myArr1[g] + myArr1[g]) / 2;
                }
                else h = myArr1[g];
            }
            Console.WriteLine();
            Console.WriteLine("Медиана масива = {0}\n", h);

            //мода
            int max = myArr1[0];
             int cmax = 0, rmax = 0;
             for (int i = 0; i < myArr1.Length; i++)
            {
                if (cmax > rmax)
                {
                    rmax = cmax;
                    max = myArr1[i - 1];
                }
                cmax = 0;
                for (int j = i; j < myArr1.Length; j++)
                    if (myArr1[j] == myArr1[i])
                        cmax++;
            }
            Console.WriteLine("Мода масива {0} количество повторений = {1}\n", max, rmax);


            //среднее квадратическое + дисперсия масива
            double MatOj = 0;
            double Disp = 0;

            for (int i = 0; i < myArr1.Length; i++)
                MatOj = myArr1[i] + MatOj;
            MatOj = MatOj / myArr1.Length;

            for (int i = 0; i < myArr1.Length; i++)
                Disp = Math.Pow((myArr1[i] - MatOj), 2) + Disp;
            Disp = Disp / myArr1.Length;

            Console.WriteLine("Дисперсия масива = {0}\n", Disp);
            Console.WriteLine("Среднее квадратическое отклонение = {0}", Math.Sqrt(Disp));
            
           
            Console.ReadLine();
        }

    }
}
