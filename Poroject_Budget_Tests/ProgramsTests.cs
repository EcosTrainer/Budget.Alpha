using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using JalaU_Budget;

namespace Poroject_Budget_Tests
{
    [TestClass]
    public class ProgramsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            IController<TrainingProgram> myProgram = new ProgramsController();
        }
    }
}
