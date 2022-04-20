using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniSys0._3
{
    public class IconfontHelper
    {
        private static System.Drawing.Text.PrivateFontCollection pfcc;

        public static System.Drawing.Text.PrivateFontCollection PFCC
        {
            get { return pfcc ?? LoadFont(); }
        }
        public static System.Drawing.Text.PrivateFontCollection LoadFont()
        {
            pfcc = new System.Drawing.Text.PrivateFontCollection();
            pfcc.AddFontFile(Environment.CurrentDirectory + "/icomoon.ttf");
            return pfcc;
        }
    }
}
