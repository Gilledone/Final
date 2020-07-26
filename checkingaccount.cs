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
}