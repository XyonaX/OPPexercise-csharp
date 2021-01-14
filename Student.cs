using System;
using OOPExercise;

namespace OOPexercise
{
    public class Student : Person
    {
      


        public Student(String name) : base(name)
        {
            this.Name = name;
        }


        public void study() 
        {            
            Console.WriteLine("I'm studing");
        }

        public void ShowAge() 
        {
            Console.WriteLine("My age is: " + this.Age + "years old.");
        }

        public void Study()
        {
            Console.WriteLine("Study");
        }

    }
}
