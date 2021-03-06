using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almacen.modelo
{
    class compras_b_articulos
    {
        private int cod_comart;
        private int cod_compras;
        private int cod_art;
        private int cantidad;
        private int precio_compra;

        public compras_b_articulos(int cod_comart, int cod_compras, int cod_art, int cantidad, int precio_compra)
        {
            this.cod_comart = cod_comart;
            this.cod_compras = cod_compras;
            this.cod_art = cod_art;
            this.cantidad = cantidad;
            this.precio_compra = precio_compra;
        }

        public int Cod_comart { get => cod_comart; set => cod_comart = value; }
        public int Cod_compras { get => cod_compras; set => cod_compras = value; }
        public int Cod_art { get => cod_art; set => cod_art = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Precio_compra { get => precio_compra; set => precio_compra = value; }
    }
}
