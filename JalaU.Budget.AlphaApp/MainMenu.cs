using JalaU.Budget.Core;
using JalaU.Budget.Views;

namespace JalaU.Budget.AlphaApp
{
    public class MainMenu
    {
        private List<IOptionView<IEntity>> views= new List<IOptionView<IEntity>>();
        private List<IBudgetCommand> commands = new List<IBudgetCommand>();
        private List<MenuOptionType> options = new List<MenuOptionType>();

        public MainMenu(List<MenuOption> menuOptions)
        {
            foreach(var option in menuOptions)
            {
                this.views.Add(option.View);
                this.commands.Add(option.Command);
                this.options.Add(option.optionType);
            }
        }
        
        public void Show()
        {
            this.ShowHeader();
            this.ShowOptions();
            this.ChooseOption();
        }

        private void ShowHeader()
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("            Dev Programs Budget            ");
            Console.WriteLine("===========================================");
        }

        private void ShowOptions()
        {
            if (views.Any())
            {
                int menuIndex = 1;
                foreach (IView view in views)
                {
                    Console.Write("{0}. ", menuIndex++.ToString());
                    view.Show();
                }
            }            
            else
            {
                this.ShowNoOptions();
            }
        }

        private void ChooseOption()
        {
            Console.Write("\nWrite the option number: ");
            int number = int.Parse(Console.ReadLine());

            if(this.options[number - 1] == MenuOptionType.Input)
            {
                ExecuteInputOption(number);
            }
            if (this.options[number - 1] == MenuOptionType.Output)
            {
                ExecuteOutputOption(number);
            }

            Console.WriteLine("Successful operation.");
        }

        private void ExecuteOutputOption(int number)
        {
            try
            {
                this.commands[number - 1].Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred. {0}", ex.Message);
            }

            ((IOutputView)this.views[number - 1]).SetData(((IOutputCommand)this.commands[number - 1]).GetContext());

            this.views[number - 1].ShowContent();
        }

        private void ExecuteInputOption(int number)
        {
            this.views[number - 1].ShowContent();

            ((IInputCommand)this.commands[number - 1]).SetContext(((IInputView)this.views[number - 1]).GetData());

            try
            {
                this.commands[number - 1].Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred. {0}", ex.Message);
            }
        }

        private void ShowNoOptions()
        {
            Console.WriteLine("\n           No options registered            ");
        }
    }
}