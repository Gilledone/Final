using System;

class BankAccount{
  private string accountNumber;
  protected decimal balance;
  private DateTime dateCreated;


  public BankAccount(){
    Console.WriteLine("Bank account constructor");
    DateCreated = DateTime.Now;
  }
  public void DisplayAccountInfo(){
    Console.WriteLine($"{AccountNumber}, {Name}, {Balance}");
  }

  public void Deposit(decimal amount){
    Console.WriteLine("Balance = " + Balance);
    Console.WriteLine("Enter amount to deposit:");
    var depositAmount = Console.ReadLine();
    int newDeposit = Convert.ToInt32(depositAmount);
    Balance = Balance + newDeposit;
    Console.WriteLine("New balance = " + Balance);
  }

  public void CalculateInterest(){
    Console.WriteLine("This will calculate interest");
    Console.WriteLine($"Beginning balance: {Balance}");
    Console.WriteLine("No interest rate");
  }


  public virtual void Withdraw(decimal amount){
    Console.WriteLine($"Withdrawing {amount}");
    if (Balance > amount){
      Balance = Balance - amount;
      Console.WriteLine($"Successfully withdrew {amount}, remaining balance {Balance}");
       }else{
       Console.WriteLine("Not enough funds");
  }
  }

  public BankAccount(string accnbr, string nizame, decimal bal){
    AccountNumber = accnbr;
    Name = nizame;
    Balance = bal;
    DateCreated = DateTime.Now;
  }

  public string AccountNumber {
    get {
    return accountNumber;
  } set {
      if (value.Length==6){
        accountNumber = value;
      }else{
       Console.WriteLine("Account should be 6 digits long");
      }
    }
  }

  public string Name { get; set; }

  public virtual decimal Balance { 
    get {
      return balance;
    } set {
      if (value >= 0){
      balance = value;
      }else{
        Console.WriteLine("Balance can't be negative");
      }
    }
  }

  public DateTime DateCreated { 
    get {
    return dateCreated;  
  } set {
    if (value <= DateTime.Now){
      dateCreated = value;
    }else{
      Console.WriteLine("Can't be future date");
    }
    }
  }


}