using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogo.Entities
{
    public class Livro
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; } // Produtora
        public double Preco { get; set; }
    }
}
