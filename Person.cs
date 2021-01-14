using System;

namespace OOPExercise
{
    public class Person
    {
        public string Name{ get; set;}
        public int Age;

        public Person(String name) {
            this.Name = name;
        }

        public override string ToString()
        {
            return "Hello my name is " + Name;
        }

        public void Greet() {
            Console.WriteLine("Hello!");
        }

        public void SetAge(int age)
        {
            this.Age = age;
        }
    }

}