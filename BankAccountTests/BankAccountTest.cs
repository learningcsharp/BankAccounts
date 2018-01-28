using System;
using BankAccount;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankAccountTests
{
    [TestClass]
    public class BankAccountTest
    {
        [TestMethod]
        public void CheckAddTransactions()
        {
            //Arrange
            int expectedNumberOfTransactions = 3;
            Account bankAccount = new Account("TestAccount");

            Transaction transaction1 = new Transaction("TEST", 1000);
            Transaction transaction2 = new Transaction("TEST", -800);
            Transaction transaction3 = new Transaction("TEST", 100);

            bankAccount.AddTransaction(transaction1);
            bankAccount.AddTransaction(transaction2);
            bankAccount.AddTransaction(transaction3);

            //Act
            int numberTransactions = bankAccount.Transactions.Count;

            //Assert
            Assert.AreEqual(expectedNumberOfTransactions, numberTransactions);
        }

        [TestMethod]
        public void CheckGetBalanceNoTransactions()
        {
            //Arrange
            decimal expectedBalance = 0;
            Account bankAccount = new Account("TestAccount");

            //Act
            decimal balance = bankAccount.GetCurrentBalance();

            //Assert
            Assert.AreEqual(expectedBalance, balance);
        }

        [TestMethod]
        public void CheckGetBalanceSingleTransaction()
        {
            //Arrange
            decimal expectedBalance = 100;
            Account bankAccount = new Account("TestAccount");
            Transaction transaction = new Transaction("TEST", 100);
            bankAccount.AddTransaction(transaction);

            //Act
            decimal balance = bankAccount.GetCurrentBalance();

            //Assert
            Assert.AreEqual(expectedBalance, balance);
        }

        [TestMethod]
        public void CheckGetBalanceMultipleTransactions()
        {
            //Arrange
            decimal expectedBalance = 300;
            Account bankAccount = new Account("TestAccount");

            Transaction transaction1 = new Transaction("TEST", 1000);
            Transaction transaction2 = new Transaction("TEST", -800);
            Transaction transaction3 = new Transaction("TEST", 100);

            bankAccount.AddTransaction(transaction1);
            bankAccount.AddTransaction(transaction2);
            bankAccount.AddTransaction(transaction3);

            //Act
            decimal balance = bankAccount.GetCurrentBalance();

            //Assert
            Assert.AreEqual(expectedBalance, balance);
        }

    }
}
