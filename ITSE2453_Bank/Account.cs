using System;

namespace ITSE2453_Bank
{
    /// <summary>
    /// Abstract Account class that the Checking and Savings account will inherit from. 
    /// </summary>
    /// <remarks>
    /// This class represents a basic Bank Account. It has methods that represent various transactions that might be performed on a Bank Account.
    /// </remarks>
    [Serializable]
    public abstract class Account
    {
        //The number associated with an account.
        private int accountID;
        // The dollar amount present in the account.
        private decimal balance;
        /// <summary>
        /// Account ID property.</summary>
        /// <value>
        /// Integer, increments as accounts are added.</value>
        public int AccountID
        {
            get
            {
                return accountID;
            }
            set
            {
                accountID = value;
            }
        }
        /// <summary>
        /// Balance of account property.</summary>
        /// <value>
        /// Decimal, initial balance must be $300 or greater.</value>
        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if(value < 300)
                {
                    InitBalExc ibe = new InitBalExc();
                    throw (ibe);
                }
                balance = value;
            }
        }
        /// <summary>
        /// Constructor, sets the Account ID and initial Balance.</summary>
        /// <param name="id">number associated with account</param>
        /// <param name="bal">the Balance of the Account</param>
        public Account (int id, decimal bal)
        {
            if (id < 20)
            {
                AccountID = id;
                Balance = bal;
            }
            else
            {
                WrongIDExc wie = new WrongIDExc();
                throw (wie);
            }
        }
        /// <summary>
        /// This method adds the amt to the Balance.</summary>
        /// <param name="amt">decimal amount to be added</param>
        public void deposit(decimal amt)
        {
            if (amt > 0)
            {
                this.balance += amt;
            }
        }
        /// <summary>
        /// This method subtracts the amt from the Balance</summary>
        /// <param name="amt">decimal amount to be subtracted</param>
        public void withdraw(decimal amt)
        {
            if (amt > 0 && (this.balance >= amt))
            {
                this.balance -= amt;
            }
            else
            {
                WithDrawExc wde = new WithDrawExc();
                throw (wde);
            }
        }

        public abstract void closeMonth();

    }
    /// <summary>
    /// Inherits from Abstract Account class.
    /// </summary>
    /// <remarks>
    /// This class adds an interest rate that accumulates monthly through the closeMonth method. ToString is also overriden to report the balance.
    /// </remarks>
    [Serializable]
    class Savings : Account
    {
        // GUI senior citizen checkbox.checked or not
        private bool senior;
        // Interest rate for everyone
        private const decimal RATE = 0.015M;
        // Interest rate for seniors
        private const decimal SEN_RATE = 0.02M;
        /// <summary>
        /// Constructor, checks true or false from senior citizen checkbox
        /// </summary>
        /// <param name="id">number associated with account</param>
        /// <param name="bal">account initial balance</param>
        /// <param name="sen">bool from senior citizen checkbox</param>
        public Savings(int id, decimal bal, bool sen = false) : base(id, bal)
        {
            senior = sen;
        }
        /// <summary>
        /// End of the month method that deposits interest to account
        /// </summary>
        public override void closeMonth()
        {
            if(Balance >= 2500)
            {
                if(senior)
                {
                    this.deposit(Balance * SEN_RATE);
                }
                else
                {
                    this.deposit(Balance * RATE);
                }
            }
        }

        public override string ToString()
        {
            return "Savings Account #" + base.AccountID + " has a balance of $" + base.Balance + ".";
        }
    }

    [Serializable]
    class Checking : Account
    {
        // GUI college student checkbox.checked or not
        private bool college;
        // Monthly fee applied to accounts 
        private const decimal FEE = 6.95M;
        // Monthly fee applied to college student accounts
        private const decimal COL_FEE = 3.95M;
        /// <summary>
        /// Constructor, checks true or false from college student checkbox
        /// </summary>
        /// <param name="id">number associated with account</param>
        /// <param name="bal">initial balance of account</param>
        /// <param name="coll">bool from college student checkbox</param>
        public Checking(int id, decimal bal, bool coll = false) : base(id, bal)
        {
            college = coll;
        }
        /// <summary>
        /// End of the month method that withdraws monthly fee from account
        /// </summary>
        public override void closeMonth()
        {
            if(Balance < 1500)
            {
                if(college)
                {
                    this.withdraw(COL_FEE);
                }
                else
                {
                    this.withdraw(FEE);
                }
            }
        }

        public override string ToString()
        {
            return "Checking Account #" + base.AccountID + " has a balance of $" + base.Balance + ".";
        }
    }
}
