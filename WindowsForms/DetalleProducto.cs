using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negosio;

namespace WindowsForms
{
    public partial class DetalleProducto : Form
    {
        Articulo _arti = new Articulo();
        public DetalleProducto(Articulo arti)
        {
            InitializeComponent();
            _arti = arti;
        }

        private void DetalleProducto_Load(object sender, EventArgs e)
        {
            label1.Text = _arti.nombre;

        }

    }
}
