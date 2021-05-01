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
    public partial class FormPrincipal : Form
    {
        Articulo artiActual = new Articulo();
        List<Articulo> lista; //creo una lista golbal que me sirve para llenar la gridview con la lista total de articulos
        public FormPrincipal(string nom)
        {
            InitializeComponent();
            Saludo.Text += nom;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ArticuloNegosio arti = new ArticuloNegosio();
            lista = arti.listar();
            dgvlista.DataSource = lista;   // carga el datagridview  la lista de articulos
            dgvlista.Columns[0].Visible = false;
            dgvlista.Columns[3].Visible = false;    // ocultamos la columna 4 que contiene la descripcion del producto
            dgvlista.Columns[4].Visible = false;    // ocultamos la columna 4 que contiene la url de imagene
        }

        private void btnIvolver_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dgvlista_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
            artiActual = (Articulo)dgvlista.CurrentRow.DataBoundItem; // trae  el articulo de la fila seleccionada
            pbImagen.Load(artiActual.imagen);

            }
            catch
            {

            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            DetalleProducto detalle = new DetalleProducto(artiActual);
            detalle.ShowDialog();
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {

            List<Articulo> listafilro = lista.FindAll(x => x.nombre.ToUpper().Contains(tbfiltro.Text.ToUpper()) || x.marca.nombre.ToUpper().Contains(tbfiltro.Text.ToUpper()));
            dgvlista.DataSource = listafilro;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormUpdate editar = new FormUpdate();
            editar.ShowDialog();

            //     Articulo articulo;
            //articulo = (Articulo)dgvlista.CurrentRow.DataBoundItem;

            //FormUpdate modificar = new FormUpdate(articulo);
            //modificar.ShowDialog();
        }
    }
}
