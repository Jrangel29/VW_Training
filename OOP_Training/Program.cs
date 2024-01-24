// See https://aka.ms/new-console-template for more information
using Exercise1;
using Exercise2;
using Exercise3;

public class Program() {
    static void Main() {
        Console.WriteLine("Where do you want to go?\n1. Exercise 1\n2. Exercise 2\n3. Exercise 3");
        
        int choice;
        if(int.TryParse(Console.ReadLine(), out choice)){
            switch(choice){
                case 1:
                    Names.Execute();
                    break;
                case 2:
                    StudentProfessorTest.Execute();
                    break;
                case 3:
                    PhotobookTest.Execute();
                    break;
                default:
                    Console.WriteLine("Sorry, but that exercise doesn't exist!");
                    break;
            }
        }
    }
}