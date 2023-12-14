using Microsoft.Win32;
using Pratica_DashBoard.FrameWork;
using RegistroV2.Model;
using RegistroV2.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace RegistroV2.ViewModel
{

    public class Scelta1ViewModel : BaseNotification
    {
        string _nome;
        string _cognome;
        string _pathfoto= "file:///C:/Users/Olsi Imeraj/Downloads/DefaultPFP.jpg";
        public string Nome { get { return _nome; } set { _nome = value; OnPropertyChanged(nameof(Nome)); }}
        public string Cognome { get { return _cognome; } set { _cognome = value; OnPropertyChanged(nameof(Cognome)); }}
        public string pathFoto { get { return _pathfoto; } set { _pathfoto = value; OnPropertyChanged(nameof(pathFoto)); } }
        public ICommand SaveCommand { get; set; }

        public Scelta1ViewModel()
        {
            SaveCommand = new RelayCommand(Save);
        }

        private void Save()
        {
            if(Nome!=null && Cognome!=null)
            { App.StudentiRepo.Aggiungi(new Studente(Nome, Cognome, pathFoto)); }          
            Nome = Cognome = null;
            _pathfoto = "file:///C:/Users/Olsi Imeraj/Downloads/DefaultPFP.jpg";
        }
    }
}