using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejerecicio1.Models.Exportadores
{
    public class XMLExportador : IExportador
    {
       

        public string Exportar(Multa m)
        {
            return $"<Multa><Patente>{m.Patente}</Patente><Vencimiento>{m.Vencimiento}</Vencimiento><Importe>{m.Importe}</Vencimiento>";
        }


        public bool Importar(string daa, Multa multa)
        {
            Regex r = new Regex(@"<Patente>(\w{3}\d{3})</Patente><Vencimienteo>(\d{2}/\d{2}/\d{4})</Vencimiento><Importe>(\d+,\d*)</Importe>",RegexOptions.IgnoreCase);
            Match m = r.Match(daa);

            if (m.Success)
            {
                string patente = m.Groups[1].Value;
                DateTime vencimiento = Convert.ToDateTime(m.Groups[2].Value);
                double importe = Convert.ToDouble(m.Groups[3].Value);


                multa.Patente = patente;
                multa.Importe = importe;
                multa.Vencimiento = vencimiento;

                return true;
            }
            else return false;
        }
    }
}
