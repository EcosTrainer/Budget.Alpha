using JalaU.Budget.Core;
using JalaU.Budget.Core.Entities;
using JalaU.Budget.Util.Validators;

namespace JalaU.Budget.Programs
{
    public class ProgramsController : IController<TrainingProgram>
    {
        private List<IProgramValidator> localValidators;
        IRepository<TrainingProgram> localRepository;

        public ProgramsController(IRepository<TrainingProgram>? repository, List<IProgramValidator>? validators = null)
        {
            if (repository == null)
                localRepository = new ProgramsRepository();
            else
                localRepository = repository;

            if (validators != null)
                this.localValidators = validators;
        }

        public ProgramsController(List<IProgramValidator>? validators = null) : this(null, validators)
        {

        }

        public ProgramsController(IRepository<TrainingProgram>? repository) : this(repository, null)
        {

        }


        public bool Register(TrainingProgram item)
        {
            if (!this.Validate(item))
            {
                return false;
            }

            return localRepository.Save(item);
        }

        private bool Validate(TrainingProgram item)
        {
            if (localValidators != null)
            {
                foreach (IProgramValidator validator in localValidators)
                {
                    if (!validator.Validate(item))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public IEnumerable<TrainingProgram> Read()
        {            
            return this.localRepository.GetAll();
        }
    }
}