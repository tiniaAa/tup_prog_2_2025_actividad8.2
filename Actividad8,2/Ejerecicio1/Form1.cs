using Ejerecicio1.Models;

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
    }
}
