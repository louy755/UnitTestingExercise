﻿using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
        // Righ-click on Dependencies in your .Tests project and set your reference
        // Done

        //Done  Create an Add method that passes 3 integers

        public int Add(int number, int number2, int number3)
        {
            var result = number + number2 + number3;
            return result;
        }
        //Done Create a Subtract method that passes 2 integers

        // Keep track of which number is getting passed as minuend and subtrahend

        public int Subtract(int num, int num2)
        {
            var result = num - num2;

            return result;
        }

        //Done Create a Multiply method that passes 2 integers

        public int Multiply(int num, int num2)
        {
            var result = num * num2;

            return result;
        }

        // Create a Divide method that passes 2 integers
        public int Divide(int num, int num2)
        {
            try
            {
                var result = num / num2;
                return result;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division of {0} by zero.", num);
                return -1;
            }

        }


        // Create 2 methods that will utilize the [Fact] tests you wrote


    }
}
