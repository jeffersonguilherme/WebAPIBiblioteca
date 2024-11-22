using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiBiblioteca.Data;
using WebApiBiblioteca.Dto.Livro;
using WebApiBiblioteca.Models;

namespace WebApiBiblioteca.Services.Livro {
    public class LivroService : ILivroInterface {

        private readonly AppDbContext _context;
        public LivroService(AppDbContext context) {
            _context = context;
        }
        public async Task<ResponseModel<LivroModel>> BuscarLivroPorId(int idLivro) {
            ResponseModel<LivroModel> resposta = new ResponseModel<LivroModel>();

            try {

                var livro = await _context.Livros.FirstOrDefaultAsync(livroBanco => livroBanco.Id == idLivro);

                if(livro == null) {
                    resposta.Mensagem = "Nenhum registro localizado!";
                    return resposta;
                }

                resposta.Dados = livro;
                resposta.Mensagem = "Livro Localizado";
                return resposta;

            }catch (Exception ex) {
                resposta.Mensagem = ex.Message;
                resposta.Status = false;
                return resposta;
            }
        }

        public Task<ResponseModel<LivroModel>> BuscarLivroPorIdAutor(int idAutor) {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<LivroModel>>> CriarLivro(LivroCriacaoDto livroCriacaoDto) {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<LivroModel>>> EditarAutor(LivroEdicaoDto livroEdicaoDto) {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<LivroModel>>> ExcluirLivro(int idLivro) {
            throw new NotImplementedException();
        }

        public async Task<ResponseModel<List<LivroModel>>> ListarLivros() {

            ResponseModel<List<LivroModel>> resposta = new ResponseModel<List<LivroModel>>();

            try {

                var livro = await _context.Livros.ToListAsync();

                resposta.Dados = livro;
                resposta.Mensagem = "Autor Localizado!";
                return resposta;

            } catch (Exception ex) {
                resposta.Mensagem = ex.Message;
                resposta.Status = false;
                return resposta;
            }
        }
    }
}
