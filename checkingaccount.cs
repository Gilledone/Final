using System;

class CheckingsAccount : BankAccount {
  public CheckingsAccount() : base()
  {
    Console.WriteLine("Checkings Account Constructor");
  }

  public CheckingsAccount(string _AccountNumber, string _Name, decimal _Balance) : base(_AccountNumber, _Name, _Balance)
  {
    Console.WriteLine("Checkings account constructor 3args");
  }

  public override decimal Balance { 
    get {
      return balance;
    } set {
      if (value >= 500){
      balance = value;
      }else{
        Console.WriteLine("Can't be less than 500");
      }
    }
  }

  public void CalculateInterest(){
    Console.WriteLine($"Calculating .75% for savings account, balance: {Balance}");
    var interest = Balance * .075m;
    Console.WriteLine($"Calculated interest, interest: {interest}");
    Balance += interest;
    Console.WriteLine($"New balance {Balance}");
  }

  public override void Withdraw(decimal amount){
    Console.WriteLine($"Withdrawing {amount} from saving account with starting balance {Balance}");
    if (Balance - amount >= 500){
      Console.WriteLine("Calling base class");
      base.Withdraw(amount);
      Console.WriteLine($"New balance: {Balance}");
    }else{
      Console.WriteLine("Insufficient balance");
    }
  }
}