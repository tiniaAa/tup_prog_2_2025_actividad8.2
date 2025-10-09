using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerecicio1.Models.Exportadores
{
    public interface IExportador
    {
        public bool Importar(string daa, Multa m );
        public string Exportar(Multa m );
    }
}
