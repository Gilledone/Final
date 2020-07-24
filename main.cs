using System;

class MainClass {
  public static void Main (string[] args) {
    var account = new BankAccount();

    account.AccountNumber = "abcd";
    account.AccountNumber = "abdefgh";
    account.AccountNumber = "abcdef";
    Console.WriteLine(account.AccountNumber);
    account.Name = "Michael";
    Console.WriteLine(account.Name);

    account.Balance = -1;
    account.Balance = 2;
    Console.WriteLine(account.Balance);
    Console.WriteLine(account.DateCreated);
  }
}