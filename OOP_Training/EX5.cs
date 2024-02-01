using System;
using System.Security.Cryptography.X509Certificates;

namespace Exercise5{

    public class Shape{
        protected Location c;

        public static void Execute() {
            Console.WriteLine("UML exercise");
        }

        public string ToString() {
            return string.Empty;
        }

        public double Area() {
            return 0.000;
        }

        public double Perimeter() {
            return 0.000;
        }
    }

    public class Rectangle : Shape{
        protected double side1;
        protected double side2;
    }

    public class Circle : Shape{
        protected double radius;
    }

    public class Location {
        private double x, y;
    }
}
