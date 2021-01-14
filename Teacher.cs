using System;
using OOPExercise;

namespace OOPexercise
{
    public class Teacher: Person
    {
        public Teacher(String name): base(name)
        {
        }

        public void Explain() {
            Console.WriteLine("I'm explaining");
        }
    }
}
