using JalaU.Budget.Core;
using JalaU.Budget.Core.Entities;

namespace JalaU.Budget.Programs
{
    public class ProgramsRepository : IRepository<TrainingProgram>
    {
        private List<TrainingProgram> _programs = new List<TrainingProgram>();

        public IEnumerable<TrainingProgram> GetAll()
        {
            return _programs;
        }

        public bool Save(TrainingProgram entity)
        {
            _programs.Add(entity);
            return true;
        }
    }
}
