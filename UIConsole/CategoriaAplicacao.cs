using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIConsole
{
    public class CategoriaAplicacao
    {
        DbProdutoContext conexaoBd { get; set; }

        public CategoriaAplicacao() 
        {
            conexaoBd = new DbProdutoContext();
        }

        public void Salvar(Categoria categoria) 
        {
            conexaoBd.Categorias.Add(categoria);
            conexaoBd.SaveChanges();
        }
        public void Excluir(int categoriaId)
        {
            Categoria categoriaExcluir = conexaoBd.Categorias.Where(x => x.Id == categoriaId).First();
            conexaoBd.Categorias.Remove(categoriaExcluir);
            conexaoBd.SaveChanges();
        }
        public void Alterar(Categoria categoria)
        {
            Categoria categoriaAlterar = conexaoBd.Categorias.Where(x => x.Id == categoria.Id).First();
            categoriaAlterar.Descricao = categoria.Descricao;
            conexaoBd.SaveChanges();
        }
        public IEnumerable<Categoria> Listar()
        {
            return conexaoBd.Categorias.ToList();
        }
    }
}
