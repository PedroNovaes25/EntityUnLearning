using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using UIConsole;
using Repositorio;

namespace Aplicacao
{
    public class ListaDeProdutosAplicacao
    {
        DbProdutoContext conexaoBd { get; set; }

        public ListaDeProdutosAplicacao()
        {
            conexaoBd = new DbProdutoContext();
        }

        public void Salvar(ListaDeProduto listaDeProduto)
        {
            listaDeProduto.Produtos =
                listaDeProduto.Produtos.Select(prod => conexaoBd.Produtos.FirstOrDefault(x => x.Id == prod.Id)).ToList();
            conexaoBd.ListaDeProdutos.Add(listaDeProduto);
            conexaoBd.SaveChanges();
        }
        public IEnumerable<ListaDeProduto> Listar()
        {
            return conexaoBd.ListaDeProdutos
                .Include(x => x.Produtos)
                .Include(x => x.Produtos.Select(c => c.Categoria))
                .ToList();
        }
        public void Alterar(ListaDeProduto listaDeProduto)
        {
            ListaDeProduto listaProduto = conexaoBd.ListaDeProdutos.Where(x => x.Id == listaDeProduto.Id).First();
            listaProduto.Produtos =
                listaDeProduto.Produtos.Select(prod => conexaoBd.Produtos.FirstOrDefault(x => x.Id == prod.Id)).ToList();
            listaProduto.Descricao = listaDeProduto.Descricao;
            conexaoBd.SaveChanges();
        }
        public void Excluir(int idLista)
        {
            ListaDeProduto listaExcluir = conexaoBd.ListaDeProdutos.Where(x => x.Id == idLista).First();
            listaExcluir.Produtos = null;
            conexaoBd.Set<ListaDeProduto>().Remove(listaExcluir);
            conexaoBd.SaveChanges();
        }
    }
}
