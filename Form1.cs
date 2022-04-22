using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniSys0._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ArtJsath = @"E:\Front end Engineering\Csharp\sqlEngine\test.js";
            string[] lines = System.IO.File.ReadAllLines(ArtJsath);
            for (int i = 0; i < 3; i++)
            {
                lines[i] = i.ToString();

            }
            //empty old file
            FileStream fs = new FileStream(ArtJsath, FileMode.Truncate, FileAccess.ReadWrite);
            fs.Close();
            //add new
            File.AppendAllText(ArtJsath, String.Join("", lines) + Environment.NewLine);
            Console.WriteLine("done");
        }
    }
}
