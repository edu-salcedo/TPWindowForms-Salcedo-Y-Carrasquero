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
                tbNombre.Text = articulo.nombre;
                tbDescripcion.Text = articulo.descripcion;
                tbImagen.Text = articulo.imagen;
                tbPrecio.Text = Convert.ToString(articulo.precio);

                cbMarca.SelectedValue = articulo.marca.id;
                cbCategoria.SelectedValue = articulo.categoria.id;
            }    
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (validarCampo())
            {
                if (articulo == null) articulo = new Articulo();

                ArticuloNegosio articuloNegosio = new ArticuloNegosio();
                articulo.codigo = tbCodigo.Text;                // se asigna el codigo que ingreso en texbox
                articulo.nombre = tbNombre.Text;               //      "        nombre  "     "      "
                articulo.descripcion = tbDescripcion.Text;    //      "        descripcion   "     "      "
                articulo.imagen = tbImagen.Text;
                articulo.marca = (Marca)cbMarca.SelectedItem;
                articulo.categoria = (Categoria)cbCategoria.SelectedItem;
                articulo.precio = decimal.Parse(tbPrecio.Text);

                if (articulo.id > 0)
                {                                           // si el articulo no tiene un id es un articulo nuevo 
                    articuloNegosio.editar(articulo);                  //se llama funcion etitar
                    MessageBox.Show("se edito el articulo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    articuloNegosio.agregar(articulo);                 //  se llama a la funcion agregar y se manda parametro articulo con los valores ingresados
                    MessageBox.Show("se agrego el articulo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validarCampo()
        {
            string mensaje = "este campo no puede estar vacio";

            if (tbCodigo.Text.Trim() == String.Empty) // si esta vacio 
            {
                errorProvider1.SetError(tbCodigo, mensaje);
                return false;
            }
            else
            {
                errorProvider1.SetError(tbCodigo, "");
            }
            if (tbNombre.Text.Trim() == String.Empty) // si esta vacio 
            {

                errorProvider1.SetError(tbNombre, mensaje);
                return false;
            }
            else
            {
                errorProvider1.SetError(tbNombre, "");
            }
            if (tbDescripcion.Text.Trim() == String.Empty) // si esta vacio 
            {

                errorProvider1.SetError(tbDescripcion, mensaje);
                return false;
            }
            else
            {
                errorProvider1.SetError(tbDescripcion, "");
            }
            if (cbMarca.SelectedIndex <= -1)
            {

                errorProvider1.SetError(cbMarca, mensaje);
                return false;
            }
            else
            {
                errorProvider1.SetError(cbMarca, "");

            }

            if (cbCategoria.SelectedIndex <= -1)
            {
                errorProvider1.SetError(cbCategoria, mensaje);
                return false;
            }
            else
            { errorProvider1.SetError(cbCategoria, ""); }

            decimal precio;
            if ((tbPrecio.Text.Trim() == String.Empty)|| !(decimal.TryParse(tbPrecio.Text,out precio))) // si esta vacio 
            {
                
                errorProvider1.SetError(tbPrecio, mensaje);
                return false;
            }
            else
            {
                errorProvider1.SetError(tbPrecio, "");
            }
            return true;
        }

       
    }
}
