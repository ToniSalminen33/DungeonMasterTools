using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DMTools.ViewModels
{
    public class MenuViewModel
    {
        private ICommand tavernResidents;
        public ICommand TavernResidentsViewCommand
        {
            get
            {
                if (tavernResidents == null)
                    tavernResidents = new Updater();
                return tavernResidents;
            }
            set
            {
                tavernResidents = value;
            }
        }
    }
    class Updater : ICommand
    { 
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            MainWindow.instance.ViewContainer.Content = null;
            MainWindow.instance.ViewContainer.Content = new Views.TavernResidentsView();
        }
    }
}
