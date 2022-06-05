using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace miniSys0._3.Controls.Setting
{
    public partial class UC_Setting_Expost : UserControl
    {
        public static UC_Setting_Expost Instance ;
        public UC_Setting_Expost()
        {
            InitializeComponent();
            Instance = this;
        }
        public void InitTheme()
        {
            UIButton[] btns = {exportBtn,importBtn,resetBtn };
            foreach(var btn in btns)
            {
                btn.RectColor = Color.Transparent;
            }


            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(55, 55, 57);
                dynamic[] lable = { uiLabel1 , uiLabel2 , uiLabel3 , uiLabel4 };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }

            }
            else if (User_type.user_theme == "light")
            {
                this.BackColor = Color.White;
                dynamic[] lable = { uiLabel1, uiLabel2, uiLabel3, uiLabel4 };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.Black;
                }

            }
        }

        private  void FileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Please choose a file";
            openFileDialog.Filter = "*.json|*.json";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.Windows.Forms.MessageBox.Show(openFileDialog.FileName);
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            //folderBrowser.SelectedPath = ;
            folderBrowser.Description = "Please choose a folder to save settings file";
            //folderBrowser.ShowNewFolderButton = true;
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                System.Windows.Forms.MessageBox.Show(folderBrowser.SelectedPath);
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            DialogResult Asterisk = System.Windows.Forms.MessageBox.Show("Do you want reset setting to default?",
                                 "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (Asterisk == DialogResult.OK)
            {
                string userIDType = "";
                if (User_type.user_ID.Substring(0, 3) == "Cus")
                {
                    userIDType = "UseID_cus";
                }
                else if (User_type.user_ID.Substring(0, 3) == "Sta")
                {
                    userIDType = "UseID_sta";
                }
                string sql = $"DELETE FROM Settings WHERE {userIDType}  = '{User_type.user_ID}';";
                //Console.WriteLine(sql);
                SQLCursor.Execute(sql);

                UserSettings.ResetToDefault();
            }
            

        }
    }

    
}
