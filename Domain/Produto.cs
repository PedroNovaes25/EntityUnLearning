﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIConsole
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Categoria Categoria { get; set; }

        public virtual ICollection<ListaDeProduto> ListaDeProdutos { get; set ; } //relacionamento n para n c/ ListaDeProdutos
    }
}
