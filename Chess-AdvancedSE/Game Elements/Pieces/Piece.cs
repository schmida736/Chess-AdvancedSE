﻿using System;
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
        }
        public bool color;
    }
}