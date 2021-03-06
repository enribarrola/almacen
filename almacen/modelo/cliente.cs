using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almacen.modelo
{
    class cliente
    {
        private int cod_client;
        private int CI;
        private string nombre;
        private string apellidos;
        private string ruc;
        private int numero;
        private string direccion;

        public cliente(int cod_client, int cI, string nombre, string apellidos, string ruc, int numero, string direccion)
        {
            this.cod_client = cod_client;
            CI = cI;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.ruc = ruc;
            this.numero = numero;
            this.direccion = direccion;
        }

        public int Cod_client { get => cod_client; set => cod_client = value; }
        public int CI1 { get => CI; set => CI = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Ruc { get => ruc; set => ruc = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
