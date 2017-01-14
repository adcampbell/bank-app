using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ITSE2453_Bank
{
    public partial class bankForm : Form
    {
        // Filepath created in default directory
        const string FILENAME = "List_of_Accounts.txt";
        // Open BF for serializing account objects
        BinaryFormatter bFormat = new BinaryFormatter();
        // Declare list of Accounts globally
        List<Account> acctList = new List<Account>();

        public bankForm()
        { 
            InitializeComponent();          
            int count = 0;
            // Open serialized accounts file, read account objects back into program
            using (FileStream bankFile = new FileStream(FILENAME, FileMode.OpenOrCreate, FileAccess.Read))
            {
                while (bankFile.Position < bankFile.Length)
                {
                    var deserialize = (Account)bFormat.Deserialize(bankFile);
                    acctList.Add(deserialize);
                    count++;
                }
            }
            outLabel.ForeColor = Color.Blue;
            outLabel.Text = count + " objects loaded.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize a radio button to reduce errors
            checkingRadButton.Checked = true;
        }
        // Create Account button, initializes a new object and adds it to acctList
        private void accButton_Click(object sender, EventArgs e)
        {
            decimal tempBal = 0;
            FileStream bankFile = new FileStream(FILENAME, FileMode.Append, FileAccess.Write);
            try
            {
                // Get decimal from TextBox and add new appropriate Account object to list
                tempBal = decimal.Parse(amtTextBox.Text);
                // Check checkboxes for applicable rates
                if (checkingRadButton.Checked)
                {
                    if (collegeCheckBox.Checked)
                    {
                        acctList.Add(new Checking(acctList.Count + 1, tempBal, true));
                        bFormat.Serialize(bankFile, acctList[acctList.Count - 1]);
                    }
                    else
                    {
                        acctList.Add(new Checking(acctList.Count + 1, tempBal));
                        bFormat.Serialize(bankFile, acctList[acctList.Count - 1]);
                    }
                }
                else
                {
                    if (seniorCheckBox.Checked)
                    {
                        acctList.Add(new Savings(acctList.Count + 1, tempBal, true));
                        bFormat.Serialize(bankFile, acctList[acctList.Count - 1]);
                    }
                    else
                    {
                        acctList.Add(new Savings(acctList.Count + 1, tempBal));
                        bFormat.Serialize(bankFile, acctList[acctList.Count - 1]);
                    }
                }

                // Output text to user
                outLabel.ForeColor = Color.Green;
                outLabel.Text = "Account #" + acctList[acctList.Count - 1].AccountID + " has been opened with $" + acctList[acctList.Count - 1].Balance;
                accTextBox.Text = acctList[acctList.Count - 1].AccountID.ToString();

            }
            catch (FormatException ex)
            {
                outLabel.ForeColor = Color.Red;
                outLabel.Text = "A decimal must be entered in the Amount field.";
                Console.Write("The user input an incorrect value into the Account ID textbox.\n" + ex.Message);
            }
            catch (InitBalExc ex)
            {
                outLabel.ForeColor = Color.Red;
                outLabel.Text = ex.Message;
                Console.Write("The user has an incorrect amount in the balance textbox.\n" + ex.Message);
            }
            catch (WrongIDExc ex)
            {
                outLabel.ForeColor = Color.Red;
                outLabel.Text = ex.Message;
                Console.Write("The user has an incorrect ID number in the Account ID textbox.\n" + ex.Message);
            }
            bankFile.Dispose();
        }
        // Execute button; shows balance, withdraws, or deposits
        private void exeButton_Click(object sender, EventArgs e)
        {
            int tempID = 0;
            decimal tempBal= 0;
            
            try
            {
                // Collect proper values from textboxes
                tempID = int.Parse(accTextBox.Text);
                tempBal = decimal.Parse(amtTextBox.Text);
                checkText(tempID, tempBal);

                // See which radio button is selected, output transaction to label
                if (depRadio.Checked)
                {
                    acctList[tempID - 1].deposit(tempBal);
                    outLabel.ForeColor = Color.Green;
                    outLabel.Text = "Account #" + acctList[tempID - 1].AccountID + " has a new balance of $" + acctList[tempID - 1].Balance;
                    rewriteFile();                  
                }
                else if (withRadio.Checked)
                {
                    acctList[tempID - 1].withdraw(tempBal);
                    outLabel.ForeColor = Color.Green;
                    outLabel.Text = "Account #" + acctList[tempID - 1].AccountID + " has a new balance of $" + acctList[tempID - 1].Balance;
                    rewriteFile();
                }
                else if (balRadio.Checked)
                {
                    outLabel.ForeColor = Color.Green;
                    outLabel.Text = "Account #" + acctList[tempID - 1].AccountID + " has a balance of $" + acctList[tempID - 1].Balance;
                }
                else
                {
                    outLabel.ForeColor = Color.Red;
                    outLabel.Text = "You must select a radio button option to execute.";
                }
            }
            catch (Exception ex) when (ex is FormatException || ex is ArgumentOutOfRangeException)
            {
                outLabel.ForeColor = Color.Red;
                outLabel.Text = "A proper Account number must be entered in the ID field.";
                Console.Write("The user entered a non-number or entered a number not in the range of 1-20.\n" + ex.Message);
            }
            catch (Exception ex)
            {
                outLabel.ForeColor = Color.Red;
                outLabel.Text = ex.Message;
                Console.Write(ex.Message);
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // End of month button; applies end of the month changes to accounts
        private void endButton_Click(object sender, EventArgs e)
        {
            foreach(Account acct in acctList)
            {
                acct.closeMonth();
            }
            outLabel.ForeColor = Color.Green;
            outLabel.Text = "End of the month processing has completed.";
            rewriteFile();
        }
        // Report button; outputs all account balances
        private void reportButton_Click(object sender, EventArgs e)
        {
            outLabel.ForeColor = Color.Green;
            outLabel.Text = String.Empty;
            foreach (Account acct in acctList)
            {
                outLabel.Text += acct.ToString() + "\n";
            }
        }
        /// <summary>
        /// Checks to see if Account ID is under 20 and Balance is not negative
        /// </summary>
        /// <param name="id">user passes account ID</param>
        /// <param name="bal">user passes balance change</param>
        private void checkText(int id, decimal bal)
        {
            if (id <= 0 || id >= 20)
            {
                WrongIDExc wie = new WrongIDExc();
                throw (wie);
            }
            else if (bal < 0)
            {
                NegBalExc nbe = new NegBalExc();
                throw (nbe);
            }
        }
        /// <summary>
        /// Erases file and writes new changes to file.
        /// </summary>
        private void rewriteFile()
        {
            System.IO.File.WriteAllText(FILENAME, string.Empty);
            using (FileStream bankFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Write))
            {
                foreach (Account acct in acctList)
                {
                    bFormat.Serialize(bankFile, acct);
                }
            }
        }
    }
}
