using System.ComponentModel.DataAnnotations;

namespace BudgetManager.Models
{
    public class AccountType
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please write a name for your account type")]
        public string? Name { get; set; }

        public int UserID { get; set; }

        [Required]
        public int Ranking { get; set; }
    }
}
