#nullable enable
namespace Catalog.Entities
{
    public class DatabaseSettings
    {
        public string? ConnectionString { get; set; }

        public string? DatabaseName { get; set; }

        public string? BooksCollectionName { get; set; }
    }
}