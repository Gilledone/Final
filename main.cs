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

    account.DateCreated = new DateTime (2021, 1, 1, 0, 0, 0);
    account.DateCreated = new DateTime (2019, 1, 1, 0, 0, 0);
    Console.WriteLine(account.DateCreated);
  }
}