﻿using Sunny.UI;
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
    public partial class MessageBoxForm : UIForm
    {
        public static MessageBoxForm Instance;
        public MessageBoxForm()
        {
            InitializeComponent();
            Instance = this;
        }
    }
}
