using ModelProject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerProject
{
    public class GeneroController
    {
        public void addGeneroToDB(Genero genero)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "insert into tbGeneros(generoDesc) values (@generoDesc)";
            command.Parameters.AddWithValue("@generoDesc", genero.generoDesc);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void deleteGeneroFromDB(Genero genero)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "delete from tbGeneros where idGenero = @idGenero";
            command.Parameters.AddWithValue("@idGenero", genero.idGenero);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void updateGeneroFromDB(Genero genero)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE tbGeneros SET generoDesc=@generoDesc WHERE idGenero=@idGenero";
            command.Parameters.AddWithValue("@idGenero", genero.idGenero);
            command.Parameters.AddWithValue("@generoDesc", genero.generoDesc);
            command.ExecuteNonQuery();
            conn.Close();
        }

        

        

    }
}
