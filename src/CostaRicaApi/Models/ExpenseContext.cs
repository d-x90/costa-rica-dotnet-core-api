using Microsoft.EntityFrameworkCore;

namespace CostaRicaApi.Models {
    public class ExpenseContext : DbContext {

        public DbSet<Expense> Expenses { get; set; }

        public DbSet<User> Users { get; set; }

        public ExpenseContext(DbContextOptions<ExpenseContext> options) : base(options) {

        }
    }
}