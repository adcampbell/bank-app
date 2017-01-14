using System;

namespace ITSE2453_Bank
{
    /// <summary>
    /// If the initial balance does not meet the $300 minimum this exception will print a message.
    /// </summary>
    class InitBalExc : Exception
    {
        private static string msg = "You must open an account with $300 minimum. Correct the amount field.";
        public InitBalExc() : base(msg)
        {
        }
    }
    /// <summary>
    /// If the user attempts to perform a transaction using incorrect input this exception will print a message.
    /// </summary> 
    class WrongIDExc : Exception
    {
        private static string msg = "You are attempting a transaction on an account that does not exist or are trying to exceed 19 accounts.";
        public WrongIDExc() : base(msg)
        {
        }
    }
    /// <summary>
    /// If the user attempts to input a negative balance this exception will print a message.
    /// </summary>
    class NegBalExc : Exception
    {
        private static string msg = "You cannot initiate a transaction with a negative balance in the amount field.";
        public NegBalExc() : base(msg)
        {
        }
    }
    /// <summary>
    /// If the user tries to overdraft the account this exception will print a message.
    /// </summary>
    class WithDrawExc : Exception
    {
        private static string msg = "You cannot withdraw more than you have in your account.";
        public WithDrawExc() : base(msg)
        {
        }
    }
}
