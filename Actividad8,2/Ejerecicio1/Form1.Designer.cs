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
            tbPatente.Location = new Point(150, 57);
            tbPatente.Name = "tbPatente";
            tbPatente.Size = new Size(125, 27);
            tbPatente.TabIndex = 0;
            // 
            // tbImporte
            // 
            tbImporte.Location = new Point(150, 153);
            tbImporte.Name = "tbImporte";
            tbImporte.Size = new Size(125, 27);
            tbImporte.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 57);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 4;
            label1.Text = "Patente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 103);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 5;
            label2.Text = "Vencimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 153);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 6;
            label3.Text = "Importe";
            // 
            // lsbVer
            // 
            lsbVer.FormattingEnabled = true;
            lsbVer.Location = new Point(38, 208);
            lsbVer.Name = "lsbVer";
            lsbVer.Size = new Size(289, 224);
            lsbVer.TabIndex = 7;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(365, 383);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(116, 49);
            btnExportar.TabIndex = 10;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "dd//MM/yyyy";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(150, 103);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(125, 27);
            dateTimePicker.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(365, 300);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(116, 48);
            btnImportar.TabIndex = 12;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(365, 217);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(116, 48);
            btnActualizar.TabIndex = 13;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(365, 104);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(116, 48);
            btnConfirmar.TabIndex = 14;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 450);
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
