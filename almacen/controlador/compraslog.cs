class compraslog
{
    comprasDAO obj = new comprasDAO();
    public void agregar(Datetime fecha, int cod_prov, int monto)
    {
        if (obj.agregar(new compras(fecha,  cod_prov,  monto)))
        {
            MessageBox.Show("Guardado correctamente ola bb", "Almacen", MessageBoxButtons.OK);

        }
        else
        {
            MessageBox.Show("tnemos errores wei llama a la policia porfavor", "Almacen", MessageBoxButtons.OK);
        }
    }
    public void actualizar(int cod_compras, Datetime fecha, int cod_prov, int monto)
    {
        if (obj.actualizar(new compras(cod_compras,  fecha,  cod_prov,  monto)))
        {
            MessageBox.Show("Guardado correctamente ola bb", "Almacen", MessageBoxButtons.OK);

        }
        else
        {
            MessageBox.Show("tnemos errores wei llama a la policia porfavor", "Almacen", MessageBoxButtons.OK);
        }
    }

    public void eliminar(int cod_compras)
    {
        if (obj.eliminar(new compras(cod_compras)))
        {
            MessageBox.Show("Guardado correctamente ola bb", "Almacen", MessageBoxButtons.OK);

        }
        else
        {
            MessageBox.Show("tnemos errores wei llama a la policia porfavor", "Almacen", MessageBoxButtons.OK);
        }
    }

}