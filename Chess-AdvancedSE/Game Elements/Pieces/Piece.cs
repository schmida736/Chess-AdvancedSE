using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Chess_AdvancedSE
{
    public class Piece
    {
        protected Piece(bool color)
        {
            Init(color);
        }

        protected void Init(bool color)
        {
            this.color = color;
            this.image = new(new BitmapImage(new Uri("pack://application:,,,/Resources/kd.png"))); //TODO: Make variable image source
        }
        public bool color;

        public ImageBrush image;
    }
}
