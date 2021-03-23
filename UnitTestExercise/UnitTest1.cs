using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestExercise
{
    [TestClass]
    public class UnitTest1
    {
        public double Squareroot { get; private set; }

        [TestMethod]
        public void Square()
        {
            CalcLib.Calculation objc = new CalcLib.Calculation();

            int num1 = 20;
            int num2 = 20;
            int square = num1 * num2;
            Assert.IsNotNull(objc.Square(num1,num2));
        }
        [TestMethod]
        public void SquareRoot()
        {
            CalcLib.Calculation objc = new CalcLib.Calculation();

            int num1 = 20;
            int num2 = 20;
            int Number = num1 * num2;
            Squareroot = Math.Sqrt(Number);
            Assert.IsNotNull(objc.SquareRoot(SquareRoot));
        }
        [TestMethod]
        public void Cube()
        {
            CalcLib.Calculation objc = new CalcLib.Calculation();

            int num1 = 20;
            int num2 = 20;
            int num3 = 20;
            int square = num1 * num2 * num3;
            Assert.IsNotNull(objc.Cube(num1, num2,num3));
        }
    }
}
