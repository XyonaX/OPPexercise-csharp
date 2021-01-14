using System;

namespace OOPExercise
{
    public class Photobook
    {
        private int numPages;

        public Photobook()
        {
            numPages= 16;
        }

        public Photobook(int numPages)
        {
            this.numPages = numPages;
        }

        public int GetNumberPages()
        {
            return numPages;
        }
    }

}
