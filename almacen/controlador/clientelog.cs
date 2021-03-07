class clientelog {
    clienteDAO obj = new clienteDAO();
    public void agregar( int cod_client,
     int CI, string nombre, string apellidos, string ruc, int numero,string direccion)
    {
        if (obj.agregar(new cliente(cod_client,CI,  nombre,  apellidos,  ruc,  numero,  direccion)))
        {
            MessageBox.Show("Guardado correctamente ola bb", "Almacen", MessageBoxButtons.OK);

        }
        else
        {
            MessageBox.Show("tnemos errores wei llama a la policia porfavor", "Almacen", MessageBoxButtons.OK);
        }
    }
    public void actualizar(int cod_client,
     int CI, string nombre, string apellidos, string ruc, int numero, string direccion)
    {
        if (obj.actualizar(new cliente(cod_client, CI, nombre, apellidos, ruc, numero, direccion)))
        {
            MessageBox.Show("Guardado correctamente ola bb", "Almacen", MessageBoxButtons.OK);

        }
        else
        {
            MessageBox.Show("tnemos errores wei llama a la policia porfavor", "Almacen", MessageBoxButtons.OK);
        }
    }

    public void eliminar(int cod_client)
    {
        if (obj.eliminar(new cliente(cod_client)))
        {
            MessageBox.Show("Guardado correctamente ola bb", "Almacen", MessageBoxButtons.OK);

        }
        else
        {
            MessageBox.Show("tnemos errores wei llama a la policia porfavor", "Almacen", MessageBoxButtons.OK);
        }
    }

}