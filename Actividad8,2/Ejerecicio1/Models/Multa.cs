using Ejerecicio1.Models.Exportadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerecicio1.Models
{
    public  class Multa:IComparable,IExportable
    {
        public string Patente { get; set; } 
        public DateOnly Vencimiento { get; set; }

        public double Importe { get; set; }

        public Multa() { }

        public Multa(string Patente, DateOnly vencimiento, double importe)
        {
            this.Patente = Patente;
            this.Vencimiento = vencimiento;
            this.Importe = importe;
        }
        public bool Importar (string data,IExportador exportador)
        {
            return exportador.Importar(data,this);
        }
        public string Exportar (IExportador exportador)
        {
            return exportador.Exportar(this);
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
            return $"{Patente}-{Vencimiento:dd/MM/yyyy}-{Importe}";
        }



    }
}
