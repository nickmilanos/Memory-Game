using System;
using System.IO;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class GameOverForm : Form
    {
        
        public GameOverForm()
        {
            InitializeComponent();
        }

        private void GameOverForm_Load(object sender, EventArgs e)
        {
            label4.Text = Form1.attempts.ToString();
            label5.Text = Form1.seconds.ToString()+" seconds";
            button1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // User has to insert a username, even if it is a blank character.
            if (!textBox1.Text.Equals(null)) {
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // When submit button is pressed, username, score and time are saved in a text file.
            File.AppendAllText("Scores.txt", label4.Text+"  "+ textBox1.Text +"  "+
                label5.Text+Environment.NewLine+Environment.NewLine);
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
