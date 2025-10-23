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

            try
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
                    if (multa.Vencimiento < ((Multa)nuevo).Vencimiento);
                    multa.Vencimiento = ((Multa)nuevo).Vencimiento;
                }
                else
                {
                    multas.Add(nuevo);
                }
            }
            catch (FormatoPatenteNoValidoException ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
                FileStream fs = null;
                StreamReader sr = null;


                string path = openFileDialog1.FileName;
                int tipo = openFileDialog1.FilterIndex;
                IExportador exportador = (new ExportadorFactory().GetInstance(tipo));



                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);

                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        string linea = sr.ReadLine();
                        IExportable multa = new Multa();

                        if (multa.Importar(linea, exportador) == true)
                        {
                            multas.Sort();
                            int idx = multas.BinarySearch(multa);
                            if (idx >= 0)
                            {
                                Multa m = multas[idx] as Multa;
                                m.Importe += (multa as Multa).Importe;
                                if (m.Vencimiento < (multa as Multa).Vencimiento)
                                {
                                    m.Vencimiento = (multa as Multa).Vencimiento;
                                }
                            }
                            else
                            {
                                multas.Add(multa);
                            }
                        }
                    }
                }
                catch (FormatoPatenteNoValidoException ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally
                {
                    if (sr != null) sr.Close();
                    if (fs != null) fs.Close();

                }

            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(csv)|*.csv|(json)|*.json|(xml)|*.xml|(txt)|*.txt";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                FileStream fs = null;
                StreamWriter sw = null;

                string path = openFileDialog1.FileName;
                int tipo = openFileDialog1.FilterIndex;

                fs = new FileStream(path,FileMode.Open,FileAccess.Write);
                sw = new StreamWriter(fs);
                IExportador exportador = (new ExportadorFactory().GetInstance(tipo));

                sw.WriteLine("Patente Vencimiento Importe");
                foreach (IExportable m in multas)
                {
                    string linea = m.Exportar(exportador);
                    if (linea!=null)
                    {
                        sw.WriteLine(linea);
                    }
                }
            }
        }
    }
}
