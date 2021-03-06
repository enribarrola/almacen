using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almacen.modelo
{
    class compras
    {
        private int cod_compras;
        //este nose 
        private DateTime fecha_compra;
        private int cod_proveedor;
        private int monto;

        public compras(int cod_compras, DateTime fecha_compra, int cod_proveedor, int monto)
        {
            this.cod_compras = cod_compras;
            this.fecha_compra = fecha_compra;
            this.cod_proveedor = cod_proveedor;
            this.monto = monto;
        }

        public int Cod_compras { get => cod_compras; set => cod_compras = value; }
        public DateTime Fecha_compra { get => fecha_compra; set => fecha_compra = value; }
        public int Cod_proveedor { get => cod_proveedor; set => cod_proveedor = value; }
        public int Monto { get => monto; set => monto = value; }
    }
}
