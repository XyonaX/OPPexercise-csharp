using System;
using OOPExercise;

namespace OOPexercise
{
    public class SuperPhotoBook : Photobook
    {
        public SuperPhotoBook(int numPages) : base(numPages)
        {
            numPages = 64;
        }
    }
}