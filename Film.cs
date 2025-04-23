using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5osaKollektsioonid
{
    class Film
    {
        // нужен для структуры на будущее в фильмах
        public string Pealkiri { get; set; }
        public int Aasta { get; set; }
        public string Zanr { get; set; }

        public override string ToString()
        {
            return $"{Pealkiri} ({Aasta}) - Žanr: {Zanr}";
        }
    }

}
