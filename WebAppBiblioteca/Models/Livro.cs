using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppBiblioteca.Models
{
    public class Livro
    {
        public int LivroId { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categorias { get; set; }
        public string  Isbn { get; set; }
        public string  Titulo { get; set; }
        public decimal  Preco { get; set; }
        public DateTime  DataPlublicacao { get; set; }
        public int NumeroExemplares { get; set; }


        public List <Requisicao> Reqisisoes { get; set; }
        public List <Autor> Autores { get; set; }


    }
}