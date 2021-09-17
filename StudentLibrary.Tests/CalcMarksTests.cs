using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StudentLibrary;
namespace StudentLibrary.Tests
{
    [TestClass]
    public class CalcMarksTests
    {
        [TestMethod]
        public void Calculate_Total_Marks()
        {
            int ExpectedMarks = 100;
            ICalcMarks marks = new CalcMarks();
            int ActualMarks = marks.Calculate(50, 25, 25);
            Assert.AreEqual(ExpectedMarks, ActualMarks);
        }
    }
}
