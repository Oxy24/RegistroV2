using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroV2.DataLayer
{
    internal class GestioneFile : IDataManagement
    {
        string filePath;
        public GestioneFile(string filePath)
        {
            this.filePath = filePath;
        }

        public List<T> Leggi<T>()
        {
            List<T> listaOggetti = new List<T>();
            try
            {
                if (File.Exists(filePath))
                {
                    string jsonContent=File.ReadAllText(filePath);
                    listaOggetti = JsonConvert.DeserializeObject<List<T>>(jsonContent);
                }
                else
                {
                    Console.WriteLine("Il file non esiste. Creazione di una nuova lista.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore Deserializzazione: {ex.Message}");
            }
            return listaOggetti;
        }

        public void Scrivi<T>(List<T> listaOggetti)
        {
            try
            {
                string jsonContent = JsonConvert.SerializeObject(listaOggetti,Formatting.Indented);
                File.WriteAllText(filePath,jsonContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore Serializzazione: {ex.Message}");
            }
        }
    }
}
