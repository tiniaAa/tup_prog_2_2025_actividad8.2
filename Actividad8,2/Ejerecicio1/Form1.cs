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
            DateOnly vencimiento = new DateOnly(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day);
            double Importe = Convert.ToDouble(tbImporte.Text);

            nuevo = new Multa(patente, vencimiento, Importe);

            multas.Sort();
            int idx = multas.BinarySearch(n);
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
            openFileDialog1.Filter = "(csv)|*.csv|(json)|*.json|";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string name = openFileDialog1.FileName;
                int tipo = openFileDialog1.FilterIndex;

                FileStream fs = new FileStream(name, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                CSVExportador csvexportador = null;
                XMLExportador xmlexportador = null;
                if (tipo == 1)
                {
                    csvexportador = new CSVExportador();
                }
                if (tipo == 2)
                {
                    xmlexportador = new XMLExportador();
                }
                while (!sr.EndOfStream)
                {
                    string linea = sr.ReadLine();

                    IExportable multa = new Multa();
                    IExportable exportador = null;

                    

                    
                }

            }

        }
    }
}
