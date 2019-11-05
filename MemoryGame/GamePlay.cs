using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame
{
    class GamePlay
    {
        // When a card is picked, whatever it is, it should always open.
        // Even if it is for some seconds, if not permanently.
        public void OpenAndDisable(Button button, Image img)
        {
            if (!Form1.AcceptClick)
                return;
            else
            {
                button.BackgroundImage = img;
                // Player cant open and close the cards one by one.
                // Player can only check PAIRS of cards.
                button.Enabled = false;
            } 
        }
    }
}
