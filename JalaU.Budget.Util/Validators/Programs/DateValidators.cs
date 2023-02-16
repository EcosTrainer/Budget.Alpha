using JalaU.Budget.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaU.Budget.Util.Validators.Programs
{
    public class StartDateValidator : IProgramValidator
    {
        public bool Validate(TrainingProgram item)
        {
            return item.StartDate.DayOfWeek == DayOfWeek.Monday;
        }
    }

    public class EndDateValidator : IProgramValidator
    {
        public bool Validate(TrainingProgram item)
        {
            return item.EndDate.DayOfWeek == DayOfWeek.Friday;
        }
    }
}
