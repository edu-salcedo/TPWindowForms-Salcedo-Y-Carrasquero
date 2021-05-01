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
    public partial class FormUpdate : Form
    {

        private Articulo articulo = null;
        public FormUpdate()
        {
            InitializeComponent();

        }

        public FormUpdate(Articulo arti)
        {
            InitializeComponent();
            articulo = arti;
        }
        private void FormUpdate_Load(object sender, EventArgs e)
        {
            MarcaNegosio marca = new MarcaNegosio();
            cbMarca.DataSource = marca.listar();    // llena el comno box con la lista de marcas
            cbMarca.ValueMember = "id";
            cbMarca.DisplayMember = "nombre";
            cbMarca.SelectedIndex = -1;

            CategoriaNegosio cat = new CategoriaNegosio();
            cbCategoria.DataSource = cat.listar();    // llena el comno box con la lista de categorias
            cbCategoria.ValueMember = "id";
            cbCategoria.DisplayMember = "nombre";
            cbCategoria.SelectedIndex = -1;

            if (articulo != null)
            {
                tbCodigo.Text = articulo.codigo;
                texNombre.Text = articulo.nombre;
                textDescripcion.Text = articulo.descripcion;
                tbImagen.Text = articulo.imagen;
                texPrecio.Text = Convert.ToString(articulo.precio);

                cbMarca.SelectedValue = articulo.marca.id;
                cbCategoria.SelectedValue = articulo.categoria.id;
            }    
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo arti = new Articulo();
            ArticuloNegosio darti = new ArticuloNegosio();
            arti.codigo = tbCodigo.Text;                // se asigna el codigo que ingreso en texbox
            arti.nombre = texNombre.Text;               //      "        nombre  "     "      "
            arti.descripcion = textDescripcion.Text;    //      "        descripcion   "     "      "
            arti.imagen = tbImagen.Text;
            arti.marca = (Marca)cbMarca.SelectedItem;
            arti.categoria = (Categoria)cbCategoria.SelectedItem;
            arti.precio = decimal.Parse(texPrecio.Text);

            if (arti.id == 0)
            {                                           // si el articulo no tiene un id es un articulo nuevo 
                darti.agregar(arti);                   //  se llama a la funcion agregar y se manda parametro articulo con los valores ingresados
            }
            else
            {
                darti.editar(arti);                    //se llama funcion etitar
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
