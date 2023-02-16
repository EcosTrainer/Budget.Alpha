using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaU.Budget.Util.Validators
{
    public interface IValidator<T>
    {
        public bool Validate(T item);
    }
}
