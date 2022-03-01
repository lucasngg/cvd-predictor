using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Text;
using System.Windows.Input;
using ReactiveUI;

namespace MEngProject.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            ShowDialog = new Interaction<Interface1, Interface2?>();

            OnClickCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                var store = new Interface1();

                var result = await ShowDialog.Handle(store);
            });
        }

        public ICommand OnClickCommand { get; }

        public Interaction<Interface1, Interface2?> ShowDialog { get; }
    }
}
