public class Articulo {

    private int cod_art;
    private string nombre;
    private string descripcion;
    private int precio_vent;
    private float cantidad;
    private string tipo_cant;
    private int idtip_art;
    // no enccuentro  bigint
    private long cod_barras;
    private int iva;

    public Articulo(int cod_art, string nombre, string descripcion, int precio_vent, float cantidad, string tipo_cant, int idtip_art, long cod_barras, int iva)
    {
        this.cod_art = cod_art;
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.precio_vent = precio_vent;
        this.cantidad = cantidad;
        this.tipo_cant = tipo_cant;
        this.idtip_art = idtip_art;
        this.cod_barras = cod_barras;
        this.iva = iva;
    }

    public int Cod_art { get => cod_art; set => cod_art = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Precio_vent { get => precio_vent; set => precio_vent = value; }
    public float Cantidad { get => cantidad; set => cantidad = value; }
    public string Tipo_cant { get => tipo_cant; set => tipo_cant = value; }
    public int Idtip_art { get => idtip_art; set => idtip_art = value; }
    public long Cod_barras { get => cod_barras; set => cod_barras = value; }
    public int Iva { get => iva; set => iva = value; }
}