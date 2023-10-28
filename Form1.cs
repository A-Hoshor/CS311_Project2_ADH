using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS311_Project2_ADH
{
    public partial class frmMain : Form
    {
        private bool hasRolled = false;
        int dice1=0;
        int dice2=0;
        int sum = 0;
        int point = 0;
        double bankBalance = 100.00;
        float bet;
        bool betCheck = false;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            calculateScore();
        }//end btnRoll_Click

       /*
        * Method will use a switch statement to adjust Bank Balance if user wins or loses.
        * Win is an intial roll of 7 or 11.
        * Loss is an intial roll of 2,3, or 12.
        * 4,5,6,8,9, and 10 will require another roll from the user. If that roll 
        * is the same number, then the user wins. If the roll is a seven, the user loses.
        * The user will continue rolling until one of these two situations is satisfied.
        */

        public void calculateScore()
        {
            roll();

            string label = "Point is " + sum + "! Roll again!";
            string win = "You Win!";
            string lose = "You Lose!";
            if (hasRolled == false)
            {
                switch (sum)
                {
                    case 7:
                        bankBalance += bet;
                        BankBalanceTotal();
                        lblWinLose.Text = win;
                        break;
                    case 8:
                        bankBalance += bet;
                        BankBalanceTotal();
                        lblWinLose.Text = win;
                        break;
                    case 9:
                        bankBalance += bet;
                        BankBalanceTotal();
                        lblWinLose.Text = win;
                        break;
                    case 10:
                        bankBalance += bet;
                        BankBalanceTotal();
                        lblWinLose.Text = win;
                        break;
                    case 11:
                        bankBalance += bet;
                        BankBalanceTotal();
                        lblWinLose.Text = win;
                        break;
                    case 2:
                        bankBalance = bankBalance - bet;
                        BankBalanceTotal();
                        lblWinLose.Text = lose;
                        break;
                    case 3:
                        bankBalance = bankBalance - bet;
                        BankBalanceTotal();
                        lblWinLose.Text = lose;
                        break;
                    case 12:
                        bankBalance = bankBalance - bet;
                        BankBalanceTotal();
                        lblWinLose.Text = lose;
                        break;
                    default:
                        lblWinLose.Text = label;
                        hasRolled = true;
                        point = sum;
                        break;
                }//end switch

            }
            else
            {
                roll();
                if (sum == point)
                {
                    bankBalance += bet;
                    BankBalanceTotal();
                    lblWinLose.Text = win;
                    hasRolled = false;
                }
                else if (sum == 7)
                {
                    bankBalance = bankBalance - bet;
                    BankBalanceTotal();
                    lblWinLose.Text = lose;
                    hasRolled = false;
                }
                else if (sum != point)
                {
                    lblWinLose.Text = "Point is " + point + "! Roll Again!";
                }//end if else statement


            }//end else statement
        }//end calculate score

        /*
         * Roll method will generate two random numbers and sum them to represent dice roll and score.
         */
        private void roll()
        {
            Random rnd = new Random();
            dice1 = rnd.Next(1, 7);
            dice2 = rnd.Next(1, 7);
            lblDice1.Text = dice1.ToString();
            lblDice2.Text = dice2.ToString();
            sum = dice1 + dice2;
        }//end roll

        /*
         * Clear method clears variables for next roll.
         */
        private void clear()
        {
            dice1 = 0; dice2 = 0;
            lblWinLose.Text = "";
            sum = 0;
            point = 0;
            hasRolled = false;
        }
        /*
         * Check balance method ensures the user has enough money in their bank to 
         * satisfy the bet they are placing.
         */
        private bool CheckBalance(float bet)
        {
            if (bet < bankBalance)
            {
                betCheck = true;
            }
            else
            {
                betCheck = false;
                lblBet.Text = "Not enough in your balance to bet!";
            }
            return betCheck;
        }

        private void txtEnterYourBet_TextChanged(object sender, EventArgs e)
        {
            bet = float.Parse(txtEnterYourBet.Text);
            CheckBalance(bet);
        }

        private void BankBalanceTotal()
        {
            lblBankBalanceTotal.Text = bankBalance.ToString("C");
        }

 
    }//end class
}//end namespace
