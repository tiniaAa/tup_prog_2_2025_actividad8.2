using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerecicio1.Models.Exportadores
{
    public class CSVExportador : IExportador
    {
        public string Exportar(Multa m)
        {
            return $"{m.Patente};{m.Vencimiento};{m.Importe}";
        }

        public bool Importar(string daa, Multa m)
        {
            daa = daa.Trim();
            
            string[] atributos = daa.Split(';');

            string patente = atributos[0];
            DateTime vencimiento = Convert.ToDateTime(atributos[1]);
            double importe = Convert.ToDouble(atributos[2]);

            m.Patente = patente;
            m.Vencimiento = vencimiento;
            m.Importe = importe;

            return true;           
        }
    }
}
