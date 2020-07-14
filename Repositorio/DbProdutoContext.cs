using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIConsole;

namespace Repositorio
{
    public class DbProdutoContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<ListaDeProduto> ListaDeProdutos { get; set; }
    }
}
