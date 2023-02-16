using JalaU.Budget.Core;
using JalaU.Budget.Core.Entities;

namespace JalaU_Budget.Programs.Tests
{
    internal class FakeProgramsRepository : IRepository<TrainingProgram>
    {
        private List<TrainingProgram> trainingPrograms;

        public FakeProgramsRepository()
        {
            this.trainingPrograms = new List<TrainingProgram>();

            trainingPrograms.Add(new TrainingProgram() { Code = "ABC.Jala.DEV.36", Name = "Dev36", StartDate = new DateTime(2022, 9, 5), EndDate = new DateTime(2022, 11, 2) });
            trainingPrograms.Add(new TrainingProgram() { Code = "ABC.Jala.DEV.37", Name = "Dev37", StartDate = new DateTime(2022, 10, 31), EndDate = new DateTime(2023, 12, 23) });
            trainingPrograms.Add(new TrainingProgram() { Code = "ABC.Jala.DEV.38", Name = "Dev38", StartDate = new DateTime(2022, 12, 5), EndDate = new DateTime(2023, 3, 31) });
            trainingPrograms.Add(new TrainingProgram() { Code = "ABC.Jala.DEV.39", Name = "Dev39", StartDate = new DateTime(2023, 2, 6), EndDate = new DateTime(2023, 6, 2) });
        }
        public IEnumerable<TrainingProgram> GetAll()
        {
            return trainingPrograms;
        }

        public bool Save(TrainingProgram entity)
        {
            throw new NotImplementedException();
        }
    }
}
