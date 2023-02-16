using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaU.Budget.Core.Entities
{
    public class TrainingProgram : IEntity
    {        
        public string Code;
        public string Name;
        public DateTime StartDate;
        public DateTime EndDate;

        Guid IEntity.Id => Guid.Empty;
    }
}
