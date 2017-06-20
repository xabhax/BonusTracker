using System;
using System.Windows.Forms;

namespace BonusTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateGross(object sender, EventArgs e)
        { 
            // Do some checking of the input
            if (hoursone.Text.Length != 0 && hourstwo.Text.Length != 0 && hoursthree.Text.Length != 0 && hoursfour.Text.Length != 0)
            {
                // Setup variables
                int BonusWeekOne = 0;
                int BonusWeekTwo = 0;
                int BonusWeekThree = 0;
                int BonusWeekFour = 0;
                decimal tmpWeekOne = 0;
                decimal tmpWeekTwo = 0;
                decimal tmpWeekThree = 0;
                decimal tmpWeekFour = 0;
                decimal HourlyMultiplierWeekOne = 0;
                decimal HourlyMultiplierWeekTwo = 0;
                decimal HourlyMultiplierWeekThree = 0;
                decimal HourlyMultiplierWeekFour = 0;
                decimal CalculatedGross = 0;

                // Parse input so we can use it
                decimal WeekOneHours = decimal.Parse(hoursone.Text);
                decimal WeekTwoHours = decimal.Parse(hourstwo.Text);
                decimal WeekThreeHours = decimal.Parse(hoursthree.Text);
                decimal WeekFourHours = decimal.Parse(hoursfour.Text);

                // Check to see if we are even eligble for bonus
                if (WeekOneHours > 50) {
                    BonusWeekOne = 1;
                    tmpWeekOne = WeekOneHours - 50;
                }
                if (WeekTwoHours > 50) {
                    BonusWeekTwo = 1;
                    tmpWeekTwo = WeekTwoHours - 50;
                }
                if (WeekThreeHours > 50)
                {
                    BonusWeekThree = 1;
                    tmpWeekThree = WeekThreeHours - 50;
                }
                if (WeekFourHours > 50)
                {
                    BonusWeekFour = 1;
                    tmpWeekFour = WeekFourHours - 50;
                }

                // Check hours for tiers of bonuses
                if (BonusWeekOne == 1)
                {
                    if (tmpWeekOne <= 10) { HourlyMultiplierWeekOne = 0.50M; }
                    else if (tmpWeekOne <= 20) { HourlyMultiplierWeekOne = 1.00M; }
                    else if (tmpWeekOne <= 30) { HourlyMultiplierWeekOne = 1.50M; }
                    else { HourlyMultiplierWeekOne = 2.00M; }
                }
                if (BonusWeekTwo == 1)
                {
                    if (tmpWeekTwo <= 10) { HourlyMultiplierWeekTwo = 0.50M; }
                    else if (tmpWeekTwo <= 20) { HourlyMultiplierWeekTwo = 1.00M; }
                    else if (tmpWeekTwo <= 30) { HourlyMultiplierWeekTwo = 1.50M; }
                    else { HourlyMultiplierWeekTwo = 2.00M; }
                }
                if (BonusWeekThree == 1)
                {
                    if (tmpWeekThree <= 10) { HourlyMultiplierWeekThree = 0.50M; }
                    else if (tmpWeekThree <= 20) { HourlyMultiplierWeekThree = 1.00M; }
                    else if (tmpWeekThree <= 30) { HourlyMultiplierWeekThree = 1.50M; }
                    else { HourlyMultiplierWeekThree = 2.00M; }
                }
                if (BonusWeekFour == 1)
                {
                    if (tmpWeekFour <= 10) { HourlyMultiplierWeekFour = 0.50M; }
                    else if (tmpWeekFour <= 20) { HourlyMultiplierWeekFour = 1.00M; }
                    else if (tmpWeekFour <= 30) { HourlyMultiplierWeekFour = 1.50M; }
                    else { HourlyMultiplierWeekFour = 2.00M; }
                }
                // Calculate bonus
                CalculatedGross = (tmpWeekOne * HourlyMultiplierWeekOne) + (tmpWeekTwo * HourlyMultiplierWeekTwo) + (tmpWeekThree * HourlyMultiplierWeekThree) + (tmpWeekFour * HourlyMultiplierWeekFour);

                // Show the bonus
               calculatedbonus.Text = CalculatedGross.ToString();
            } 

            else
            {
                // One of the input forms was left blank
                MessageBox.Show("You must complete all fields", "Error");
            }
        }

        private void Quit(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
