﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppBiblioteca.Models
{
    public class Aluno
    {

        public int AlunoId { get; set; }
        public string Nome { get; set; }
        public int Sexo { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public List <Requisicao> Requisisoes { get; set; }


    }
}