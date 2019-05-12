using System.Data.Entity;

namespace Wedding_Website.Models
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<Wedding_DataEntities>
    {
    }
}