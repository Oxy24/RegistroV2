using Microsoft.Win32;
using RegistroV2.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RegistroV2.View
{
    /// <summary>
    /// Logica di interazione per Scelta1View.xaml
    /// </summary>
    public partial class Scelta1View : UserControl
    {
        public Scelta1View()
        {
            InitializeComponent();
        }
        private void AddImage_Click(object sender, RoutedEventArgs e)
        {
            // Crea un nuovo OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Imposta i filtri dei file
            openFileDialog.Filter = "Image files (*.jpg, *.png, *.gif) | *.jpg;*.png;*.gif";

            // Mostra il dialogo
            if (openFileDialog.ShowDialog() == true)
            {
                // L'utente ha selezionato un file
                // Ottieni il percorso del file
                string filePath = openFileDialog.FileName;

                // Carica l'immagine dal file
                BitmapImage bitmapImage = new BitmapImage(new Uri(filePath));
                PosImage.Source = bitmapImage;
            }
        }
    }
}
