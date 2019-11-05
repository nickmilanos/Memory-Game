using System;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class TopTen : Form
    {
        public TopTen()
        {
            InitializeComponent();
        }

        private void TopTen_Load(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("Scores.txt",RichTextBoxStreamType.PlainText);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
