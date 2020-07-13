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
            //produt1.Id = 4;
            produt1.Nome = "Oleo de soja";
            produt1.Categoria = "Enlatados";

            //banco.Produtos.Add(produt1);
            //banco.SaveChanges();


            //List<Produto> produtosBanco = banco.Produtos.ToList();

            ProdutoAplicacao bancoConec = new ProdutoAplicacao();
            //bancoConec.Salvar(produt1);
            //bancoConec.Alterar(produt1);
            //bancoConec.Excluir(produt1.Id);


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

            foreach (var item2 in bancoConec.Listar())
            {
                Console.WriteLine(item2.Id + " - " + item2.Nome);
            }
        }
    }
}
