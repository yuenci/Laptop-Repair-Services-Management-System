using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniSys0._3
{
    public partial class VideoPlayer : UIForm
    {
        public VideoPlayer()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = @"C:\Users\Innis\Downloads\bad-guys-trailer-1_i320.m4v"; //指定音频文件
            axWindowsMediaPlayer1.settings.volume = 20;//指定音量
            axWindowsMediaPlayer1.Ctlcontrols.play();//开始播放
        }

        private void win_closing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
