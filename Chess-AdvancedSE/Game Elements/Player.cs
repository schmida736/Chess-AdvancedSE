using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_AdvancedSE
{
    class Player
    {
        public Player(Constants.Color color)
        {
            this.color = color;
        }
        public Constants.Color color { get; private set; }    }

}
