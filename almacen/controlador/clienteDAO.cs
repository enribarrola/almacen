class clienteDAO : Ientidad<cliente>
{

    conexion2 conn = new conexion2();
    MySqlCommand stm = null;
    public bool actualizar(cliente obj)
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


    public bool agregar(cliente obj)
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

    public bool eliminar(cliente obj)
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