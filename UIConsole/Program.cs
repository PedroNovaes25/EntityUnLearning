using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //DbProdutoContext banco = new DbProdutoContext();
            Produto produt1 = new Produto();
            Categoria cat1 = new Categoria();
            //cat1.Descricao = "Bebida";

            //produt1.Nome = "Oleo de soja";
            //produt1.Id
            cat1.Descricao = "Limpeza   ";

            //banco.Produtos.Add(produt1);
            //banco.SaveChanges();


            //List<Produto> produtosBanco = banco.Produtos.ToList();

            CategoriaAplicacao bancoCat = new CategoriaAplicacao();
            ProdutoAplicacao bancoProd = new ProdutoAplicacao();
            //bancoCat.Salvar(cat1);
            produt1.Nome = "Detergente";
            //produt1.Id = 9;
            produt1.Categoria = bancoCat.Listar().Where(x => x.Id == 7).FirstOrDefault();

            //bancoConec.Salvar(produt1);
            //bancoConec.Alterar(produt1);
            //bancoConec.Excluir(produt1.Id);
            //bancoCat.Salvar(cat1);
            bancoProd.Salvar(produt1);





            //var teste = produtosBanco.First().Id;

            #region #CodigoQueFizParaTeste
            //foreach (var item in bancoConec.Listar())
            //{

            //    if (item.Id > 1 && item.Nome == "Arroz") 

            //    {
            //        Produto produtoSalvar = banco.Produtos.Where(x => x.Id == item.Id).First();
            //        banco.Produtos.Remove(produtoSalvar);
            //        banco.SaveChanges();
            //    }



            //    //Console.WriteLine(item.Id + " - " + item.Nome);
            //}

            #endregion

            foreach (var item2 in bancoCat.Listar())
            {
                //Console.WriteLine( item2.Id + " - "+  item2.Descricao);
            }

            foreach (var item2 in bancoProd.Listar())
            {
                Console.WriteLine(item2.Id + " " + item2.Nome + " - " + item2.Categoria.Descricao);
            }
        }
    }
}
