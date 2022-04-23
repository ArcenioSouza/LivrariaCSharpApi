namespace LivrariaCSharpApi.Models
{
    public class BooksStoreDatabaseSettings : IBookStorageSettings
    {
        string IBookStorageSettings.ConnectionString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IBookStorageSettings.DatabaseName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IBookStorageSettings.BooksCollectionName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
