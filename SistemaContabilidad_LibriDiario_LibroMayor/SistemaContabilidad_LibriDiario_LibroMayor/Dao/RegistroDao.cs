using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;


namespace SistemaContabilidad_LibriDiario_LibroMayor.Dao
{
    class RegistroDao
    {
        public MySqlConnection Conectar()
        {
            string servidor = "localhost"; //creamos el servidor 
            string usuario = "root"; //usuario que accede
            string password = "";
            string baseDeDatos = "globallab3";


            string connstring = string.Format("Server=localhost; database={0}; UID=root; password=; SslMode = none", baseDeDatos);

            MySqlConnection conectar = new MySqlConnection(connstring);

            conectar.Open();

            return conectar;

        }

        public void Guardar(Registro registro1)
        {

            //Realizamos la consulta  a la BD
            String consulta = "INSERT INTO registros (`fecha`, `cuentadebe`, `debe`, `cuentahaber`, `haber`) VALUES ('"+registro1.Fecha+"', '"+ registro1.CuentaDebe+ "', '"+ registro1.SaldoDebe+ "', '"+ registro1.CuentaHaber+ "', '"+ registro1.SaldoHaber+ "');";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();

            comando.Connection.Close();


        }

        public List<Registro> obtenerListaporCuenta(String tipoCuenta)
        {
            List<Registro> lista = new List<Registro>();
            //Realizamos la consulta  a la BD
            String consulta = "SELECT * FROM registros WHERE cuentadebe = '" + tipoCuenta + "' OR cuentahaber = '" + tipoCuenta+"';";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            MySqlDataReader lectura = comando.ExecuteReader();

            while (lectura.Read())
            {
                Registro registro2 = new Registro();
                registro2.id = lectura.GetString(0);
                registro2.Fecha = lectura.GetString(1);
                registro2.CuentaDebe = lectura.GetString(2);
                registro2.SaldoDebe = lectura.GetString(3);
                registro2.CuentaHaber = lectura.GetString(4);
                registro2.SaldoHaber = lectura.GetString(5);

                lista.Add(registro2);
            }

            comando.Connection.Close();

            return lista;
        }

        
    }
}
