namespace UpcastingAndDowncasting.Entities;

public abstract class Account
{
    public int Number { get; protected set; }
    public string Holder { get; protected set; }//proprietário da conta
    public double Balance { get; protected set; }//saldo

    public Account()
    {
    }
    
    public Account(int number, string holder, double balance)
    {
        Number = number;
        Holder = holder;
        Balance = balance;
    }

    public virtual void Withdraw(double amount)
    {
        Balance -= amount;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }
}