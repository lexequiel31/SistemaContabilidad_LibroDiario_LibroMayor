using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaContabilidad_LibriDiario_LibroMayor
{
    public partial class LibroDiariocs : Form
    {
        
        public LibroDiariocs()
        {
            InitializeComponent();
            comboBoxTIPODEBE.Items.Add("AC");
            comboBoxTIPODEBE.Items.Add("PC");
            comboBoxTIPODEBE.Items.Add("PNC");
            comboBoxTIPODEBE.Items.Add("ANC");
            comboBoxTIPODEBE.Items.Add("PN");

            comboBoxTIPOHABER.Items.Add("AC");
            comboBoxTIPOHABER.Items.Add("PC");
            comboBoxTIPOHABER.Items.Add("PNC");
            comboBoxTIPOHABER.Items.Add("ANC");
            comboBoxTIPOHABER.Items.Add("PN");
        }

        private void cargarConmboxCuentasDebe(String tipoCuenta)
        {
            Dao.CuentaDao baseDeDatos = new Dao.CuentaDao();

            List<Modelos.Cuenta> listaDb = baseDeDatos.obtenerListaCuentasporTipo(tipoCuenta);
                        
            //agregamos los elementos al comboBox
            for (int i = 0; i < listaDb.Count; i++)
            {
                comboBoxCUENTADEBE.Items.Add(listaDb[i].Nombre);
                               
            }

            
        }

        private void cargarConmboxCuentasHaber(String tipoCuenta)
        {
            Dao.CuentaDao baseDeDatos = new Dao.CuentaDao();

            List<Modelos.Cuenta> listaDb = baseDeDatos.obtenerListaCuentasporTipo(tipoCuenta);

            //agregamos los elementos al comboBox
            for (int i = 0; i < listaDb.Count; i++)
            {
                comboBoxCUENTAHABER.Items.Add(listaDb[i].Nombre);

            }


        }

        private List<Registro> listaRegistros = new List<Registro>();

        private void buttonREGISTRAR_Click(object sender, EventArgs e)
        {
            Registro registro1 = new Registro();
            registro1.CuentaDebe = comboBoxCUENTADEBE.Text;
            registro1.CuentaHaber = comboBoxCUENTAHABER.Text;
            registro1.Fecha = textBox2FECHA.Text;
            registro1.SaldoDebe = textBoxSALDO.Text;
            registro1.SaldoHaber = textBoxSALDO.Text;
            registro1.Tipo = comboBoxTIPODEBE.Text;

            listaRegistros.Add(registro1);

            //AGREGO BASE DE DATOS
            Dao.RegistroDao basedatos = new Dao.RegistroDao();
            basedatos.Guardar(registro1);
            
            //CODIGO A LA TABLA

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaRegistros;

        }

        private void LibroDiariocs_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTIPO_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCUENTADEBE.Items.Clear();
            comboBoxCUENTADEBE.Text = null;
            cargarConmboxCuentasDebe(comboBoxTIPODEBE.Text);
        }

        private void buttonLIMPIAR_Click(object sender, EventArgs e)
        {
            comboBoxCUENTADEBE.Text = null;
            comboBoxCUENTAHABER.Text = null;
            textBox2FECHA.Text = null;
            textBoxSALDO.Text = null;
            textBoxSALDO.Text = null;
            comboBoxTIPODEBE.Text = null;
        }

        private void comboBoxCUENTAHABER_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxTIPOHABER_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCUENTAHABER.Items.Clear();
            comboBoxCUENTAHABER.Text = null;
            cargarConmboxCuentasHaber(comboBoxTIPOHABER.Text);
        }

        private void buttonLIBROMAYOR_Click(object sender, EventArgs e)
        {
            LibroMayor ventanaLibroMayor = new LibroMayor();

            ventanaLibroMayor.ShowDialog(); //
        }

        private void buttonSALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
