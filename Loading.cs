using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniSys0._3
{
    public partial class Loading : UIForm
    {
        private Random rand = new Random();
        private int num = 0;
        private Main main = null;
        public Loading()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitMain();
            HideAllLoadingText();
            RandomLoadingText();
        }
        private void InitMain()
        {
            main = new Main();
        }

        private void HideAllLoadingText()
        {
            Label[] loadingLael = { load1, load2, load3, load4, load5, load6, load7};
            foreach (var item in loadingLael)
            {
                item.Hide();
            }
            progressBar.Size = new Size(0, 4);
        }
        
        
        private void RandomLoadingText()
        {
            this.mytimer.Tick += new System.EventHandler(this.TimerEventProcessor);
            int fortimerinterval = rand.Next(800, 900);
            mytimer.Interval = fortimerinterval;
            mytimer.Enabled = true;
            mytimer.Start();
        }


        public void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            int fortimerinterval = rand.Next(100, 1000);
            mytimer.Interval = fortimerinterval;
            //Console.WriteLine(DateTime.Now);

            Label[] loadingLael = { load1, load2, load3, load4, load5, load6, load7 };
            loadingLael[num].Show();
            progressBar.Size = new Size(108 * (num + 1), 4);
            num++;
            if (num == 7)
            {
                mytimer.Stop();
                //Main main = new Main();
                main.Show();
                this.Hide();
            }
        }


    }
}
