using JalaU.Budget.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaU.Budget.Util.Validators
{
    public interface IProgramValidator : IValidator<TrainingProgram>
    {
        public bool Validate(TrainingProgram item);
    }
}
