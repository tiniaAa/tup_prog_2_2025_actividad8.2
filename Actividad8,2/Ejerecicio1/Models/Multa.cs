using Ejerecicio1.Models.Exportadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerecicio1.Models
{
    public  class Multa:IComparable
    {
        public string Patente { get; set; } 
        public DateOnly Vencimiento { get; set; }

        public double Importe { get; set; }

        public Multa() { }

        public bool Importar (string data,IExportador exportador)
        {
            return true;
        }
        public string Exportar (IExportador exportador)
        {
            return "";
        }
        public int CompareTo(Object obj)
        {
            Multa multa = obj as Multa;
            if(obj!=null)
            {
                return Patente.CompareTo(multa.Patente))
            }
            return -1;
        }

        public override string ToString()
        {
            return $"{Patente}-{Vencimiento}-{Importe}";
        }
    }
}
