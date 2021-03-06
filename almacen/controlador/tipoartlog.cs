using System.Windows.Forms;

class tipoartlog
{
    tipoartDAO obj = new tipoartDAO();
    public void agregar( string cat_art)
    {
        if (obj.agregar(new tipoart(cat_art)))
        {
            MessageBox.Show("Guardado correctamente ola bb", "Almacen", MessageBoxButtons.OK);

        }
        else {
            MessageBox.Show("tnemos errores wei llama a la policia porfavor", "Almacen", MessageBoxButtons.OK);
        }
    }
    public void actualizar(int ideart, string cat_art)
    {
        if (obj.actualizar(new tipoart(ideart,cat_art)))
        {
            MessageBox.Show("Guardado correctamente ola bb", "Almacen", MessageBoxButtons.OK);

        }
        else
        {
            MessageBox.Show("tnemos errores wei llama a la policia porfavor", "Almacen", MessageBoxButtons.OK);
        }
    }

    public void eliminar(int ideart)
    {
        if (obj.eliminar(new tipoart(ideart)))
        {
            MessageBox.Show("Guardado correctamente ola bb", "Almacen", MessageBoxButtons.OK);

        }
        else
        {
            MessageBox.Show("tnemos errores wei llama a la policia porfavor", "Almacen", MessageBoxButtons.OK);
        }
    }

}