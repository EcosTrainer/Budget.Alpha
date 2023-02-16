using JalaU.Budget.Core;
using JalaU.Budget.Core.Entities;

namespace JalaU.Budget.Views
{
    public class CreateProgramView : IInputView
    {
        List<TrainingProgram> result;

        public List<IEntity> GetData()
        {
            List<IEntity> resultAsEntity = new List<IEntity>();
            foreach (var item in this.result)
            {
                resultAsEntity.Add((IEntity)item);
            }
            return resultAsEntity;
        }

        public void Show()
        {
            Console.WriteLine("Register Program v2");
        }

        public void ShowContent()
        {
            TrainingProgram newProgram = new TrainingProgram();
            Console.Write("Enter the code: ");
            newProgram.Code = Console.ReadLine();
            Console.Write("Enter the name: ");
            newProgram.Name = Console.ReadLine();
            Console.Write("Enter the start date (dd/mm/yyyy): ");
            string inputDate = Console.ReadLine();
            string[] inputData = inputDate.Split('/');
            newProgram.StartDate = new DateTime(int.Parse(inputData[2]), int.Parse(inputData[1]), int.Parse(inputData[0]));
            Console.Write("Enter the end date (dd/mm/yyyy): ");
            inputDate = Console.ReadLine();
            inputData = inputDate.Split('/');
            newProgram.StartDate = new DateTime(int.Parse(inputData[2]), int.Parse(inputData[1]), int.Parse(inputData[0]));

            this.result = new List<TrainingProgram>();
            this.result.Add(newProgram);
        }
    }
}
