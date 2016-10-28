using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace Mlb5
{
    public class Mlb5DbConfiguration : DbConfiguration
    {
        public Mlb5DbConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
        }
    }
}