using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestExpression
{
    [TestClass]
    public class TestExpression
    {
        [TestMethod]
        public void Test1() {
        // ((2*x*y^3)/2) + 1 = 55
            Expression<Func<double, double, double>> exp1 = (x, y) =>  ((2 * x * (Math.Pow(y, 3)))/2) + 1; 
            
            Func<double, double, double> test1 = exp1.Compile();
            var a = test1(2, 3);
            Assert.IsTrue(a == 55);
        }

        //compute area of the circle formula
        [TestMethod]
        public void Test2() {
            // pi * r ^ 2
            Expression<Func<double, double>> areaOfCircle = r => Math.PI * Math.Pow(r, 2); 
            Func<double, double> test2 = areaOfCircle.Compile();
            var b = test2(2);
            Assert.IsTrue((b / 12.566370614359172953850573533118)==1);
        }
    }
}
