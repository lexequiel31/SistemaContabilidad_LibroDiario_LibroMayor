using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql;

namespace SistemaContabilidad_LibriDiario_LibroMayor
{
    public partial class LibroMayor : Form
    {
        public LibroMayor()
        {
            InitializeComponent();

            comboBoxTIPO.Items.Add("AC");
            comboBoxTIPO.Items.Add("PC");
            comboBoxTIPO.Items.Add("PNC");
            comboBoxTIPO.Items.Add("ANC");
            comboBoxTIPO.Items.Add("PN");
        }

        private void LibroMayor_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxCUENTA_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            String mesDesde = null;
            if (dateTimePickerDESDE.Value.Month < 10)
            {
                mesDesde = "0" + dateTimePickerDESDE.Value.Month.ToString();
            }
            else
            {
                mesDesde = dateTimePickerDESDE.Value.Month.ToString();
            }

            String diaDesde = null;
            if (dateTimePickerDESDE.Value.Day < 10)
            {
                diaDesde = "0" + dateTimePickerDESDE.Value.Day.ToString();
            }
            else
            {
                diaDesde = dateTimePickerDESDE.Value.Day.ToString();
            }

            String añoDesde = dateTimePickerDESDE.Value.Year.ToString();

            String fechaDesde = añoDesde + mesDesde  + diaDesde;

            MessageBox.Show(fechaDesde);

            //FECHA HASTA

            String mesHasta = null;
            if (dateTimePickerHASTA.Value.Month < 10)
            {
                mesHasta = "0" + dateTimePickerHASTA.Value.Month.ToString();
            }
            else
            {
                mesHasta = dateTimePickerHASTA.Value.Month.ToString();
            }

            String diaHasta = null;
            if (dateTimePickerHASTA.Value.Day < 10)
            {
                diaHasta = "0" + dateTimePickerHASTA.Value.Day.ToString();
            }
            else
            {
                diaHasta = dateTimePickerHASTA.Value.Day.ToString();
            }
            String añoHasta = dateTimePickerHASTA.Value.Year.ToString();
            String fechaHasta = añoHasta + mesHasta + diaHasta;

            MessageBox.Show(fechaHasta);

            cargarTabla(comboBoxCUENTA.Text, fechaDesde, fechaHasta);
            
        }

        private void cargarConmbox(String tipoCuenta)
        {
            Dao.CuentaDao baseDeDatos = new Dao.CuentaDao();

            List<Modelos.Cuenta> listaDb = baseDeDatos.obtenerListaCuentasporTipo(tipoCuenta);

            //agregamos los elementos al comboBox
            for (int i = 0; i < listaDb.Count; i++)
            {
                comboBoxCUENTA.Items.Add(listaDb[i].Nombre);

            }


        }

        public void cargarTabla(String cuenta, String fechaDesde, String fechaHasta)
        {
            List<Registro> listaLibroMayor = new List<Registro>();

            Dao.RegistroDao listadb = new Dao.RegistroDao();

            listaLibroMayor = listadb.obtenerListaporFecha(cuenta, fechaDesde, fechaHasta);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = listaLibroMayor;

            double totalHABER = 0;
            double totalDEBE = 0;

            foreach (var reg in listaLibroMayor)
            {
                if (reg.CuentaDebe.Equals(cuenta))
                {
                    totalDEBE = totalDEBE + double.Parse(reg.SaldoDebe);
                }
                else
                {
                    totalHABER = totalHABER + double.Parse(reg.SaldoHaber);
                }
            }

            double Saldo = totalDEBE - totalHABER;

            textBoxTOTALDEBE.Text = totalDEBE.ToString();
            textBoxTOTALHABER.Text = totalHABER.ToString();

            textBoxSALDO.Text = Saldo.ToString();
        }

        
        private void comboBoxTIPO_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCUENTA.Items.Clear();
            comboBoxCUENTA.Text = null;
            cargarConmbox(comboBoxTIPO.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonLIBRODIARIO_Click(object sender, EventArgs e)
        {
            LibroDiariocs librodiario = new LibroDiariocs();

            librodiario.ShowDialog();
        }

        private void buttonMENU_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
