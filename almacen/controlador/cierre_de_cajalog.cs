class cierre_de_cajalog{
    cierre_de_cajaDAO obj = new cierre_de_cajaDAO();
    public void agregar(  int total_dia, int idusuario,
    int cant_ventas, DateTime fecha)
    {
        if (obj.agregar(new cierre_de_caja(  total_dia,  idusuario,  cant_ventas,  fecha)))
        {
            MessageBox.Show("Guardado correctamente ola bb", "Almacen", MessageBoxButtons.OK);

        }
        else
        {
            MessageBox.Show("tnemos errores wei llama a la policia porfavor", "Almacen", MessageBoxButtons.OK);
        }
    }
    public void actualizar(int id_ventdia, int total_dia, int idusuario, int cant_ventas, DateTime fecha)
    {
        if (obj.actualizar(new cierre_de_caja(id_ventdia, total_dia, idusuario, cant_ventas, fecha)))
        {
            MessageBox.Show("Guardado correctamente ola bb", "Almacen", MessageBoxButtons.OK);

        }
        else
        {
            MessageBox.Show("tnemos errores wei llama a la policia porfavor", "Almacen", MessageBoxButtons.OK);
        }
    }

    public void eliminar(int id_ventdia)
    {
        if (obj.eliminar(new cierre_de_caja(id_ventdia)))
        {
            MessageBox.Show("Guardado correctamente ola bb", "Almacen", MessageBoxButtons.OK);

        }
        else
        {
            MessageBox.Show("tnemos errores wei llama a la policia porfavor", "Almacen", MessageBoxButtons.OK);
        }
    }
}