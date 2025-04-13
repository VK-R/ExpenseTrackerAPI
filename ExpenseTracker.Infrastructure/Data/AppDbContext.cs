using Microsoft.EntityFrameworkCore;
using ExpenseTracker.Domain.Models;

namespace ExpenseTracker.Infrastructure.Data;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    public DbSet<Expense> Expenses {get;set;}
    
}
