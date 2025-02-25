﻿using System;
namespace UnitTestingExercise
{
    public class Calculator
    {
        //public Calculator(int num1, int num2, int num3) { }
        //DONE: Step 1: Add a reference to your UnitTestingExercise project:

        //DONE:  Right-click on the 'Dependencies' folder in your UnitTestingExercise.Tests project
        //DONE:  and add your reference to the UnitTestingExercise project

        //DONE:  Step 2: Create an Add method that accepts 3 integers, adds those integers, and returns an integer
        //For Example:
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        
        //DONE: Step 3: Navigate to the UnitTests.cs file and complete the AddTest unit test method 
        
        //DONE: Step 4: 
        //DONE:  Create a Subtract method that accepts 2 integers
        //DONE:  Keep track of which number is getting passed as minuend and subtrahend
        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        //DONE:  Step 5: Navigate to the UnitTests.cs file and complete the SubtractTest unit test method

        //DONE: Step 6: 
        //DONE: Create a Multiply method that passes 2 integers
        public int Multiply(int mult1, int mult2)
        {
            return mult1 * mult2;
        }

        //DONE: Step 7: Navigate to the UnitTests.cs file and complete the MultiplyTest unit test method 

        //DONE: Step 8: 
        //DONE: Create a Divide method that passes 2 integers
        public int Divide(int divisor, int dividend)
        {
            return divisor / dividend;
        }
        //DONE: Step 9: Navigate to the UnitTests.cs file and complete the DivideTest unit test method 


        //*****NOW RUN ALL OF YOUR TESTS*********//
    }
}
