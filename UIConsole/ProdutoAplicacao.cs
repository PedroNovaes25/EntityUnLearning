﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIConsole
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
            conexaoBd.Produtos.Add(produto);
            conexaoBd.SaveChanges();
        }

        public IEnumerable<Produto> Listar()
        {
            return conexaoBd.Produtos.ToList();
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
            conexaoBd.Produtos.Remove(produtoDelete);
            conexaoBd.SaveChanges();
        }
    }
}