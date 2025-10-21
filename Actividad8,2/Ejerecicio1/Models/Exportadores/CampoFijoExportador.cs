using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejerecicio1.Models.Exportadores
{
    internal class CampoFijoExportador : IExportador
    {
        public string Exportar(Multa m)
        {
            return $"{m.Patente,+9}{m.Vencimiento,-10:dd/MM/yyyy,}{m.Importe,+9:f2}";
        }

        public bool Importar(string daa, Multa m)
        {
            Match match = Regex.Match(daa,@"([A-Z]{3}[0-9]{3})\s*(\d{2}/\d{2}/\d{4})\s*(\d+,\d+)");
            if (match.Success)
            {
                m.Patente= match.Groups[1].Value;
                m.Vencimiento= Convert.ToDateTime(match.Groups[2].Value);
                m.Importe = Convert.ToDouble(match.Groups[3].Value);
                return true;
            }
            return false;

        }
    }
}
