using System;
using System.Collections.Generic;

namespace StarterPlataform.Models
{
    public class Forum
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public Categoria Categoria { get; set; }
        public DateTime DataCriacao { get; set; }
        public List<Post> Posts { get; set; }
        public bool Status { get; set; }
    }
}