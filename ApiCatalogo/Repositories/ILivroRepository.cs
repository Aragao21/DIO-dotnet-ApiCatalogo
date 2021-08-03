using ApiCatalogo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogo.Repositories
{
    public interface ILivroRepository : IDisposable
    {
        Task<List<Livro>> Obter(int pagina, int quantidade);
        Task<Livro> Obter(Guid id);
        Task<List<Livro>> Obter(string nome, string autor);
        Task Inserir(Livro livro);
        Task Atualizar(Livro livro);
        Task Remover(Guid id);
    }
}
