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
    Console.WriteLine("Interest override");
    var interestAdded = Balance * .05m;
    Console.WriteLine("Added interest and updated balance");
    Balance += interestAdded;
  }

  







}