﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
namespace Gen3.Data.Items
{
    public class Item
    {
        public int Pocket;
        public string Name;
        public string Description;
        internal string img;
        public Image Image
        {
            get
            {
                byte[] bytes = Convert.FromBase64String(this.img);

                Image image;
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    return image = Image.FromStream(ms);
                }
            }
        }
    }
}
