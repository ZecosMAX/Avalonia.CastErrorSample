using ReactiveUI;
using System.Collections.ObjectModel;

namespace Avalonia.CastErrorSample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<ChildViewModel?> children = [];
        public ObservableCollection<ChildViewModel?> Children { get => children; set => this.RaiseAndSetIfChanged(ref children, value); }

        public MainWindowViewModel()
        {
            for (int i = 0; i < 10; i++)
            {
                children.Add(new ChildViewModel()
                {
                    StringProperty1 = $"Children #{i + 1}",
                });
            }
        }
    }
}
