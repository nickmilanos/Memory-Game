using System;
using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        public static bool AcceptClick;
        Images myimages = new Images();
        GamePlay gameplay = new GamePlay();
        Button firstGuess = new Button();
        Button secondGuess = new Button();
        int counter = 0;
        public static int seconds = 0;
        public static int attempts = 0;
        int correctguesses = 0;                // When it reaches 12, game is over.
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            myimages.randomizeimages();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            gameplay.OpenAndDisable(button1,myimages.images[0]);
            showhide(button1, myimages.images[0]);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            gameplay.OpenAndDisable(button2, myimages.images[8]);
            showhide(button2, myimages.images[8]);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            gameplay.OpenAndDisable(button3, myimages.images[7]);
            showhide(button3, myimages.images[7]);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            gameplay.OpenAndDisable(button4, myimages.images[10]);
            showhide(button4, myimages.images[10]);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            gameplay.OpenAndDisable(button5, myimages.images[11]);
            showhide(button5, myimages.images[11]);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            gameplay.OpenAndDisable(button6, myimages.images[3]);
            showhide(button6, myimages.images[3]);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            gameplay.OpenAndDisable(button7, myimages.images[5]);
            showhide(button7, myimages.images[5]);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            gameplay.OpenAndDisable(button8, myimages.images[3]);
            showhide(button8, myimages.images[3]);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            gameplay.OpenAndDisable(button9, myimages.images[1]);
            showhide(button9, myimages.images[1]);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            gameplay.OpenAndDisable(button10, myimages.images[9]);
            showhide(button10, myimages.images[9]);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            gameplay.OpenAndDisable(button11, myimages.images[4]);
            showhide(button11, myimages.images[4]);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            gameplay.OpenAndDisable(button12, myimages.images[2]);
            showhide(button12, myimages.images[2]);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            gameplay.OpenAndDisable(button13, myimages.images[6]);
            showhide(button13, myimages.images[6]);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            gameplay.OpenAndDisable(button14, myimages.images[7]);
            showhide(button14, myimages.images[7]);
        }
        private void button15_Click(object sender, EventArgs e)
        {
            gameplay.OpenAndDisable(button15, myimages.images[2]);
            showhide(button15, myimages.images[2]);
        }
        private void button16_Click(object sender, EventArgs e)
        {
            gameplay.OpenAndDisable(button16, myimages.images[10]);
            showhide(button16, myimages.images[10]);
        }
        private void button17_Click(object sender, EventArgs e)
        {
            gameplay.OpenAndDisable(button17, myimages.images[1]);
            showhide(button17, myimages.images[1]);
        }
        private void button18_Click(object sender, EventArgs e)
        {
            gameplay.OpenAndDisable(button18, myimages.images[8]);
            showhide(button18, myimages.images[8]);
        }
        private void button19_Click(object sender, EventArgs e)
        {
            gameplay.OpenAndDisable(button19, myimages.images[4]);
            showhide(button19, myimages.images[4]);
        }
        private void button20_Click(object sender, EventArgs e)
        {
            gameplay.OpenAndDisable(button20, myimages.images[9]);
            showhide(button20, myimages.images[9]);
        }
        private void button21_Click(object sender, EventArgs e)
        {
            gameplay.OpenAndDisable(button21, myimages.images[0]);
            showhide(button21, myimages.images[0]);
        }
        private void button22_Click(object sender, EventArgs e)
        {
            gameplay.OpenAndDisable(button22, myimages.images[11]);
            showhide(button22, myimages.images[11]);
        }
        private void button23_Click(object sender, EventArgs e)
        {
            gameplay.OpenAndDisable(button23, myimages.images[5]);
            showhide(button23, myimages.images[5]);
        }
        private void button24_Click(object sender, EventArgs e)
        {
            gameplay.OpenAndDisable(button24, myimages.images[6]);
            showhide(button24, myimages.images[6]);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        public void showhide(Button buttonpressed, Image img)
        {
            // All cards are closed and/or only some pairs are open.
            if (counter == 0)
            {
                if (!AcceptClick)
                    return;
                else
                {
                    firstGuess = buttonpressed;
                    counter++;
                }
            }
            else// A card is open and the user is looking for its pair.
            {
                // Number of attempts incrementing whether the move is successfull or not.
                attempts++;
                // If previous card IS paired with the one that was picked now.
                if (firstGuess.BackgroundImage == img)
                {
                    correctguesses++;
                    //This happens when game ends.
                    if (correctguesses == 12)
                    {
                        timer1.Stop();
                        GameOverForm gof = new GameOverForm();
                        gof.Show();
                        editImagesToolStripMenuItem.Enabled = true;
                        seconds = 0;
                        correctguesses = 0;
                        attempts = 0;
                    }
                }
                
                // If previous card is NOT paired with the one that was picked now.
                if(firstGuess.BackgroundImage != img)
                {
                    AcceptClick = false;
                    secondGuess = buttonpressed;
                    timer2.Start();
                }
                counter = 0;
                labelattempts.Text = "Number of Attempts:" + attempts;
                
            }
        }

        // Time counting.
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if ( seconds != 0 ) {
                editImagesToolStripMenuItem.Enabled = false;
            }
            seconds++;
            timelabel.Text ="Time:"+seconds.ToString()+" seconds";
        }

        // If the player guesses wrong, the actions below are executed after a second has passed.
        private void timer2_Tick(object sender, EventArgs e)
        {
            secondGuess.BackgroundImage = myimages.prism;
            firstGuess.BackgroundImage = myimages.prism;
            firstGuess.Enabled = true;
            secondGuess.Enabled = true;
            firstGuess = null;
            AcceptClick = true;
            timer2.Stop();
        }

        // This is where the game starts.
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is Button)
                {
                    c.BackgroundImage = myimages.prism;
                    c.Enabled = true;
                }
            }
            myimages.randomizeimages();
            attempts = 0;
            labelattempts.Text = "Number of Attempts:" + attempts;
            seconds = 0;
            AcceptClick = true;
            timer1.Start();
        }

        //Changing Background color option.
        private void editBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            BackColor = colorDialog1.Color;
            if (colorDialog1.Color == Color.Black)
            {
                labelattempts.ForeColor = Color.White;
                timelabel.ForeColor = Color.White;
            }
            else
            {
                labelattempts.ForeColor = Color.Black;
                timelabel.ForeColor = Color.Black;
            }
        }

        // User picks a set of 12 icons from a directory.Then the list with the default icons empties
        // and gets filled with the icons that the user hasa chosen.
        private void editImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                myimages.images.Clear();
                foreach (string file in openFileDialog1.FileNames)
                {
                    Image newimage = Image.FromFile(file);
                    myimages.images.Add(newimage);
                }
            }

        }

        private void topScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopTen topten = new TopTen();
            topten.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button25_Click(object sender, EventArgs e){}
        private void fileToolStripMenuItem_Click(object sender, EventArgs e){}
    }
}
