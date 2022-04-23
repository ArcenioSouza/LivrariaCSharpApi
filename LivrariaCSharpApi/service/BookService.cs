using LivrariaCSharpApi.Models;
using MongoDB.Driver;

namespace LivrariaCSharpApi.service
{
    public class BookService : IBookService
    {
        private readonly IMongoCollection<Livros> _books;

        public BookService(IBookStorageSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _books = database.GetCollection<Livros>(settings.BooksCollectionName);
        }
        public Livros Create(Livros livro)
        {
            _books.InsertOne(livro);
            return livro;
        }

        public void Delete(string id)
        {
            _books.DeleteOne(livro => livro.Id == id);
        }

        public List<Livros> Get()
        {
            return _books.Find(livro => true).ToList();
        }

        public Livros Get(string id)
        {
            return _books.Find(livro => livro.Id == id).FirstOrDefault();
        }

        public void Update(string id, Livros livro)
        {
            _books.ReplaceOne(livro => livro.Id == id, livro);
        }
    }
}
