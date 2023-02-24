namespace CRUDwithMongoDB.Common.Models;

public class BookStoreDatabaseSettings
{
    public string ConnectionString { get; set; }
    public string DataBaseName { get; set; }
    public string BooksCollectionName { get; set; }
}