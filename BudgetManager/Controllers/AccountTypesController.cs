using BudgetManager.Models;
using BudgetManager.Services;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data.Common;

namespace BudgetManager.Controllers
{
    public class AccountTypesController : Controller
    {
        private readonly IAccountTypeRepository accountTypeRepository;

        public AccountTypesController(IAccountTypeRepository accountTypeRepository) 
        {
            this.accountTypeRepository = accountTypeRepository;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AccountType accountType)
        {
            if (!ModelState.IsValid)
            {
                return View(accountType);
            }

            accountType.UserID = 1;
            accountType.Ranking = 2;

            await accountTypeRepository.Create(accountType);

            return View();
        }
    }
}
