using System;
using System.IO;
using System.Drawing;

namespace Resources
{
    internal static class Toolbox
    {
        internal static Image FromBase64(this string str)
        {
            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(str)))
                return Image.FromStream(ms);
        }
    }
}
