using almacen.controlador;
using MySqlConnector;
using System.Windows.Forms;

class cierre_de_cajaDAO : Ientidad<cierre_de_caja> {

    conexion2 conn = new conexion2();
    MySqlCommand stm = null;
    public bool actualizar(cierre_de_caja obj)
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


    public bool agregar(cierre_de_caja obj)
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

    public bool eliminar(cierre_de_caja obj)
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