using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almacen.modelo
{
    class usuario
    { private int Idusuario;
        private string username;
        private string pasword;
        private string nombre;
        private string apellido;

        public usuario(int idusuario, string username, string pasword, string nombre, string apellido)
        {
            Idusuario = idusuario;
            this.username = username;
            this.pasword = pasword;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public int Idusuario1 { get => Idusuario; set => Idusuario = value; }
        public string Username { get => username; set => username = value; }
        public string Pasword { get => pasword; set => pasword = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
    }
}
