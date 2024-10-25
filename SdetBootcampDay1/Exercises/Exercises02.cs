using NUnit.Framework;
using SdetBootcampDay1.TestObjects;

namespace SdetBootcampDay1.Exercises
{
    [TestFixture]
    public class Exercises02
    {
        /**
         * TODO: rewrite these three tests into a single, parameterized test.
         * You decide if you want to use [TestCase] or [TestCaseSource], but
         * I would like to know why you chose the option you chose afterwards.
         */
        [TestCase(1000, 500, 500, TestName = "Deposit 1000 then withdraw 500 equals 500")]
        [TestCase(1000, 1000, 0, TestName = "Deposit 1000 then withdraw 1000 equals 0")]
        [TestCase(2500, 1, 2499, TestName = "Deposit 2500 then withdraw 1 equals 2499")]
        public void SavingsAccount_DepositThenWithdraw_BalanceShouldBeUpdatedAccordingly
            (int amountToDeposit, int amountToWithdraw, int expectedBalance)
        {
            var account = new Account(AccountType.Savings);

            account.Deposit(amountToDeposit);
            account.Withdraw(amountToWithdraw);

            Assert.That(account.Balance, Is.EqualTo(expectedBalance));
        }
    }
}
