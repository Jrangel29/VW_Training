using System;
using System.Dynamic;

namespace Exercise2{

    class StudentProfessorTest {
        
        public static void Execute(){
            Person person = new Person();
            Student student = new Student();
            Teacher professor = new Teacher();

            person.Greet();
            Console.WriteLine("Please insert the students age:");

            int input;
            if(int.TryParse(Console.ReadLine(), out input)){
                person.SetAge(input);
            } else {
                Console.WriteLine("Sorry, but that age isn't valid");
            }
            
            Console.WriteLine(student.Study());
            Console.WriteLine(student.ShowAge());
            Console.WriteLine(professor.Explain());
        }
    }

    class Person {
        public static int personAge {get; set;}
        public string Greet(){
            return "Hello!";
        }

        public void SetAge(int age){
            personAge = age;
        }
    }

    class Student {
        public string Study(){
            return "I'm studying!";
        } 

        public string ShowAge(){
            return $"I am {Person.personAge} years old.";
        }
    }

    class Teacher {
        public string Explain() {
            return "I'm explaining";
        }
    }
}