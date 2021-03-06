using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almacen.modelo
{
    class cierre_de_caja
    { private int id_ventdia;
        private int total_dia;
        private int idusuario;
        private int cant_ventas;
        //nose si esta bien xd

        private DateTime fecha;

        public cierre_de_caja(int id_ventdia, int total_dia, int idusuario, int cant_ventas, DateTime fecha)
        {
            this.Id_ventdia = id_ventdia;
            this.Total_dia = total_dia;
            this.Idusuario = idusuario;
            this.Cant_ventas = cant_ventas;
            this.Fecha = fecha;
        }

        public int Id_ventdia { get => id_ventdia; set => id_ventdia = value; }
        public int Total_dia { get => total_dia; set => total_dia = value; }
        public int Idusuario { get => idusuario; set => idusuario = value; }
        public int Cant_ventas { get => cant_ventas; set => cant_ventas = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
