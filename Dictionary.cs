using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5osaKollektsioonid
{
    internal class Dictionary
    {
        public void dicti()
        {
            Dictionary<int, string> riigid = new Dictionary<int, string>();

            riigid.Add(1, "Hiina");
            riigid.Add(2, "Eesti");
            riigid.Add(3, "Itaalia");

            foreach (var paar in riigid)
            {
                Console.WriteLine($"{paar.Key} – {paar.Value}");
            }

            string pealinn = riigid[2];
            riigid[2] = "Eestimaa";
            riigid.Remove(3);
        }
    }
}
