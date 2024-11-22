﻿using WebApiBiblioteca.Models;

namespace WebApiBiblioteca.Dto.Livro {
    public class LivroEdicaoDto {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public DateTime DatadePublicacao { get; set; }
        public AutorModel Autor { get; set; }
    }
}