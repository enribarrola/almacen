using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace almacen.controlador
{
    class conexion2
    {
        String connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=almacen;";
        public MySqlConnection conn = new MySqlConnection();
        public MySqlConnection conectar()
        {
            try
            {   //caambiaar
                conn = new MySqlConnection(connectionString);
                conn.Open();
                MessageBox.Show("conectado");
            }
            catch (Exception e)
            {   //quitar

                MessageBox.Show(e.Message);
            }
            return conn;
        }

        public void desconectar()
        {
            String xd = "xd";
            try
            {   //caambiaar
                conn.Close();
                MessageBox.Show("Desconectado");
            }
            catch (Exception e)
            {   //quitar

                MessageBox.Show(e.Message);
            }
            //return conn;
        }
    }
}

