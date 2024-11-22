using WebApiBiblioteca.Models;

namespace WebApiBiblioteca.Dto.Livro {
    public class LivroCriacaoDto {
        public string? Titulo { get; set; }
        public DateTime DatadePublicacao { get; set; }
        public AutorModel Autor { get; set; }
    }
}
