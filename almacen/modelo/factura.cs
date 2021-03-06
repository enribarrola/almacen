using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almacen.modelo
{
    class factura
    { private int cod_fact;
        private int cod_venta;
        private DateTime fecha;
        private int numero_fact;
        private int anulado;

        public factura(int cod_fact, int cod_venta, DateTime fecha, int numero_fact, int anulado)
        {
            this.Cod_fact = cod_fact;
            this.Cod_venta = cod_venta;
            this.Fecha = fecha;
            this.Numero_fact = numero_fact;
            this.Anulado = anulado;
        }

        public int Cod_fact { get => cod_fact; set => cod_fact = value; }
        public int Cod_venta { get => cod_venta; set => cod_venta = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Numero_fact { get => numero_fact; set => numero_fact = value; }
        public int Anulado { get => anulado; set => anulado = value; }
    }
}
