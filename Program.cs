using System;
using System.Collections.Generic;

namespace ConsoleApp11
{
    class Program
    {

        static void Main(string[] args)
        {
            Person person1 = new Person("Ehmed", "", 21);
            Person person2 = new Person("Lale", "", 21);
            Person person3 = new Person("Ibrahim", "", 23);
            Person person4 = new Person("Eatime", "", 23);
            Person person5 = new Person("Flnare", "", 23);
            Person person6 = new Person("Simare", " ", 19);
            Person person7 = new Person("Emil", "", 18);
            List<Person> people = new List<Person>();
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            people.Add(person5);
            people.Add(person6);
            people.Add(person7);
            Console.WriteLine(people.Find(Person => Person.Age == 21).Name);
            Console.WriteLine(people.Find(Person => Person.Age == 23).Name);
            List<Person> AllInfo = new List<Person>(people.FindAll(Person => Person.Age == 23));

            people.Sort((x, y) => x.Name.CompareTo(y.Name));
            foreach (Person i in AllInfo)
            {
                Console.WriteLine(i.Name);
            }
            Console.WriteLine(people.IndexOf(person7));
         
        }

    }
}
