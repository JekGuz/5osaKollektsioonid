using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _5osaKollektsioonid
{
    // List 
    class Person
    {
        public string Name { get; set; }
    }

    internal class Class1
    {
        public void listi()
        {
            List<Person> people = new List<Person>();

            people.Add(new Person() { Name = "Kadi" });
            people.Add(new Person() { Name = "Mirje" });

            foreach (Person p in people)
                Console.WriteLine(p.Name);
        }
    }
}

