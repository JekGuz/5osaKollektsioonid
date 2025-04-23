using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5osaKollektsioonid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array - одного типа данные
            Console.WriteLine("----------------------------- ArrayList -------------------------------------------");
            ArrayList nimed = new ArrayList();
            nimed.Add("Kati");
            nimed.Add("Mati");
            nimed.Add("Juku");

            if (nimed.Contains("Mati"))
                Console.WriteLine("Mati olemas");

            Console.WriteLine("Nimesid kokku: " + nimed.Count);

            nimed.Insert(1, "Sass");

            Console.WriteLine("Mati indeks: " + nimed.IndexOf("Mati"));
            Console.WriteLine("Mari indeks: " + nimed.IndexOf("Mari"));

            foreach (string nimi in nimed)
                Console.WriteLine(nimi);

            // Может иметь разные значения в списке/массиве   
            Console.WriteLine("----------------------------- Tuple -------------------------------------------");
            Tuple<float, char, string, int> route = new Tuple<float, char, string, int>(2.5f, 'N', "Nimi", '5');
            Console.WriteLine($"Vahemaa: {route.Item1}, Suund: {route.Item2}, String: {route.Item3}, Integer: {route.Item4}");

            // обращаемся к class1 -> лист
            Console.WriteLine("----------------------------- List -------------------------------------------");
            Class1 c1 = new Class1();
            c1.listi();

            // обращаемся к Dictinary -> словарь
            Console.WriteLine("----------------------------- Dictinary -------------------------------------------");
            Dictionary d = new Dictionary();
            d.dicti();

        }
    }
}