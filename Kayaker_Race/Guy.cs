using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace Kayaker_Race
{
    public abstract class Guy
    {
        public  Label MyLabel = new Label(); // update bet result labels
   //     public  RadioButton MyRadioButton = new RadioButton();
        public  Label Labelmax = new Label(); // sets each persons max bet

        public  string PlayerName { get; set; }
        public  Bet MyBet = new Bet();
        public  int Cash { get; set; }



        public void Collect(int Winner) // get mybet to payout, clear the bet and update maxbet label
       {
           if (MyBet != null)
               Cash += Payout(Winner);
            Labelmax.Text = Cash.ToString();
       }

        public int Payout(int Winner) // How much money to payout
        {
            if (MyBet.Kayaker == Winner)
                return MyBet.Amount; // return the amount bet
            return -MyBet.Amount; // return the negitave of amount bet 
        }
    }
        }

   