using RegistroV2.DataLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroV2.Model
{
    public class StudentiRepoService
    {
        IDataManagement dataManagement;
        public ObservableCollection<Studente> elencoStudenti {get; set;}
        private static StudentiRepoService _instance;

        public static StudentiRepoService Instance
        {
            get 
            {
                if(_instance == null)
                    _instance = new StudentiRepoService();
                return _instance;
            }
        }

        private StudentiRepoService() 
        {
            elencoStudenti = new ObservableCollection<Studente>(); 
        }

        public void InitializeDataManager(IDataManagement dataManagment)
        {
            Instance.dataManagement = dataManagment;
            CaricaDati();
        }
        public void CaricaDati()
        {
            foreach (var student in dataManagement.Leggi<Studente>())
            {
                elencoStudenti.Add(student);
            }
        }
        public void Aggiungi(Studente s)
        {
            elencoStudenti.Add(s);
            dataManagement?.Scrivi(new List<Studente>(elencoStudenti));
        }

        public void Rimuovi(Studente s)
        {
            elencoStudenti.Remove(s);
            dataManagement?.Scrivi(new List<Studente>(elencoStudenti));
        }
    }
}
