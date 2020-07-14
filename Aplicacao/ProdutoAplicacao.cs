using Repositorio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIConsole;

namespace Aplicacao
{
    public class ProdutoAplicacao
    {
        public DbProdutoContext conexaoBd { get; set; }

        public ProdutoAplicacao()
        {
            conexaoBd = new DbProdutoContext();
        }

        public void Salvar(Produto produto)
        {
            produto.Categoria = conexaoBd.Categorias.ToList().Where(x => x.Id == produto.Categoria.Id).FirstOrDefault();
            conexaoBd.Produtos.Add(produto);
            conexaoBd.SaveChanges();
        }

        public IEnumerable<Produto> Listar()
        {
            return conexaoBd.Produtos.Include(x => x.Categoria).ToList();
        }

        public void Alterar(Produto produto)
        {
            Produto produtoSalvar = conexaoBd.Produtos.Where(x => x.Id == produto.Id).First();
            produtoSalvar.Nome = produto.Nome;
            conexaoBd.SaveChanges();
        }

        public void Excluir(int id)
        {
            Produto produtoDelete = conexaoBd.Produtos.Where(x => x.Id == id).First();
            conexaoBd.Set<Produto>().Remove(produtoDelete);
            conexaoBd.SaveChanges();
        }
    }
}
