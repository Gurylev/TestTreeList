using System.Collections.ObjectModel;
using TestTreeList.Models;

namespace TestTreeList.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<IProjectVariable> Variables { get; set; } = [];

        public MainWindowViewModel()
        {
            for (var i = 0; i < 15; i++)
            {
                Variables.Add(new Variable()
                {
                    Name = "Name" + i.ToString(),
                    Scope = "Scope" + i.ToString()
                });
            }
            
        }
       
    }
}
