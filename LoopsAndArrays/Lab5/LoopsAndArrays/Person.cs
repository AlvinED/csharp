using System;

namespace LoopsAndArrays
{
    public class Person
    {
        private string _name { get; set; }
        private int _age { get; set; }

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public void Display()
        {
            Console.Write("Name : " + _name);
            Console.Write("Age  : " + _age);
            Console.WriteLine();
        }
    }
}