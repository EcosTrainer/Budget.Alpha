using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaU.Budget.Core
{
    public interface IBudgetCommand
    {
        public void Execute();
    }
}
