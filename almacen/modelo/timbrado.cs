using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almacen.modelo
{
    class timbrado
    {   private int cod_timbrado;
        private int cod_factura;
        private DateTime fecha_desde;
        private DateTime fecha_hasta;
        private int sede;
        private int caja;

        public timbrado(int cod_timbrado, int cod_factura, DateTime fecha_desde, DateTime fecha_hasta, int sede, int caja)
        {
            this.cod_timbrado = cod_timbrado;
            this.cod_factura = cod_factura;
            this.fecha_desde = fecha_desde;
            this.fecha_hasta = fecha_hasta;
            this.sede = sede;
            this.caja = caja;
        }

        public int Cod_timbrado { get => cod_timbrado; set => cod_timbrado = value; }
        public int Cod_factura { get => cod_factura; set => cod_factura = value; }
        public DateTime Fecha_desde { get => fecha_desde; set => fecha_desde = value; }
        public DateTime Fecha_hasta { get => fecha_hasta; set => fecha_hasta = value; }
        public int Sede { get => sede; set => sede = value; }
        public int Caja { get => caja; set => caja = value; }
    }
}
