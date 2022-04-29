

namespace DataAccess.SQLClient
{
    public class Client
    {
        public string GetStringConnection()
        {
            var stringConnection = "server=(localdb)\\MSSQLLocalDb;database=StudentsDB;Trusted_Connection=true";
            return stringConnection;
        }
    }
}
