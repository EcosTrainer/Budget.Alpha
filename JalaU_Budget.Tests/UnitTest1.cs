using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using JalaU_Budget;

namespace JalaU_Budget.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IController<TrainingProgram> myProgram = new ProgramsController();
        }
    }
}
