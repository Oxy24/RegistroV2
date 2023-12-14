using Pratica_DashBoard.FrameWork;
using RegistroV2.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RegistroV2.ViewModel
{
    internal class Scelta2ViewModel : BaseNotification
    {
        public ObservableCollection<Studente> ElencoStudentiVM => App.StudentiRepo.elencoStudenti;
        public Studente ItemSelezionato { get; set; }
        public ICommand RemoveCommand { get; set; }
    
        public Scelta2ViewModel()
        {
            RemoveCommand = new RelayCommand(Remove);
        }
        private void Remove()
        {
             App.StudentiRepo.Rimuovi(ItemSelezionato);
        }

       
    }
}
