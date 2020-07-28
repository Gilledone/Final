using System;

class MainClass {
  public static void Main (string[] args) {
    var account = new BankAccount();
    
    Console.WriteLine("Testing not enough digits:");
    account.AccountNumber = "1234";
    Console.WriteLine(" ");

    Console.WriteLine("Testing too many digits:");
    account.AccountNumber = "1234567";
    Console.WriteLine(" ");

    Console.WriteLine("Testing 6 digits:");
    account.AccountNumber = "123456";
    Console.WriteLine(account.AccountNumber);
    Console.WriteLine(" ");

    Console.WriteLine("Test account name:");
    account.Name = "Michael";
    Console.WriteLine(account.Name);
    Console.WriteLine(" ");

    Console.WriteLine("Test negative balance fail:");
    account.Balance = -1;
    Console.WriteLine(" ");

    Console.WriteLine("Test: display positive balance:");
    account.Balance = 2;
    Console.WriteLine(account.Balance);
    Console.WriteLine(" ");

    Console.WriteLine("Test future date fail:");
    account.DateCreated = new DateTime (2021, 1, 1, 0, 0, 0);
    Console.WriteLine(" ");

    Console.WriteLine("Test past date success:");
    account.DateCreated = new DateTime (2019, 1, 1, 0, 0, 0);
    Console.WriteLine(account.DateCreated);
    Console.WriteLine(" ");

    Console.WriteLine("Constructor noargs DateCreated:");
    var accountNoArgs = new BankAccount();
    Console.WriteLine(accountNoArgs.DateCreated);
    Console.WriteLine(" ");

    Console.WriteLine("Constructor 3args:");
    var account3Args = new BankAccount("123456", "Mark", 37.50m);
    Console.WriteLine(account3Args.AccountNumber);
    Console.WriteLine(account3Args.Name);
    Console.WriteLine(account3Args.Balance);
    Console.WriteLine(account3Args.DateCreated);
    Console.WriteLine(" ");

    Console.WriteLine("DisplayAccountInfo test:");
    var displayAccountInfo = new BankAccount("123123", "Mastercard", 10.21m);
    displayAccountInfo.DisplayAccountInfo();
    Console.WriteLine(" ");

    Console.WriteLine("Test Deposit:");
    var depositTest = new BankAccount();
    depositTest.Deposit(10.42m);
    Console.WriteLine(" ");

    Console.WriteLine("Test low balance fail:");
    var notEnoughMoney = new BankAccount();
    notEnoughMoney.Withdraw(10m);
    Console.WriteLine(" ");

    Console.WriteLine("Test fund withdrawal:");
    var withdrawEnoughMoney = new BankAccount("666666", "Jeff", 20m);
    Console.WriteLine("Your balance is " + withdrawEnoughMoney.Balance);
    withdrawEnoughMoney.Withdraw(10m);
    Console.WriteLine(" ");

    Console.WriteLine("Test interest calculator:");
    var calculateInterest = new BankAccount();
    calculateInterest.CalculateInterest();
    Console.WriteLine(" ");

    Console.WriteLine("Test can't be less than 2500:");
    var myFirstSavingsAccount = new SavingsAccount();
    myFirstSavingsAccount.Balance = 0m;
    Console.WriteLine(myFirstSavingsAccount.Balance);
    Console.WriteLine(" ");

    Console.WriteLine("Test savings account no arg:");
    var savingsAccount3args = new SavingsAccount("098763", "Paul", 2560m);
    Console.WriteLine(savingsAccount3args.AccountNumber);
    Console.WriteLine(savingsAccount3args.Name);
    Console.WriteLine(savingsAccount3args.Balance);
    Console.WriteLine(savingsAccount3args.DateCreated);
    Console.WriteLine(" ");

    Console.WriteLine("Test savings account 3 arg");
    var savingsAccountInterest = new SavingsAccount("098763", "Paul", 3000m);
    Console.WriteLine(savingsAccountInterest.AccountNumber);
    Console.WriteLine(savingsAccountInterest.Name);
    Console.WriteLine(savingsAccountInterest.Balance);
    Console.WriteLine(savingsAccountInterest.DateCreated);
    Console.WriteLine(" ");

    Console.WriteLine("Test savings account interest calculator");
    savingsAccountInterest.CalculateInterest();
    Console.WriteLine("");

    Console.WriteLine("Test savings account withdraw");
    savingsAccountInterest.Withdraw(20m);
    Console.WriteLine("");

    Console.WriteLine("Test savings account balance under 2500");
    savingsAccountInterest.Withdraw(4000m);
    Console.WriteLine("");



    Console.WriteLine("Test checking account no arg");
    var myFirstCheckingsAccount = new CheckingsAccount();
    myFirstCheckingsAccount.Balance = 0m;
    Console.WriteLine(myFirstCheckingsAccount.Balance);
    Console.WriteLine(" ");

    Console.WriteLine("Test checkings account 3 arg:");
    var checkingsAccount3args = new CheckingsAccount("583094", "Bob",3200m);
    Console.WriteLine(checkingsAccount3args.AccountNumber);
    Console.WriteLine(checkingsAccount3args.Name);
    Console.WriteLine(checkingsAccount3args.Balance);
    Console.WriteLine(checkingsAccount3args.DateCreated);
    Console.WriteLine(" ");

    Console.WriteLine("Testing check account added interest");
    checkingsAccount3args.CalculateInterest();
    Console.WriteLine(" ");

    Console.WriteLine("Testing checking account funds under 500 threshold");
    checkingsAccount3args.Withdraw(5000m);

  }
}