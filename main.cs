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

    Console.WriteLine("Constructor noargs DateCreated");
    var accountNoArgs = new BankAccount();
    Console.WriteLine(accountNoArgs.DateCreated);

    var account3Args = new BankAccount("123456", "Dude", 37.50m);
    Console.WriteLine(account3Args.AccountNumber);
    Console.WriteLine(account3Args.Name);
    Console.WriteLine(account3Args.Balance);
    Console.WriteLine(account3Args.DateCreated);

    var displayAccountInfo = new BankAccount("123123", "Mastercard", 10.21m);
    displayAccountInfo.DisplayAccountInfo();

    var depositTest = new BankAccount();
    depositTest.Deposit(10.42m);

    var notEnoughMoney = new BankAccount();
    notEnoughMoney.Withdraw(10m);

    var withdrawEnoughMoney = new BankAccount("666666", "Blankman", 20m);
    withdrawEnoughMoney.Withdraw(10m);

    var calculateInterest = new BankAccount();
    calculateInterest.CalculateInterest();
    

    var myFirstSavingsAccount = new SavingsAccount();
    myFirstSavingsAccount.Balance = 0m;
    Console.WriteLine(myFirstSavingsAccount.Balance);

    var savingsAccount3args = new SavingsAccount("098763", "Paul", 2560m);
    Console.WriteLine(savingsAccount3args.AccountNumber);
    Console.WriteLine(savingsAccount3args.Name);
    Console.WriteLine(savingsAccount3args.Balance);
    Console.WriteLine(savingsAccount3args.DateCreated);

    var savingsAccountInterest = new SavingsAccount("098763", "Paul", 3000m);
    Console.WriteLine(savingsAccountInterest.AccountNumber);
    Console.WriteLine(savingsAccountInterest.Name);
    Console.WriteLine(savingsAccountInterest.Balance);
    Console.WriteLine(savingsAccountInterest.DateCreated);

    savingsAccountInterest.CalculateInterest();




  }
}