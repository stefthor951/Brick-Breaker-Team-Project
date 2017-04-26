using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SuperSnakeGame
{
    public class Highscore
    {
        public string name, score;

        public Highscore(string _name, string _score)
        {
            name = _name;
            score = _score;
        }

        public void onscreenKeyboard(Graphics g)
        {
            
        }
    }
}
