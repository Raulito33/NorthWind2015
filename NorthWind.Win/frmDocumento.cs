using NorthWind.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWind.Win
{
    public partial class frmDocumento : Form
    {
        public frmDocumento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton mostrar formulario Cliente
            frmCliente frmCliente = new frmCliente();
            frmCliente.OnClienteSeleccionado += new EventHandler<Entity.TbClienteBE>(MetodoCliente);
            frmCliente.Show();
        }

        TbClienteBE otmpCliente; //Variable temporal

        void MetoCliente(object sender, TbClienteBE e)
        { 
            txtcliente.Text = e.Nombre;
            txtruc.Text = e.Apellido;
            otmpCliente = e;
        }
    }
}
