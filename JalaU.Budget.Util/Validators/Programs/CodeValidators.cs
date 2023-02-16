using JalaU.Budget.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaU.Budget.Util.Validators.Programs
{
    public class CodeValidator : IProgramValidator
    {
        public bool Validate(TrainingProgram item)
        {
            return item.Code.Length >= 3;
        }
    }
}
