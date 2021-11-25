using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;



namespace SistemaContabilidad_LibriDiario_LibroMayor.Dao
{
    partial class CuentaDao
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

        public List<Modelos.Cuenta> obtenerListaCuentasporTipo(String tipoCuenta)
        {
            List<Modelos.Cuenta> lista = new List<Modelos.Cuenta>();
            //Realizamos la consulta  a la BD
            String consulta = "SELECT * FROM cuentas WHERE tipo = '" + tipoCuenta + "';";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            MySqlDataReader lectura = comando.ExecuteReader();

            while (lectura.Read())
            {
                Modelos.Cuenta cuenta = new Modelos.Cuenta();
                cuenta.id = lectura.GetString(0);
                cuenta.Codigo = lectura.GetString(1);
                cuenta.Tipo = lectura.GetString(2);
                cuenta.Nombre = lectura.GetString(3);

                lista.Add(cuenta);
            }

            comando.Connection.Close();

            return lista;
        }

        public List<Modelos.Cuenta> obtenerListaCuentas()
        {
            List<Modelos.Cuenta> lista = new List<Modelos.Cuenta>();
            //Realizamos la consulta  a la BD
            String consulta = "SELECT * FROM `cuentas`";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            MySqlDataReader lectura = comando.ExecuteReader();


            while (lectura.Read())
            {
                Modelos.Cuenta cuenta = new Modelos.Cuenta();
                cuenta.id = lectura.GetString(0);
                cuenta.Nombre = lectura.GetString(1);
                cuenta.Tipo = lectura.GetString(2);
                                
                lista.Add(cuenta);
            }

            comando.Connection.Close();

            return lista;
        }

        public void Eliminar(Modelos.Cuenta cuenta)
        {
            //Realizamos la consulta  a la BD
            String consulta = "DELETE FROM cuentas WHERE idcuentas = " + cuenta.id + ";";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Update(Modelos.Cuenta cuenta)
        {

            //Realizamos la consulta  a la BD
            String consulta = "UPDATE `cuentas` SET `nombre` = '" + cuenta.Nombre + "' WHERE `cuentas`.`idcuentas` = " + cuenta.id + ";";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();

            comando.Connection.Close();


        }

        public void Guardar(Modelos.Cuenta cuenta)
        {

            //Realizamos la consulta  a la BD
            String consulta = "INSERT INTO cuentas (`id`, `codigo`, `tipo`, `nombre`) VALUES (NULL, '" + cuenta.Tipo + "', '" + cuenta.Nombre + "');";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();
            comando.Connection.Close();


        }
    }
}
