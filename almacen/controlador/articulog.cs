using System.Windows.Forms;
using almacen.modelo;
class articulog {
    articuloDAO obj = new articuloDAO();
    public void agregar(string nombre,  string descripcion, int precio_vent,
    float cantidad, string tipo_cant, int idtip_art)
    {
        if (obj.agregar(new articulo( nombre, descripcion,  precio_vent,     cantidad,  tipo_cant,  idtip_art)))
        {
            MessageBox.Show("Guardado correctamente ola bb", "Almacen", MessageBoxButtons.OK);

        }
        else
        {
            MessageBox.Show("tnemos errores wei llama a la policia porfavor", "Almacen", MessageBoxButtons.OK);
        }
    }
    public void actualizar(string nombre, string descripcion, int precio_vent,
    float cantidad, string tipo_cant, int idtip_art)
    {
        if (obj.actualizar(new articulo(nombre, descripcion, precio_vent, cantidad, tipo_cant, idtip_art)))
        {
            MessageBox.Show("Guardado correctamente ola bb", "Almacen", MessageBoxButtons.OK);

        }
        else
        {
            MessageBox.Show("tnemos errores wei llama a la policia porfavor", "Almacen", MessageBoxButtons.OK);
        }
    }

    public void eliminar(int cod_art)
    {
        if (obj.eliminar(new articulo(cod_art)))
        {
            MessageBox.Show("Guardado correctamente ola bb", "Almacen", MessageBoxButtons.OK);

        }
        else
        {
            MessageBox.Show("tnemos errores wei llama a la policia porfavor", "Almacen", MessageBoxButtons.OK);
        }
    }
}