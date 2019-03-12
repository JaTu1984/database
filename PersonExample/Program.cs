using System;
using System.Runtime.InteropServices;
using PersonExample.Repositories;

namespace PersonExample
{
    class Program
    {
        private static readonly PersonRepository PersonRepository = new PersonRepository();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Testing database Read
            ReadByCity();
            //ReadById();
        }
        static void ReadByCity()
        {
            var persons = PersonRepository.ReadByCity("Juuka");
            foreach (var p in persons)
            {
                Console.WriteLine($"{p.Id} {p.FirstName} {p.LastName} {p.City}");
            }
        }
        static void ReadById()
        {
            var person = PersonRepository.ReadById(1);
            Console.WriteLine($"{person.Id} {person.FirstName} {person.LastName} {person.City}");
        }
    }
}
