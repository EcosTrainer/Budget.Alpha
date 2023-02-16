using JalaU.Budget.Core;
using JalaU.Budget.Core.Entities;
using JalaU.Budget.Programs;
using JalaU.Budget.Util.Validators;
using JalaU.Budget.Util.Validators.Programs;

namespace JalaU_Budget.Programs.Tests
{
    [TestClass]
    public class ProgramsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            IController<TrainingProgram> myController = new ProgramsController();
            TrainingProgram newProgram = new TrainingProgram();

            newProgram.Code = "Dev38";
            newProgram.Name = String.Empty;
            newProgram.StartDate = new DateTime(2023, 2, 6);
            newProgram.EndDate = new DateTime(2023, 2, 10);

            bool result = myController.Register(newProgram);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            List<IProgramValidator> validators = new List<IProgramValidator>
            {
                new StartDateValidator()
            };

            IController<TrainingProgram> myController = new ProgramsController(validators);
            TrainingProgram newProgram = new TrainingProgram();

            newProgram.Code = "Dev38";
            newProgram.Name = String.Empty;
            newProgram.StartDate = new DateTime(2023, 2, 7);
            newProgram.StartDate = new DateTime(2023, 2, 10);

            bool result = myController.Register(newProgram);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            IController<TrainingProgram> myController = new ProgramsController(new FakeProgramsRepository());           

            IEnumerable<TrainingProgram> myPrograms = myController.Read();

            Assert.AreEqual(myPrograms.Count(), 4);
        }
    }
}