using BudgetManager.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BudgetManager.Services
{
    public class AccountTypeRepository : IAccountTypeRepository
    {
        private readonly string connectionString;

        public AccountTypeRepository(IConfiguration configuration) 
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task Create(AccountType accountType)
        {
            using var connection = new SqlConnection(connectionString);

            var id = await connection.QuerySingleAsync<int>($@"INSERT INTO AccountType(Name, UserID, Ranking)
                                                    VALUES (@Name, @UserID, @Ranking);
                                                    SELECT SCOPE_IDENTITY();", accountType);

            accountType.Id = id;
        }
    }
}
