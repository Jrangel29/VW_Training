using System;

namespace Exercise1{
    class Names {    
        public static void Execute() {
            
            Console.WriteLine("Hi! Please insert 3 names:");
            int total = 3;

            Person[] people = new Person[total];

            for(int i = 0; i < total; i++) {
                Console.WriteLine($"Name {i + 1}:");
                people[i] = new Person () {
                    Name = Console.ReadLine()
                };
            }

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(people[i].ToString());
            }

        }
    }

    class Person {
        public string Name {get; set;}
        public override string ToString()
        {
            return $"Hello, my name is {Name}";
        }
        
    }
}