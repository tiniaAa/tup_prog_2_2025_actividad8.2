using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerecicio1.Models.Exportadores
{
    internal class ExportadorFactory
    {
        public IExportador GetInstance(int tipo)
        {
            IExportador exportador = null;

            switch (tipo)
            {
                case 1:
                    exportador = new CSVExportador();
                    break;
                case 2:
                    exportador = new JSONExportador();
                    break;
                case 3:
                    exportador = new CampoFijoExportador();
                    break;
                case 4:
                    exportador = new XMLExportador();
                    break;
                default:
                    break;
            }
            return exportador;


        }
    }
}
