
using JalaU.Budget.Core;
using JalaU.Budget.Views;

namespace JalaU.Budget.AlphaApp
{
    public class MenuOption
    {
        public IBudgetCommand Command { get; set; }
        public IOptionView<IEntity> View { get; set; }
        public MenuOptionType optionType { get; set; }
    }

    public enum MenuOptionType
    {
        Input,
        Output
    }
}
