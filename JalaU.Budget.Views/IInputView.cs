using JalaU.Budget.Core;

namespace JalaU.Budget.Views
{
    public interface IInputView: IOptionView<IEntity>
    {
        public List<IEntity> GetData();
    }
}
