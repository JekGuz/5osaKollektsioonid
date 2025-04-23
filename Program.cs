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


            // Список фильмов
            List<Film> filmid = new List<Film>()
            {
                new Film() { Pealkiri = "Pride and Prejudice", Aasta = 2005, Zanr = "Draama" },
                new Film() { Pealkiri = "The Notebook", Aasta = 2004, Zanr = "Romantika" },
                new Film() { Pealkiri = "Little Women", Aasta = 2019, Zanr = "Ajalooline" },
                new Film() { Pealkiri = "The Devil Wears Prada", Aasta = 2006, Zanr = "Komöödia" },
                new Film() { Pealkiri = "Amélie", Aasta = 2001, Zanr = "Romantika" },
                new Film() { Pealkiri = "La La Land", Aasta = 2016, Zanr = "Muusikal" },
                new Film() { Pealkiri = "The Intern", Aasta = 2015, Zanr = "Komöödia" },
                new Film() { Pealkiri = "Eat Pray Love", Aasta = 2010, Zanr = "Eneseleidmine" },
                new Film() { Pealkiri = "The Age of Adaline", Aasta = 2015, Zanr = "Romantika" },
                new Film() { Pealkiri = "Memoirs of a Geisha", Aasta = 2005, Zanr = "Draama" }
            };

            // 1. Ищим фильм по жанру
            Console.WriteLine("------------------------Leiavad kõik filmid, mis kuuluvad kindlasse žanrisse------------------------");
            Console.WriteLine("Sisesta žanr:");
            string zanr = Console.ReadLine();

            foreach (Film f in filmid)
            {
                if (f.Zanr == zanr)
                    Console.WriteLine($"{f.Pealkiri} ({f.Aasta})");
            }

            // 2. Ищим самый новый фильм по годам
            Console.WriteLine("------------------------Leiavad uusima filmi------------------------");
            Film uusim = filmid[0];
            foreach (Film f in filmid)
            {
                if (f.Aasta > uusim.Aasta)
                    uusim = f;
            }
            Console.WriteLine($"Uusim film: {uusim.Pealkiri} ({uusim.Aasta})");

            // 3. Группируем по жанру
            Console.WriteLine("------------------------ Grupeerivad filmid žanrite kaupa ------------------------");
            Dictionary<string, List<Film>> grupeeritud = new Dictionary<string, List<Film>>();

            foreach (Film f in filmid)
            {
                if (grupeeritud.ContainsKey(f.Zanr) == false)
                {
                    grupeeritud[f.Zanr] = new List<Film>();
                }

                grupeeritud[f.Zanr].Add(f);
            }

            foreach (var paar in grupeeritud)
            {
                Console.WriteLine("Žanr: " + paar.Key);
                foreach (Film f in paar.Value)
                    Console.WriteLine($" - {f.Pealkiri}({f.Aasta})");
            }

            // Статистика массива чисел
            Console.WriteLine("-----------------------------  Arvude massiivi statistika -------------------------------------------");
            Console.WriteLine("Sisesta arvud (tühikuga):");
            string sisend = Console.ReadLine();

            Statistika s = new Statistika();
            double[] m = s.arvud(sisend);
            Console.WriteLine("Arvutame statistikat...");
            s.kuva(m);

            // Регистр домашних животных
            Console.WriteLine("-----------------------------  Lemmikloomade register -------------------------------------------");
            // начнем сделаем лист
            List<Loom> loomad = new List<Loom>();
            // через for собирем записи (примерно 5)
            // на нужно имя, вид, возраст все по очареди спросим
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Sisesta looma nimi: ");
                string nimi = Console.ReadLine();

                Console.WriteLine("Sisesta looma liik (kass/koer): ");
                string liik = Console.ReadLine();

                Console.WriteLine("Sisesta looma vanus: ");
                int vanus = int.Parse(Console.ReadLine()); //Parse() — это метод, который преобразует текст в число (int).

                // запишим в loom сначала получили данные этого животного в конце запишим
                Loom l = new Loom();
                l.Nimi = nimi;
                l.Liik = liik;
                l.Vanus = vanus;
                loomad.Add(l);
            }


            Console.WriteLine("Lõpetamiseks klõpsa (ENTER)");
            Console.ReadLine();
        }
    }
}