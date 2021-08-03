using ApiCatalogo.InputModel;
using ApiCatalogo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogo.Services
{
    public interface ILivroService : IDisposable
    {
        Task<List<LivroViewModel>> Obter(int pagina, int quantidade);
        Task<LivroViewModel> Obter(Guid id);
        Task<LivroViewModel> Inserir(LivroInputModel livro);
        Task Atualizar(Guid id, LivroInputModel livro);
        Task Atualizar(Guid id, double preco);
        Task Remover(Guid id);
    }
}
