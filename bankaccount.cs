using System;

class BankAccount{
  private string accountNumber;
  private decimal balance;

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

  public decimal Balance { 
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

  public DateTime DateCreated { get; set; }
  


}