using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogo.ViewModel
{
    public class LivroViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; } // Produtora
        public double Preco { get; set; }
    }
}
