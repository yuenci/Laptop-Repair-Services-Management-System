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
        private void TextBoxEnter(object senter, EventArgs e)
        {
            this.Source.RectColor = this.RectColor;
            this.Source.Font = new Font(".萍方-简", 12, FontStyle.Bold);
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
                this.Source.Font = new Font(".萍方-简", 12, FontStyle.Regular);
            }
        }
    }
    public class RichTextBoxCE
    {
        private UIRichTextBox Source;
        private string Text;
        private Color RectColor = Color.White;
        public RichTextBoxCE(UIRichTextBox textBox, string textContent)
        {
            this.Source = textBox;
            this.Text = textContent;
            this.Source.Enter += new EventHandler(TextBoxEnter);
            this.Source.Leave += new EventHandler(TextBoxLeave);
        }
        public RichTextBoxCE(UIRichTextBox textBox, string textContent, Color RectColor)
        {
            this.Source = textBox;
            this.Text = textContent;
            this.RectColor = RectColor;
            this.Source.Enter += new EventHandler(TextBoxEnter);
            this.Source.Leave += new EventHandler(TextBoxLeave);
        }
        private void TextBoxEnter(object senter, EventArgs e)
        {
            this.Source.RectColor = this.RectColor;
            this.Source.Font = new Font(".萍方-简", 12, FontStyle.Bold);
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
                this.Source.Font = new Font(".萍方-简", 12, FontStyle.Regular);
            }
        }
    }

    public class ComboBoxCE
    {
        private UIComboBox ComboBox;
        private Color RectColor = Color.White;

        public ComboBoxCE(UIComboBox comboBox,Color RectColor)
        {
            this.ComboBox = comboBox;
            this.RectColor = RectColor;
            this.ComboBox.DropDown += new EventHandler(ComboBox_DropDown);
            this.ComboBox.DropDownClosed += new EventHandler(ComboBox_DropDownClosed);
        }
  
        private void ComboBox_DropDown(object senter, EventArgs e)
        {
            this.ComboBox.RectColor = this.RectColor;
            this.ComboBox.RectSize = 1;
            this.ComboBox.Font = new Font(".萍方-简", 12, FontStyle.Regular);

        }
        private void ComboBox_DropDownClosed(object senter, EventArgs e)
        {
            if (this.ComboBox.SelectedIndex == -1)
            {
                ComboBox.RectSize = 2;
                ComboBox.RectColor = Color.Red;
            }
            else
            {
                this.ComboBox.Font = new Font(".萍方-简", 12, FontStyle.Bold);
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
