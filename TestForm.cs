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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            TextBoxCE superTextBox = new TextBoxCE(uiTextBox1,"HIIIIIIIIIIIIII");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }
    }
}
