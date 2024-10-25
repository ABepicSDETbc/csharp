using NUnit.Framework;
using SdetBootcampDay1.TestObjects;

namespace SdetBootcampDay1.Exercises
{
    [TestFixture]
    public class Exercises03
    {
        [Test]
        public void TryingToOverdrawOnASavingsAccountThrowsExpectedException()
        {
            /**
             * TODO: Create a new savings account and deposit 50.
             * Verify that attempting to withdraw 100 throws an ArgumentException
             * Also verify the exception message to be 'You cannot overdraw on a savings account'
             * Finally, verify that the account balance is unchanged (i.e., you still have $50)
             */

             // Creates a new account with type of Savings
            var account = new Account(AccountType.Savings);

            // Deposits 50 into the Savings account
            account.Deposit(50);

            // Throws an Argument Excecption when attempting to withdraw more than the account balance
            var aexp = Assert.Throws<ArgumentException>(() =>
            
            // Withdraw 100 from the savings account
            {
                account.Withdraw(100);
            });

            // Tests that the correct string is thrown when encountering this exception
            Assert.That(aexp.Message, Is.EqualTo("You cannot overdraw on a savings account"));
            
            // Tests that the account balance is still 50
            Assert.That(account.Balance, Is.EqualTo(50));
        }
    }
}
