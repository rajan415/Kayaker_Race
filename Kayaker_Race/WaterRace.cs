using System;
using System.Windows.Forms;

namespace Kayaker_Race
{
    public partial class WaterRace : Form
    {
        private readonly Guy[] currentPunter = new Guy[3];
        private readonly kayaker[] mykayaker = new kayaker[4];
        public int SelectedKayakerNumber;

        public WaterRace()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGo.Enabled = false;
            for (int i = 0; i < currentPunter.Length; i++)
            {
                currentPunter[i] = Factory.GetBettorInfo(i);
            }
            currentPunter[0].MyLabel = lblSteveResult;
            currentPunter[1].MyLabel = lblAllanResult;
            currentPunter[2].MyLabel = lblDaxResult;
            // generates new bettors each time to store data & idenifies which label belongs to which bettor
        }

        private void KayakerRun() //Makes The Kayaker Move
        {
            mykayaker[0] = new kayaker { Name = "Kayaker 1", mypb = pbKayker1 };
            mykayaker[1] = new kayaker { Name = "Kayaker 2", mypb = pbKayaker2 };
            mykayaker[2] = new kayaker { Name = "Kayaker 3", mypb = pbKayaker3 };
            mykayaker[3] = new kayaker { Name = "Kayaker 4", mypb = pbKayaker4 };

            var myrnd = new Random();
            var End = false;


            while (End == false)
            {
                for (var i = 0; i < 4; i++)
                {
                    mykayaker[i].mypb.Top += myrnd.Next(6, 12);
                    if (mykayaker[i].mypb.Top > 300)
                    {
                        End = true;

                        for (var j = 0; j < currentPunter.Length; j++)
                        {
                            currentPunter[j].Collect(i + 1); // dending on which kayaker won, the winning bettor collects his/her money

                            if (currentPunter[j].Cash == 0)
                            {
                                currentPunter[j].MyLabel.Text = currentPunter[j].PlayerName + " Is BANKRUPT!";
                            }


                        }
                        RadioButton[] rbs = { rbSteve, rbAllan, rbDax };
                        for (int x = 0; x < rbs.Length; x++)
                            if (rbs[x].Checked)
                            {
                                lblMaxBet.Text = currentPunter[x].Cash.ToString();
                                break;
                            }
                        MessageBox.Show(mykayaker[i].Name + " Won!"); // displays in a label which kayaker won
                        ResetKayakers();
                        break;
                    }
                }

                Application.DoEvents();
                Invalidate();
            }
        }

        private void ResetKayakers() // resets the kayakers & bettors labels so they can keep betting
        {
            for (var i = 0; i < 4; i++)
            {
                mykayaker[i].mypb.Top = 45;
            }
            {
                foreach (var guy in currentPunter)
                    if (guy.Cash > 0)
                        guy.MyLabel.Text = guy.PlayerName + " Has Not Yet Placed A Bet!";
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
                KayakerRun(); // makes the kayaker move from this method when button is clicked
        }

        public void rb_CheckedChanged(object sender, EventArgs e) // checks which radiobutton is selected and assigns it to a bettor
        {
            var rb = (RadioButton)sender;

            if (rb.Checked)
            {
                switch (rb.Text)

                {
                    case "Steve":
                        SelectedKayakerNumber = 0;
                        lblMaxBet.Text = currentPunter[0].Labelmax.Text;
                        numericUpDownBet.Maximum = Convert.ToDecimal(currentPunter[0].Labelmax.Text);
                        break;
                    case "Allan":
                        SelectedKayakerNumber = 1;
                        lblMaxBet.Text = currentPunter[1].Labelmax.Text;
                        numericUpDownBet.Maximum = Convert.ToDecimal(currentPunter[1].Labelmax.Text);
                        break;
                    case "Dax":
                        SelectedKayakerNumber = 2;
                        lblMaxBet.Text = currentPunter[2].Labelmax.Text;
                        numericUpDownBet.Maximum = Convert.ToDecimal(currentPunter[2].Labelmax.Text);
                        break;
                }


                if (Convert.ToInt16(lblMaxBet.Text) == 0) // if a player has no money there label shows they are bankrupt
                {
                    rb.Enabled = false;

                }
            }
        }

        public void btnBet_Click(object sender, EventArgs e)
        // sets each bettors label to display amount bet & kayaker bet on
        {
            currentPunter[SelectedKayakerNumber].MyBet.Amount = Convert.ToInt16(numericUpDownBet.Value);
            currentPunter[SelectedKayakerNumber].MyBet.Kayaker = Convert.ToInt16(numericUpDownKayak.Value);


            for (int i = 0; i < currentPunter.Length; i++)
            {
                if (currentPunter[i].Cash == 0) continue;
                currentPunter[i].MyLabel.Text = currentPunter[i].PlayerName + " Bet $" + currentPunter[i].MyBet.Amount + " On Kayaker " + currentPunter[i].MyBet.Kayaker;
            }

            btnGo.Enabled = true;

        }

        private void pbKayker1_Click(object sender, EventArgs e)
        {

        }

        private void pbKayaker2_Click(object sender, EventArgs e)
        {

        }

        private void pbKayaker3_Click(object sender, EventArgs e)
        {

        }

        private void pbKayaker4_Click(object sender, EventArgs e)
        {

        }
    }
}
