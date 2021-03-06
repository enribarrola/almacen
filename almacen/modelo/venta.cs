using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almacen.modelo
{
    class venta
    { private int cod_venta;
        private int cod_cliente;
    private int idusuario;
        private int monto_tot;
        private DateTime fecha;

        public venta(int cod_venta, int cod_cliente, int idusuario, int monto_tot, DateTime fecha)
        {
            this.cod_venta = cod_venta;
            this.cod_cliente = cod_cliente;
            this.idusuario = idusuario;
            this.monto_tot = monto_tot;
            this.fecha = fecha;
        }

        public int Cod_venta { get => cod_venta; set => cod_venta = value; }
        public int Cod_cliente { get => cod_cliente; set => cod_cliente = value; }
        public int Idusuario { get => idusuario; set => idusuario = value; }
        public int Monto_tot { get => monto_tot; set => monto_tot = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
