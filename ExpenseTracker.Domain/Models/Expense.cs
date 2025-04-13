namespace ExpenseTracker.Domain.Models;

public class Expense
{
    public int Id {get;set;}
    public string? Description {get;set;}

    public decimal Amount {get;set;}

    public string? Category {get;set;}

    public string? AccountName {get; set;}

    public DateTime Date {get; set;}

}
