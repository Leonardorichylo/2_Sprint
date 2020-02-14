using senai.filmes.webapi.Domains;
using senai.filmes.webapi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai.filmes.webapi.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {
        
        private string StringConexao = "Data Source=N-1S-DEV-14\\SQLEXPRESS; initial catalog=Filmes; user Id=sa; pwd=sa@132";
        public List<GeneroDomain> Listar()
        {
            List<GeneroDomain> generos = new List<GeneroDomain>();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string query = "SELECT IdGenero, Nome From Genero";

                con.Open();

                SqlDataReader reader;

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    reader = cmd.ExecuteReader();

                    while (reader.Read() )
                    {
                        GeneroDomain genero = new GeneroDomain
                        {
                            IdGenero = Convert.ToInt32(reader[0]),
                            Nome = reader["Nome"].ToString()
                        };

                        generos.Add(genero);
                    }
                }
            }
            return generos;
        }
    }
}
