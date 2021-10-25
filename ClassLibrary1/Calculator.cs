using System;

namespace ClassLibrary1
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }

        public int Subtract()
        {
            return FirstNumber - SecondNumber;
        }

        public int Multiply()
        {
            return FirstNumber * SecondNumber;
        }

        public float Divide()
        {

            if (SecondNumber == 0)
            {
                throw new DivideByZeroException();
            }

            return (float)FirstNumber / (float)SecondNumber;
        }

        public int modulusDiv ()
        {
            return FirstNumber % SecondNumber;
        }

    }
}
