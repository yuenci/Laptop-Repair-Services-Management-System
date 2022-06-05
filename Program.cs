
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniSys0._3
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            Application.Run(new Main());
            //Application.Run(new ProfileFloating());
            //Application.Run(new Reader());
            //Application.Run(new Form1());
            //Application.Run(new VideoPlayer());
            //Application.Run(new TestForm());
            //Application.Run(new Loading());
            //Application.Run(new ViewProfile());
            //Application.Run(new OrderDetails());
            //Application.Run(new AddDescription());

        }
    }
}
