

using almacen.controlador;
using MySqlConnector;
using System.Windows.Forms;

class tipoartDAO : Ientidad<tipoart>
{
    conexion2 conn = new conexion2();
    MySqlCommand stm = null;
    public bool actualizar(tipoart obj)
    {                            
            bool ban = false;
            try
            {
                stm = new MySqlCommand("UPDATE `tipo_articulo` SET `categoria_articulo`= '"+obj.Cat_art+ "' WHERE id_tipo_articulo = " + obj.Idtipoart+"", conn.conectar());

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
   

    public bool agregar(tipoart obj)
    {
        bool ban = false;
        try
        {
            stm = new MySqlCommand("INSERT INTO `tipo_articulo`(`categoria_articulo`) VALUES ('" + obj.Cat_art + "')", conn.conectar());

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

    public bool eliminar(tipoart obj)
    {
        bool ban = false;
        try
        {
            stm = new MySqlCommand("DELETE FROM `tipo_articulo` WHERE id_tipo_articulo = "+obj.Idtipoart+";", conn.conectar());

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
