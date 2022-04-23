namespace LivrariaCSharpApi.Models
{
    public interface IBookStorageSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        string BooksCollectionName { get; set; }
    }
}
