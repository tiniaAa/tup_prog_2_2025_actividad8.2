using Ejerecicio1.Models;
using Ejerecicio1.Models.Exportadores;

namespace Ejerecicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<IExportable> multas = new List<IExportable>();

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            IExportable nuevo = null;

            string patente = tbPatente.Text;
            DateTime vencimiento = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day);
            double Importe = Convert.ToDouble(tbImporte.Text);

            nuevo = new Multa(patente, vencimiento, Importe);

            multas.Sort();
            int idx = multas.BinarySearch(nuevo);
            if (idx >= 0)
            {
                Multa multa = multas[idx] as Multa;
                multa.Importe += Importe;
                if (multa.Vencimiento < ((Multa)multa).Vencimiento) ;
                multa.Vencimiento = ((Multa)multa).Vencimiento;
            }
            else
            {
                multas.Add(nuevo);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            lsbVer.Items.Clear();
            foreach (Multa m in multas)
            {
                lsbVer.Items.Add(m);
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(csv)|*.csv|(json)|*.json|(xml)|*.xml|(txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs= null;
                StreamReader sr =null;

                string path = openFileDialog1.FileName;
                int tipo = openFileDialog1.FilterIndex;
                IExportador exportador = (new ExportadorFactory().GetInstance(tipo));

                fs = new FileStream(path,FileMode.Open,FileAccess.Read);
                sr = new StreamReader(fs);

                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string linea = sr.ReadLine();
                    IExportable multa = new Multa();

                    if (multa.Importar(linea,exportador)==true)
                    {
                        multas.Sort();
                        int idx = multas.BinarySearch(multa);
                        if (idx >= 0)
                        {



                        }
                        else { multas.Add(multa); }

                    }

                }



            }

        }
    }
}
