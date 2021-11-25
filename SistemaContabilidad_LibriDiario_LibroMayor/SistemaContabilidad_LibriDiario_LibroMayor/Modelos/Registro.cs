using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaContabilidad_LibriDiario_LibroMayor
{
    class Registro
    {
        private string tipo;
        private string cuentaDebe;
        private string fecha;
        private string saldoDebe;
        private string cuentaHaber;
        private string saldoHaber;

        public string id { get; set; }
        public string CuentaDebe { get; set; }
        public string Fecha { get; set; }
        public string SaldoHaber { get; set; }
        public string CuentaHaber { get; set; }
        public string SaldoDebe { get; set; }
        public string Tipo { get; set; }

    }
}
