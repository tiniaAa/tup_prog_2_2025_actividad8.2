using Ejerecicio1.Models.Exportadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejerecicio1.Models
{
    public  class Multa:IComparable,IExportable
    {
        string patente;
        public string Patente
        {
            get { return patente; }
            set
            {
                Regex regex = new Regex(@"^[a-z]{3}\d{3}$", RegexOptions.IgnoreCase);
                Match match = regex.Match(value);
                if (match.Success)
                {
                    this.patente = value;
                }
                else { throw new FormatoPatenteNoValidoException(); }

            }
        }


        public DateTime Vencimiento { get; set; }
        public double Importe { get; set; }

        public Multa() { }

        public Multa(string Patente, DateTime vencimiento, double importe)
        {
            this.patente = Patente;
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
                return Patente.CompareTo(multa.Patente);
            }
            return -1;
        }

        public override string ToString()
        {
            return $"{Patente}-{Vencimiento:dd/MM/yyyy}-{Importe}";
        }



    }
}
