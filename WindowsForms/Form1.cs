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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegosio arti = new ArticuloNegosio();
            dgvlista.DataSource = arti.listar();  // carga el datagridview  con la lista de articulos
            dgvlista.Columns[4].Visible = false;    // ocultamos la columna 4 que contiene la url de imagenes

        }
    }
}
