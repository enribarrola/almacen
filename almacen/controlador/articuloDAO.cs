using almacen.controlador;
using MySqlConnector;
using System.Windows.Forms;

class articuloDAO : Ientidad<articulo> {

    conexion2 conn = new conexion2();
    MySqlCommand stm = null;
    public bool actualizar(articulo obj)
    {
        bool ban = false;
        try
        {
            stm = new MySqlCommand("aca", conn.conectar());

            stm.ExecuteNonQuery();
            conn.conectar().Close();
            ban = true;
        }
        catch (System.Exception e)
        {
            MessageBox.Show(e.Message);
        }
        return ban;

    }


    public bool agregar(articulo obj)
    {
        bool ban = false;
        try
        {
            stm = new MySqlCommand("aca", conn.conectar());

            stm.ExecuteNonQuery();
            conn.conectar().Close();
            ban = true;

        }
        catch (System.Exception e)
        {
            MessageBox.Show(e.Message);
        }
        return ban;
    }

    public bool eliminar(articulo obj)
    {
        bool ban = false;
        try
        {
            stm = new MySqlCommand("aca", conn.conectar());

            stm.ExecuteNonQuery();
            conn.conectar().Close();
            ban = true;
        }
        catch (System.Exception e)
        {
            MessageBox.Show(e.Message);
        }
        return ban;

    }
}