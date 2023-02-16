using JalaU.Budget.Core;
using JalaU.Budget.Core.Entities;

namespace JalaU.Budget.Programs.Commands
{
    public class ListProgramsCommand : IOutputCommand
    {
        private IEnumerable<TrainingProgram> programs;
        private IController<TrainingProgram> programController;

        public ListProgramsCommand(IController<TrainingProgram> programController)
        {
            this.programController = programController;
        }

        public void Execute()
        {
            this.programs = programController.Read();
        }

        public List<IEntity> GetContext()
        {
            return this.programs.ToList<IEntity>();
        }
    }
}
