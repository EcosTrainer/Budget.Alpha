using JalaU.Budget.Core;
using JalaU.Budget.Core.Entities;
using JalaU.Budget.Programs;
using JalaU.Budget.Programs.Commands;
using JalaU.Budget.Views;

namespace JalaU.Budget.AlphaApp
{
    public class AlphaApp
    {
        public void Start()
        {
            List<IOptionView<IEntity>> views = new List<IOptionView<IEntity>>();

            IController<TrainingProgram> programController = new ProgramsController();

            List<MenuOption> menuOptions = new List<MenuOption>();

            MenuOption CreateProgramOption = new MenuOption()
            {
                View = new CreateProgramView(),
                Command = new RegisterProgramCommand(programController),
                optionType = MenuOptionType.Input
            };
            menuOptions.Add(CreateProgramOption);

            MenuOption ListProgramsOption = new MenuOption()
            {
                View = new ListProgramsView(),
                Command = new ListProgramsCommand(programController),
                optionType = MenuOptionType.Input
            };
            menuOptions.Add(ListProgramsOption);

            new MainMenu(menuOptions).Show();
        }
    }
}