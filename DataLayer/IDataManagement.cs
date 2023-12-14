using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroV2.DataLayer
{
    public interface IDataManagement
    {
        List<T> Leggi<T>();
        void Scrivi<T>(List<T> listaOggetti);
    }
}
