using System;

public class comprasDAO :Ientidad<compras>
{
    conexion2 conn = new conexion2();
    MySqlCommand stm = null;
    public bool actualizar(compras obj)
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


    public bool agregar(compras obj)
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

    public bool eliminar(compras obj)
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
