﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIConsole
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public virtual IEnumerable<Produto> Produtos { get; set; } //uma categorias possui vários Produtos (1 para n) : obs((Proprideda Navegação))
    }
}
