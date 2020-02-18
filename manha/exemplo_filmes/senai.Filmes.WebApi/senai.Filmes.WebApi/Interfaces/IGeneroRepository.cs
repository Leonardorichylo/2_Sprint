using senai.Filmes.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Filmes.WebApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório Genero
    /// </summary>
    interface IGeneroRepository
    {
        /// <summary>
        /// Lista todos os gêneros
        /// </summary>
        /// <returns>Retorna uma lista de gêneros</returns>
        List<GeneroDomain> Listar();
        /// <summary>
        /// Cadastra um novo genero
        /// </summary>
        /// <param name="genero">Objeto genero que sera cadastrado</param>
        void Cadastrar(GeneroDomain genero);

        /// <summary>
        /// Deletar Genero
        /// </summary>
        /// <param name="id"></param>
        void Deletar(int id);

        /// <summary>
        /// Atualiza um genero existente
        /// </summary>
        /// <param name="genero">Objeto genero sera atualizado</param>
        void AtualizarIdCorpo(GeneroDomain genero);

        /// <summary>
        /// Atualiza um genero existente
        /// </summary>
        /// <param name="id">ID do genero que sera</param>
        /// <param name="genero"></param>
        void AtualizarIdUrl(int id, GeneroDomain genero);

       
    }
}
