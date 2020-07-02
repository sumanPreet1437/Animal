﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animal
{
    public class Cat:Animal
    {
        public override string Name { get; set; }
        public override PictureBox Picture { get; set; }

        public Cat(string tempName, PictureBox tempPic)
        {
            Name = tempName;
            Picture = tempPic;
        }
        public override void Move(int distance)
        {
            Picture.Location = new Point(Picture.Location.X + distance, Picture.Location.Y);
        }
    }
}
