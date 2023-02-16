using JalaU.Budget.Core;
using JalaU.Budget.Core.Entities;

namespace JalaU.Budget.Views
{
    public class ListProgramsView : IOutputView
    {
        private List<TrainingProgram> programs;
        
        public void Show()
        {
            Console.WriteLine("List Application Programs");
        }

        public void ShowContent()
        {
            this.ShowColumnHeaders();
            this.ShowItems();
        }

        private void ShowItems()
        { 
        }

        private void ShowColumnHeaders()
        {
            Console.WriteLine("|      Code      |      Name      |   Start Date   |    End Date    |");
        }

        public void SetData(List<IEntity> items)
        {
            this.programs = new List<TrainingProgram>();
            foreach(var item in items)
            {
                programs.Add((TrainingProgram)item);
            }            
        }
    }
}
