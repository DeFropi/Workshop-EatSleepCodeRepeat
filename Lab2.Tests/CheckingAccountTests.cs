using Microsoft.VisualStudio.TestTools.UnitTesting;
using eu.sig.training.ch04.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eu.sig.training.ch04.v1.Tests
{
    [TestClass()]
    public class CheckingAccountTests
    {
        [TestMethod()]
        [ExpectedException(typeof(BusinessException), "Invalid account number!")]
        public void makeTransferFailedTest()
        {
            var savingsAccount = new SavingsAccount();
            savingsAccount.makeTransfer("", new Money());
        }
        [ExpectedException(typeof(BusinessException), "Limit exceeded!")]
        public void makeTransferExceedLimitTest()
        {
            var savingsAccount = new SavingsAccount();
            savingsAccount.makeTransfer("", new Money());
        }
    }
}