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
        public SqlCommand comando { set;get; }
        public List<Articulo> listar()
        {
            
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos conexion = new AccesoDatos();
            conexion.conectar();
            conexion.setearQuery( "select A.Id idarti,A.Codigo, A.Nombre,A.Descripcion,A.ImagenUrl,M.Id idmarca,M.Descripcion marca ,C.Id idcat,C.Descripcion cat,A.Precio precio from ARTICULOS A ,MARCAS M, CATEGORIAS C where A.idmarca=M.id AND	A.IdCategoria=C.id");
            SqlDataReader lector = conexion.leer();

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
            conexion.cerrarConexion();
            return lista;


        }
    }
}
