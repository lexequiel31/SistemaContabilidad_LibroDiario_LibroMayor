using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

            cargarTabla(comboBoxCUENTA.Text);
            
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

        public void cargarTabla(String cuenta)
        {
            List<Registro> listaLibroMayor = new List<Registro>();

            Dao.RegistroDao listadb = new Dao.RegistroDao();

            listaLibroMayor = listadb.obtenerListaporCuenta(cuenta);

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
    }
}
