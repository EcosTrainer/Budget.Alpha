using JalaU.Budget.Core;

namespace JalaU.Budget.Views
{
    public interface IOutputView : IOptionView<IEntity>
    {
        public void SetData(List<IEntity> items);
    }
}