namespace UpcastingAndDowncasting.Entities;

public class BusinessAcount:Account
{
    private double LoanLimit { get; set; }//Limite de empréstimo

    public BusinessAcount()
    {
    }

    public BusinessAcount(int number, string holder, double balance,double loanLimit)
        : base(number, holder, balance)
    {
        LoanLimit = loanLimit;
    }

    public void Loan(double amount)//Empréstimo
    {
        if(amount <= LoanLimit)
            Balance += amount;
    }
    
}