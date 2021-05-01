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
            lbCodigo.Text = _arti.codigo;
            lbNombre.Text = _arti.nombre;
            lbDesc.Text = _arti.descripcion;
            lbCat.Text = _arti.categoria.nombre;
            lbMarca.Text = _arti.marca.nombre;
            lbPrecio.Text = Convert.ToString(_arti.precio);

            try
            {
                pbImag.Load(_arti.imagen);

            }
            catch
            {

            }

        }

        private void btnIVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            

            FormUpdate modificar = new FormUpdate(_arti);
            modificar.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
