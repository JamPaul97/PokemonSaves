using System;
using System.IO;
using System.Drawing;

namespace Resources.Gen1.Badges
{
    public class Badge
    {
        public string Name;
        public string Leader;
        public string GymName;
        public uint Reward;
        internal string img_badge;
        internal string img_leader;
        public Image Badge_Image { get { return this.img_badge.FromBase64(); } }
        public Image Leader_Image { get { return this.img_leader.FromBase64(); } }
        internal Badge()
        {

        }
    }
}
