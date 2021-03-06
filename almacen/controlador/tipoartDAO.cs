

using MySqlConnector;

class tipoartDAO : Ientidad<tipoart>
{
    conexion2 conn = new conexion2();

    public bool actualizar(tipoart obj)
    {
         MySqlCommand stm = null;

        /*    
            
            bool ban = false;
            try
            {


                stm = new ("UPDATE ndigital.articulo	SET idcategoria="+obj.idcategoria+", nombre='" + obj.nombre+"' WHERE idarticulo="+obj.idarticulo+";", conn.conectarPosgresSQL());

                stm.ExecuteNonQuery();
                conn.conectarPosgresSQL().Close();
                ban = true;
            }
            catch (NpgsqlException err)
            {
                MessageBox.Show("" + err);
            }
            return ban;*/

    }
   

    public bool agregar(tipoart obj)
    {
        throw new System.NotImplementedException();
    }

    public bool eliminar(tipoart cod)
    {
        throw new System.NotImplementedException();
    }

   
}
