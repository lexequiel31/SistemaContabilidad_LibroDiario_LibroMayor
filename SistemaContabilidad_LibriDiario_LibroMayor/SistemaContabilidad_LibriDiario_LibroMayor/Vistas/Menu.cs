using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaContabilidad_LibriDiario_LibroMayor
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibroDiariocs ventanaLibroDiario = new LibroDiariocs();

            ventanaLibroDiario.ShowDialog(); //
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
