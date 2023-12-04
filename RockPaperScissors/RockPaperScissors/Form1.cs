using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            // code below for when player coice is Rock
            Random rnd = new Random();
            int CompChoice = rnd.Next(1, 4);
            lblResult.Text = Convert.ToString(CompChoice);

            picboxUserChoice.BackgroundImage = Properties.Resources.Rock;

            if (CompChoice == 1)
            {
                picboxComputerChoice.BackgroundImage = Properties.Resources.Rock;
                lblResult.Text = Convert.ToString("Result: Draw!");
            } else if (CompChoice == 2)
            {
                picboxComputerChoice.BackgroundImage = Properties.Resources.Paper;
                lblResult.Text = Convert.ToString("Result: You Loose!");
            } else if (CompChoice == 3)
            {
                picboxComputerChoice.BackgroundImage = Properties.Resources.Scissors;
                lblResult.Text = Convert.ToString("Result: You Win!");
            }
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            // code below for when player coice is Paper
            Random rnd = new Random();
            int CompChoice = rnd.Next(1, 4);
            lblResult.Text = Convert.ToString(CompChoice);

            picboxUserChoice.BackgroundImage = Properties.Resources.Paper;

            if (CompChoice == 1)
            {
                picboxComputerChoice.BackgroundImage = Properties.Resources.Rock;
                lblResult.Text = Convert.ToString("Result: You Win!");
            } else if (CompChoice == 2)
            {
                picboxComputerChoice.BackgroundImage = Properties.Resources.Paper;
                lblResult.Text = Convert.ToString("Result: Draw!");
            } else if (CompChoice == 3)
            {
                picboxComputerChoice.BackgroundImage = Properties.Resources.Scissors;
                lblResult.Text = Convert.ToString("Result You Loose!");
            }
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            // code below for when player coice is scissors
            Random rnd = new Random();
            int CompChoice = rnd.Next(1, 4);
            lblResult.Text = Convert.ToString(CompChoice);

            picboxUserChoice.BackgroundImage = Properties.Resources.Scissors;

            if (CompChoice == 1)
            {
                picboxComputerChoice.BackgroundImage = Properties.Resources.Rock;
                lblResult.Text = Convert.ToString("Result: You Loose!");
            } else if (CompChoice == 2)
            {
                picboxComputerChoice.BackgroundImage = Properties.Resources.Paper;
                lblResult.Text = Convert.ToString("Result: You Win!");
            } else if (CompChoice == 3)
            {
                picboxComputerChoice.BackgroundImage = Properties.Resources.Scissors;
                lblResult.Text = Convert.ToString("Result: Draw!");
            }
        }
    }
}
