using Pratica_DashBoard.FrameWork;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroV2.Model
{
    public class Studente : BaseNotification
    {
        string _nome;
        string _cognome;
        string _pathFoto;
        public Studente(string nome, string cognome, string pathFoto)
        {
            Nome = nome;
            Cognome = cognome;
            PathFoto = pathFoto;
        }

        public string Nome { get { return _nome; } set { _nome = value; OnPropertyChanged(nameof(Nome)); } }
        public string Cognome { get { return _cognome; } set { _cognome = value; OnPropertyChanged(nameof(Cognome)); } }
        public string PathFoto { get { return _pathFoto; } set { _pathFoto = value; OnPropertyChanged(nameof(PathFoto)); } }
    }
}
