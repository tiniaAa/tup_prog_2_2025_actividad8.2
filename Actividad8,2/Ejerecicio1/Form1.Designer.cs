namespace Ejerecicio1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbPatente = new TextBox();
            tbImporte = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lsbVer = new ListBox();
            btnExportar = new Button();
            dateTimePicker = new DateTimePicker();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            btnImportar = new Button();
            btnActualizar = new Button();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // tbPatente
            // 
            tbPatente.Location = new Point(131, 43);
            tbPatente.Margin = new Padding(3, 2, 3, 2);
            tbPatente.Name = "tbPatente";
            tbPatente.Size = new Size(110, 23);
            tbPatente.TabIndex = 0;
            // 
            // tbImporte
            // 
            tbImporte.Location = new Point(131, 115);
            tbImporte.Margin = new Padding(3, 2, 3, 2);
            tbImporte.Name = "tbImporte";
            tbImporte.Size = new Size(110, 23);
            tbImporte.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 43);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 4;
            label1.Text = "Patente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 77);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 5;
            label2.Text = "Vencimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 115);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "Importe";
            // 
            // lsbVer
            // 
            lsbVer.FormattingEnabled = true;
            lsbVer.ItemHeight = 15;
            lsbVer.Location = new Point(33, 156);
            lsbVer.Margin = new Padding(3, 2, 3, 2);
            lsbVer.Name = "lsbVer";
            lsbVer.Size = new Size(253, 169);
            lsbVer.TabIndex = 7;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(319, 287);
            btnExportar.Margin = new Padding(3, 2, 3, 2);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(102, 37);
            btnExportar.TabIndex = 10;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "dd//MM/yyyy";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(131, 77);
            dateTimePicker.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(110, 23);
            dateTimePicker.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(319, 225);
            btnImportar.Margin = new Padding(3, 2, 3, 2);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(102, 36);
            btnImportar.TabIndex = 12;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(319, 163);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(102, 36);
            btnActualizar.TabIndex = 13;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(319, 78);
            btnConfirmar.Margin = new Padding(3, 2, 3, 2);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(102, 36);
            btnConfirmar.TabIndex = 14;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 338);
            Controls.Add(btnConfirmar);
            Controls.Add(btnActualizar);
            Controls.Add(btnImportar);
            Controls.Add(dateTimePicker);
            Controls.Add(btnExportar);
            Controls.Add(lsbVer);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbImporte);
            Controls.Add(tbPatente);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPatente;
        private TextBox dtpVencimiento;
        private TextBox tbImporte;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lsbVer;
        private Button button2;
        private Button button3;
        private Button btnExportar;
        private DateTimePicker dateTimePicker;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button btnImportar;
        private Button btnActualizar;
        private Button btnConfirmar;
    }
}
