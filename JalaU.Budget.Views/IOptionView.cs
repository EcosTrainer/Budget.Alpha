using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaU.Budget.Views
{
    public interface IOptionView<IEntity>: IView
    {        
        public void ShowContent();
    }
}
