using JalaU.Budget.Core;
using JalaU.Budget.Core.Entities;

namespace JalaU.Budget.Programs.Commands
{
    public class RegisterProgramCommand : IInputCommand
    {
        public List<TrainingProgram> programs;
        private IController<TrainingProgram> programController;

        public RegisterProgramCommand(IController<TrainingProgram> programController)
        {
            this.programController = programController;
        }

        public void Execute()
        {
            this.programController.Register(this.programs.First());
        }

        public void SetContext(List<IEntity> entities)
        {
            this.programs = new List<TrainingProgram>();
            foreach (IEntity entity in entities)
            {
                this.programs.Add((TrainingProgram)entity);
            }
        }
    }
}
