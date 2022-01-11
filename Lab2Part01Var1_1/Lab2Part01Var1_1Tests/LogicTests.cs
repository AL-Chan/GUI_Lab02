using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2Part01Var1_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Part01Var1_1.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void CircleGreaterThanSquareTest() //старт тест1 r= 2, a= 3
        {
            var r = 2; 
            var a = 3; 

            var Sci = Logic.AreaCircle(r);
            var Ssq = Logic.AreaSquare(a);
            var outMessage1 = Logic.Compare(Ssq, Sci);

            Assert.AreEqual(Sci + " > " + Ssq + 
                "\nПлощадь круга больше площади квадрата.", outMessage1);            
        }
        [TestMethod()]
        public void SquareGreaterThanCircleTest() //старт тест2 r= 2, a= 4
        {
            var r = 2;
            var a = 4;

            var Sci = Logic.AreaCircle(r);
            var Ssq = Logic.AreaSquare(a);
            var outMessage1 = Logic.Compare(Ssq, Sci);

            Assert.AreEqual(Sci + " < " + Ssq + 
                "\nПлощадь квадрата больше площади круга.", outMessage1);
        }
        [TestMethod()]
        public void CircleIncorrectNumTest() //старт тест3 r= -2, a= 3
        {
            var r = -2;
            var a = 3;

            var outMessage0 = Logic.NonNegativity(r, a);

            Assert.AreEqual("Некорректное значение " + r + 
                " для радиуса круга.\nПовторите попытку.", outMessage0);
        }
        [TestMethod()]
        public void SquareIncorrectNumTest() //старт тест4 r= 2, a= -1
        {
            var r = 2;
            var a = -1;

            var outMessage0 = Logic.NonNegativity(r, a);

            Assert.AreEqual("Некорректное значение " + a + 
                " для стороны квадрата.\nПовторите попытку.", outMessage0);
        }
        [TestMethod()]
        public void IncorrectAllNumsTest() //старт тест5 r=-3, a=0
        {
            var r = -3;
            var a = 0;

            var outMessage0 = Logic.NonNegativity(r, a);

            Assert.AreEqual("Некорректное значение " + r + 
                " для радиуса круга.\nНекорректное значение " + a + 
                " для стороны квадрата.\nПовторите попытку.", outMessage0);
        }
    }
}