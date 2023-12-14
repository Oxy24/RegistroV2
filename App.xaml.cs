using RegistroV2.DataLayer;
using RegistroV2.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace RegistroV2
{
    /// <summary>
    /// Logica di interazione per App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static StudentiRepoService StudentiRepo { get; set; }
        protected override void OnStartup(StartupEventArgs e)
        {
            StudentiRepo = StudentiRepoService.Instance;
            StudentiRepo.InitializeDataManager(new GestioneFile("DatiStudenti"));
            //StudentiRepo.InitializeDataManager(new DBManagement("DatiStudenti"));
        }
    }
}
