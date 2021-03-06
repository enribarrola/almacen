using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almacen.modelo
{
    class proveedor
    {   private int cod_prove;
        private string empresa ;
        private string nombre ;
        private string numero_tel;
        private string numero_cel ;
        private string correo ;
        private string direccion ;
        private string RUC;

        public proveedor(int cod_prove, string empresa, string nombre, string numero_tel, string numero_cel, string correo, string direccion, string rUC)
        {
            this.cod_prove = cod_prove;
            this.empresa = empresa;
            this.nombre = nombre;
            this.numero_tel = numero_tel;
            this.numero_cel = numero_cel;
            this.correo = correo;
            this.direccion = direccion;
            RUC = rUC;
        }

        public int Cod_prove { get => cod_prove; set => cod_prove = value; }
        public string Empresa { get => empresa; set => empresa = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Numero_tel { get => numero_tel; set => numero_tel = value; }
        public string Numero_cel { get => numero_cel; set => numero_cel = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string RUC1 { get => RUC; set => RUC = value; }
    }
}
