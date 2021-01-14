using System;
using OOPExercise;

namespace OOPexercise
{
    public abstract class Animal
    {
        private string Name;

        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public abstract void Eat();
    }
}