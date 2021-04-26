using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negosio
{
    public class ArticuloNegosio
    {
        public List<Articulo> listar()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Articulo> lista = new List<Articulo>();

            conexion.ConnectionString = "data source=DESKTOP-8E98HER\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi ";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select A.Id idarti,A.Codigo, A.Nombre,A.Descripcion,A.ImagenUrl,M.Id idmarca,M.Descripcion marca ,C.Id idcat,C.Descripcion cat,A.Precio precio from ARTICULOS A ,MARCAS M, CATEGORIAS C where A.idmarca=M.id AND	A.IdCategoria=C.id";
            comando.Connection = conexion;

            conexion.Open();
            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                Articulo aux = new Articulo();
                aux.id = (int)lector["idarti"];
                aux.codigo = lector.GetString(1);
                aux.nombre = lector.GetString(2);
                aux.descripcion = lector.GetString(3);
                aux.imagen = (string)lector["ImagenUrl"];
                aux.marca = new Marca();
                aux.marca.nombre = (string)lector["marca"];
                aux.marca.id = (int)lector["idmarca"];
                aux.categoria = new Categoria();
                aux.categoria.nombre = (string)lector["cat"];
                aux.categoria.id = (int)lector["idcat"];
                aux.precio = (decimal)lector["precio"];


                lista.Add(aux);
            }
            conexion.Close();
            return lista;


        }
    }
}
