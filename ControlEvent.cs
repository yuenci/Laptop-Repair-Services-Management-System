using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniSys0._3
{
    public class TextBoxCE
    {
        private UITextBox Source;
        private string  Text;
        private Color RectColor = Color.White;
        public TextBoxCE(UITextBox textBox,string textContent)
        {
            this.Source = textBox;
            this.Text = textContent;
            this.Source.Enter += new EventHandler(TextBoxEnter);
            this.Source.Leave += new EventHandler(TextBoxLeave);
        }
        public TextBoxCE(UITextBox textBox, string textContent, Color RectColor)
        {
            this.Source = textBox;
            this.Text = textContent;
            this.RectColor = RectColor;
            this.Source.Enter += new EventHandler(TextBoxEnter);
            this.Source.Leave += new EventHandler(TextBoxLeave);
        }
        private void SetText()
        {
            this.Source.Text = this.Text;
        }
        private void TextBoxEnter(object senter, EventArgs e)
        {
            this.Source.RectColor = this.RectColor;
            if (this.Source.Text == this.Text)
            {
                this.Source.Text = "";
            }
        }
        private void TextBoxLeave(object senter, EventArgs e)
        {
            if (this.Source.Text == "")
            {
                this.Source.Text = this.Text;
            }
        }
    }

    public static class AddUserControl
    {
        public  static void Add(dynamic control, Panel panel)
        {

            control.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(control); 
            control.BringToFront();
        }
    } 

    public class PasswordBoxCE
    {
        private UITextBox Source;
        private string Text;
        public PasswordBoxCE(UITextBox textBox, string textContent)
        {
            this.Source = textBox;
            this.Text = textContent;
        }

        private void PasswordBoxEnter()
        {
            this.Source.RectColor = Color.White;
            if (this.Source.Text == this.Text)
            {
                this.Source.Text = "";
                this.Source.PasswordChar = '*';
            }
        }
        private void PasswordBoxLeave()
        {
            if (this.Source.Text == "")
            {
                this.Source.Text = this.Text;
                this.Source.PasswordChar = '\0';
            }
        }
    }
}
