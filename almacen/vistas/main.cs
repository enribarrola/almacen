using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using almacen.controlador;

namespace almacen
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
             tipoartlog obj  =  new tipoartlog();
             obj.agregar("gaseosas");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tipoartlog obj = new tipoartlog();
            obj.eliminar(1);
        }
    }
}
