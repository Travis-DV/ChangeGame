using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeGame
{
    public partial class Form1 : Form
    {
        //pennie nickel dime quarter
        private int[] limits = { 0, 0, 0, 0};
        private bool limited = false;

        public Form1()
        {
            InitializeComponent();
        }

        private int Turnintoint(string inputstring)
        {
            try
            {
                int inputnumb = int.Parse(inputstring);
                if (inputnumb < 0)
                {
                    Isempty(inputstring);
                    int outputfails = 0;
                    return outputfails;
                }
                int outputwork = int.Parse(inputstring);
                return outputwork;
            }
            catch (FormatException)
            {
                Isempty(inputstring);
                int outputfails = 0;
                return outputfails;
            }


        }

        private void Isempty(string inputstr)
        {
            if (inputstr == "")
            {
                outputLB.Text = "";
            }
            else
            {
                outputLB.Text = "Please input a number 1-10!";
            }
            centerlb();
        }

        private void costaddition()
        {
            //pennie, nickel, dime, quarter
            int[] inputmoney = { Turnintoint(pennieTB.Text), Turnintoint(nickelTB.Text), Turnintoint(dimeTB.Text), Turnintoint(quarterTB.Text) };
            bool passed = false;
            if (limited)
            {
                if (inputmoney[0] <= limits[0] && inputmoney[1] <= limits[1] && inputmoney[2] <= limits[2] && inputmoney[3] <= limits[3])
                {
                    passed = true;
                }
                else
                {
                    outputLB.Text = "Input a number withen the limits";
                }
                randomizelimitsBUT.Visible = true;
            }
            if ((!limited || passed) && inputmoney[0] + (inputmoney[1] * 5) + (inputmoney[2] * 10) + (inputmoney[3] * 25) == 100)
            {
                gameBUT.Visible = false;
                randomizelimitsBUT.Visible = false;
                outputLB.Text = "YOU WIN, YOUR CHOICES ADD UP TO 1 DOLLER";
            }
            else if ((!limited || passed) && inputmoney[0] + (inputmoney[1] * 5) + (inputmoney[2] * 10) + (inputmoney[3] * 25) < 100)
            {
                gameBUT.Visible = true;
                outputLB.Text = "Your choices add up to LESS then a doller";
            }
            else if ((!limited || passed) && inputmoney[0] + (inputmoney[1] * 5) + (inputmoney[2] * 10) + (inputmoney[3] * 25) > 100)
            {
                gameBUT.Visible = true;
                outputLB.Text = "Your choices add up to MORE then a dollor";
            }
            centerlb();
        }

        private void randomiselimits()
        {
            randomints();
            while ((limits[0] + limits[1] + limits[2] + limits[3]) < 100)
            {
                randomints();
                MessageBox.Show((limits[0] + limits[1] + limits[2] + limits[3]).ToString());
            }
            pennieLB.Text = $"Pennies: {limits[0]}";
            nickelLB.Text = $"Nickels: {limits[1]}";
            dimeLB.Text = $"Dimes: {limits[2]}";
            quarterLB.Text = $"Quarters: {limits[3]}";
        }

        private void randomints()
        {
            //pennie
            limits[0] = RandomNumber.Between(1, 100);
            //nickel
            limits[1] = RandomNumber.Between(1, 20);
            //dime
            limits[2] = RandomNumber.Between(1, 10);
            //quarter
            limits[3] = RandomNumber.Between(1, 4);
        }

        private void gameBUT_Click(object sender, EventArgs e)
        {
            if (!limited)
            {
                randomiselimits();
                randomizelimitsBUT.Visible = true;
                limited = true;
                gameBUT.Text = "Unlimit Change";
            }
            else if (limited)
            {
                limited = false;
                randomizelimitsBUT.Visible = false;
                gameBUT.Text = "Limit Change";
                pennieLB.Text = $"Pennies: ";
                nickelLB.Text = $"Nickels: ";
                dimeLB.Text = $"Dimes: ";
                quarterLB.Text = $"Quarters: ";
            }
        }

        private void centerlb()
        {
            int heightbuffer = 7;
            int width = (this.Size.Width / 2) - (outputLB.Width / 2);
            int height = (this.Size.Height / 2) - (outputLB.Height / 2) + heightbuffer;
            outputLB.Location = new Point(width, height);
            outputLB.Visible = true;
        }

        private void pennieTB_TextChanged(object sender, EventArgs e)
        {
            costaddition();
            centerlb();
        }

        private void nickelTB_TextChanged(object sender, EventArgs e)
        {
            costaddition();
            centerlb();
        }

        private void dimeTB_TextChanged(object sender, EventArgs e)
        {
            costaddition();
            centerlb();
        }

        private void quarterTB_TextChanged(object sender, EventArgs e)
        {
            costaddition();
            centerlb();
        }

        private void randomizelimitsBUT_Click(object sender, EventArgs e)
        {
            randomiselimits();
        }
    }

    public static class RandomNumber
    {
        private static readonly RNGCryptoServiceProvider _generator = new RNGCryptoServiceProvider();
        public static int Between(int minimumValue, int maximumValue)
        {
            byte[] randomNumbers = new byte[1];
            _generator.GetBytes(randomNumbers);
            double asciiValueOfRandomCharacter = Convert.ToDouble(randomNumbers[0]);
            double multiplier = Math.Max(0, (asciiValueOfRandomCharacter / 255d) - 0.00000000001d);
            int range = (maximumValue - 1) - minimumValue;
            double randomValueInRange = Math.Floor(multiplier * range);
            return (int)(minimumValue + randomValueInRange);
        }
    }
}
