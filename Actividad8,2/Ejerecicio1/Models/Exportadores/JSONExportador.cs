using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejerecicio1.Models.Exportadores
{
    internal class JSONExportador : IExportador
    {
        public string Exportar(Multa m)
        {
            return $"{{\"Patente\":\"{m.Patente}\",\"Vencimiento\":\"{m.Vencimiento}\" ,\"Importe\":\"{m.Importe}\"}},";
        }

        public bool Importar(string daa, Multa m)
        {
            Match match = Regex.Match(daa, @"""Patente""\s*:\s*""([A-Z]{3}[0-9]{3})""\s*,\s*""Vencimiento""\s*:\s*""(\d{2}/\d{2}/\d{4})""\s*,\s*""Importe""\s*:\s*(\d+\.\d+)");
            // @"""Patente"" \s*:\s*""([A-Z]{3}[0-9]{3})""\s*,\s*""Vencimiento""\s*:\s* ""(\d{2}/\d{2}/\d{4})""\s*,\s* ""Importe""\s*:\s*(\d+.\d+) "

            if (match.Success)
            {

                m.Patente = match.Groups[1].Value;
                m.Vencimiento = Convert.ToDateTime(match.Groups[2].Value);
                m.Importe = Convert.ToDouble(match.Groups[3].Value,CultureInfo.InvariantCulture);
                
                return true;
            }

            return false;
        }
    }
}
