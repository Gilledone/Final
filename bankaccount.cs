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
    Balance = Balance + amount;
    Console.WriteLine(Balance);
  }

  public void CalculateInterest(){
    Console.WriteLine("This will calculate interest");
  }


  public virtual void Withdraw(decimal amount){
    if (Balance > amount){
      Balance = Balance - amount;
    }else{
       Console.WriteLine("Too poor lol");
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
       Console.WriteLine("State code should be 6 characters long");
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
        Console.WriteLine("Can't be negative");
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