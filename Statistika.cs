using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5osaKollektsioonid
{
    internal class Statistika
    {
        public double[] arvud(string tekst)
        {
            // Разделение строки на элементы массива
            string[] osad = tekst.Split(' ');
            double[] tulemused = new double[osad.Length];

            for (int i = 0; i < osad.Length; i++)
            {
                tulemused[i] = double.Parse(osad[i]);
            }

            return tulemused;
        }


        public void kuva(double[] m)
        {
            //Поиск минимума, максимума и суммы
            double summa = 0;
            double min = m[0];
            double max = m[0];

            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] < min) min = m[i];
                if (m[i] > max) max = m[i];
                summa += m[i];
            }

            //Среднее значение и подсчёт чисел выше среднего
            double keskmine = summa / m.Length;

            int rohkem = 0;
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] > keskmine)
                {
                    rohkem++;
                }
            }

            //Выводим результат
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Keskmine: " + keskmine);
            Console.WriteLine("Summa: " + summa);
            Console.WriteLine("Rohkem kui keskmine: " + rohkem);

            //Сортировка и вывод отсортированного массива
            Array.Sort(m);
            Console.WriteLine("Sorteeritud:");
            for (int i = 0; i < m.Length; i++)
            {
                Console.Write(m[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

