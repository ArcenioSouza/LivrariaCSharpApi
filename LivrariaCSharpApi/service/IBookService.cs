using LivrariaCSharpApi.Models;

namespace LivrariaCSharpApi.service
{
    public interface IBookService
    {
        List<Livros> Get();
        Livros Get(string id);
        Livros Create(Livros livro);
        void Update(string id, Livros livro);
        void Delete(string id);
    }
}
