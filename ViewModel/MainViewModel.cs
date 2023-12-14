using Pratica_DashBoard.FrameWork;
using RegistroV2.ViewModel;
using System.Windows;
using System.Windows.Input;

namespace RegistroV2.ViewModel
{
    public class MainViewModel : BaseNotification
    {
        private object _currentView;
        public object CurrentView { get { return _currentView; } set { if (value != null) {_currentView = value;} OnPropertyChanged(nameof(CurrentView)); } }
        public ICommand Scelta1Command { get; set; }
        public ICommand Scelta2Command { get; set; }

        public MainViewModel()
        {
            Scelta1Command = new RelayCommand(Scelta1);
            Scelta2Command = new RelayCommand(Scelta2);
        }

        public void Scelta1()
        {
            CurrentView = new Scelta1ViewModel();
        }

        public void Scelta2()
        {
            CurrentView = new Scelta2ViewModel();
        }
    }
}
