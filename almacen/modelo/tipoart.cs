public class tipoart {
    private int idtipoart;
    private string cat_art;

    public tipoart(string cat_art)
    {
        this.cat_art = cat_art;
    }

    public tipoart(int ideart)
    {
        this.idtipoart = ideart;
    }

    public tipoart(int idtipoart, string cat_art)
    {
        this.idtipoart = idtipoart;
        this.cat_art = cat_art;
    }

    public int Idtipoart { get => idtipoart; set => idtipoart = value; }
    public string Cat_art { get => cat_art; set => cat_art = value; }
}