using System;

namespace Exercise4{

    class Inheritance {
        public static void Execute(){
            int total = 3;
            Person[] people = new Person[total];

            Console.WriteLine("Insert 3 names:");

            for(int i = 0; i < 3; i++){
                if(i == 0){
                    people[i] = new Teacher(Console.ReadLine());
                } else {
                    people[i] = new Student(Console.ReadLine());
                }
            }

            for(int i = 0; i < 3; i++){
                if(i == 0){
                    ((Teacher)people[i]).Explain();
                } else {
                    ((Student)people[i]).Study();
                }
            }
        }
    }

    class Person {
        protected string Name {get; set;}
        public Person(string name){
            Name = name;
        }

        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }

        Person(){
            Name = string.Empty;
        }
    }

    class Student : Person {

        public Student(string name) : base(name)
        {
            Name = name;
        }

        public void Study(){
            Console.WriteLine($"Hi, I'm {Name} and I'm studying.");
        }
    }

    class Teacher : Person {

        public Teacher(string name) : base(name)
        {
            Name = name;
        }

        public void Explain(){
            Console.WriteLine($"Hi, I'm {Name} and I'm teaching.");
        }
    }
}