using ConsoleTableExt;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.List
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region Array List
            /*
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Apple");
            arrayList.Add("Banana");
            arrayList.Add("Cherry");

            Console.WriteLine("Element at index 1 is: {0}", arrayList[1]);

            Console.WriteLine("Elements in the list:");

            for (int i = 0; i < arrayList.Count; i++)
                Console.WriteLine(arrayList[i]);

            arrayList.Remove("Banana");

            Console.WriteLine("Elements after removing Banana");

            foreach(var item in arrayList)
                Console.WriteLine(item);

            arrayList.Clear();

            Console.WriteLine("Array list after clearing");
            Console.WriteLine("Count: {0}", arrayList.Count);
              */
            #endregion

            #region List
            /*List<Person> people = new List<Person>();

            Person personOne = new Person()
            {
                Name = "Oliver",
                Age = 29
            };

            people.Add(new Person("John", 25));
            people.Add(new Person("Alice", 30));
            people.Add(new Person("Bob", 35));
            people.Add(personOne);

            GenerateTable(people);

            Person bob = people.Find(person => person.Name == "Bob");

            people.Remove(bob);

            GenerateTable(people);
            */
            #endregion

            #region Dictionary
            /*
            Dictionary<int, Person> people = new Dictionary<int, Person>();

            people.Add(1, new Person("Oliver", 29));
            people.Add(2, new Person("Bob", 25));
            people.Add(3, new Person("Alice", 20));
            people.Add(4, new Person("John", 27));
            people.Add(5, new Person("Mark", 23));

            foreach (var item in people)
                Console.WriteLine("Key {0}: {1} {2}", item.Key, item.Value.Name, item.Value.Age);

            people.Remove(2);

            foreach (var item in people)
                Console.WriteLine("Key {0}: {1} {2}", item.Key, item.Value.Name, item.Value.Age);
            */
            #endregion

            #region Set
            /*
            HashSet<Person> people = new HashSet<Person>();
            people.Add(new Person("Oliver", 29));
            people.Add(new Person("Alice", 30));
            people.Add(new Person("Bob", 25));

            GenerateTable(people.ToList());
            */
            #endregion

            #region Queue
            /*
            Queue<string> names = new Queue<string>();
            names.Enqueue("Bob");
            names.Enqueue("Oliver");
            names.Enqueue("Alice");
            

            foreach (string name in names)
                Console.WriteLine(name);

            string firstItem = names.Peek();

            Console.WriteLine(firstItem);

            string dequeue = names.Dequeue();

            Console.WriteLine(dequeue);

            foreach (string name in names)
                Console.WriteLine(name);
            */
            #endregion

            Dictionary<int, List<Subject>> subjectsEnrolled = new Dictionary<int, List<Subject>>();

            subjectsEnrolled
                .Add(1, new List<Subject>() 
                    {
                        new Subject() { Name = "CC 103" },
                        new Subject() { Name = "RIZAL 101" }
                    }
                );

            List<Student> students = new List<Student>();
            students.Add(
                new Student()
                    {
                        StudentNumber = "4120009",
                        Addresses = new List<string>()
                        {
                            "Manila", "Quezon City", "Antipolo"
                        },
                        ContactNumber = new List<string>()
                        { 
                            "0123456789", "0123456789"
                        }
                    }
               );

            foreach(Student student in students)
            {
                Console.WriteLine(student.StudentNumber);
                ConsoleTableBuilder
                  .From(student.Addresses)
                  .ExportAndWriteLine();
            }

            Console.ReadLine();
        }

        public static void GenerateTable(List<Person> people)
        {
            ConsoleTableBuilder
              .From(people)
              .ExportAndWriteLine();
        }

        public static void Generatable(HashSet<Person> people) 
        {
            ConsoleTableBuilder
                 .From(people.ToList())
                 .ExportAndWriteLine();
        }
    }
}
