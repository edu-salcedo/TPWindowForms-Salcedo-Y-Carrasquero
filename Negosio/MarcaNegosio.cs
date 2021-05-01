﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negosio
{
    public class MarcaNegosio
    {
        public List<Marca> listar()
        {

            List<Marca> lista = new List<Marca>();
            AccesoDatos conexion = new AccesoDatos();
            conexion.conectar();
            conexion.setearQuery("select id, Descripcion from Marcas");
            SqlDataReader lector = conexion.leer();

            while (lector.Read())
            {
                lista.Add(new Marca((int)lector["id"], (string)lector["Descripcion"]));
            }
            conexion.cerrarConexion();
            return lista;
        }
    }
}
