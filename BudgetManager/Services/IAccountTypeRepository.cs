using BudgetManager.Models;

namespace BudgetManager.Services
{
    public interface IAccountTypeRepository
    {
        Task Create(AccountType accountType);
    }
}