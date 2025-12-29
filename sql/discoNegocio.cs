using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace sql
{
    public class discoNegocio
    {
        public List<disco> Listar()
        {
            List<disco> discos = new List<disco>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "Server=.\\SQLEXPRESS01;Database=DISCOS_DB;trusted_connection=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Titulo, CantidadCanciones, UrlImagenTapa imagen, e.Descripcion estilo,te.Descripcion edicion from DISCOS d inner join ESTILOS e on d.IdEstilo=e.Id inner join TIPOSEDICION te on te.Id=d.IdTipoEdicion";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    disco aux = new disco();
                    aux.titulo = (string)lector["Titulo"];
                    aux.canciones = (int)lector["CantidadCanciones"];
                    aux.imagen = (string)lector["imagen"];
                    aux.edicion = new Edicion();
                    aux.edicion.descripcion = (string)lector["edicion"];
                    aux.estilo=new estilo();
                    aux.estilo.descripcion = (string)lector["estilo"];
                    discos.Add(aux);
                }
                conexion.Close();
                return discos;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
            
            
        }

    }
}
