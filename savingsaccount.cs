using System;

class SavingsAccount : BankAccount {

    public SavingsAccount() : base()
  {
    Console.WriteLine("Savings Account Constructor");
  }

    public SavingsAccount(string _AccountNumber, string _Name, decimal _Balance) : base(_AccountNumber, _Name, _Balance)
  {
    Console.WriteLine("Savings account constructor 3args");
  }

  public override decimal Balance { 
    get {
      return balance;
    } set {
      if (value >= 2500){
      balance = value;
      }else{
        Console.WriteLine("Can't be less than 2500");
      }
    }
  }

  public void CalculateInterest(){
    Console.WriteLine($"Calculating 5% for savings account, balance: {Balance}");
    var interest = Balance * .05m;
    Console.WriteLine($"Calculated interest, interest: {interest}");
    Balance += interest;
    Console.WriteLine($"New balance {Balance}");
  }

  public override void Withdraw(decimal amount){
    Console.WriteLine($"Withdrawing {amount} from saving account with starting balance {Balance}");
    if (Balance - amount >= 2500){
      Console.WriteLine("Calling base class");
      base.Withdraw(amount);
      Console.WriteLine($"New balance: {Balance}");
    }else{
      Console.WriteLine("Insufficient balance");
    }
  }

  







}