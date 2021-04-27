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
    public partial class Form2 : Form
    {
        public Form2(string nom)
        {
            InitializeComponent();
             Saludo.Text +=nom;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ArticuloNegosio arti = new ArticuloNegosio();
            dgvlista.DataSource = arti.listar();     // carga el datagridview  con la lista de articulos
            dgvlista.Columns[4].Visible = false;    // ocultamos la columna 4 que contiene la url de imagene
        }

        private void btnIvolver_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void dgvlista_SelectionChanged(object sender, EventArgs e)
        {

            Articulo arti = new Articulo();
             arti=(Articulo)dgvlista.CurrentRow.DataBoundItem; // trae  el articulo de la fila seleccionada
            pbImagen.Load(arti.imagen);
        }
    }
}
