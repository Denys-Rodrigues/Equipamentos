﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Equipamentos.Models
{
    public class Categoria
    {
        public long CategoriaID { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }   
}