using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            // import

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Please choose a file";
            openFileDialog.Filter = "*.json|*.json";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //System.Windows.Forms.MessageBox.Show(openFileDialog.FileName);

                string str = File.ReadAllText(openFileDialog.FileName);

                //Console.WriteLine(str);

                LoaclSettings model = Newtonsoft.Json.JsonConvert.DeserializeObject<LoaclSettings>(str);
                //Console.WriteLine(model.homePage);

                SentLocalSetDataToDB(model);
                UserSettings.InitStatusData();
                SettingForm.Instance.ReInitStatus();

                //System.Windows.Forms.MessageBox.Show("Import successfully");
                NotificationForm messageBoxForm = new NotificationForm("success", "Import successfully");
                messageBoxForm.ShowDialog();

            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            // export

            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            //folderBrowser.SelectedPath = ;
            folderBrowser.Description = "Please choose a folder to save settings file";
            //folderBrowser.ShowNewFolderButton = true;
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                //System.Windows.Forms.MessageBox.Show(folderBrowser.SelectedPath);

                LoaclSettings model = new LoaclSettings();
                model.theme = UserSettings.theme;
                model.autoTheme = UserSettings.autoTheme;
                model.homePage = UserSettings.homePage;
                model.rejectAllMs = UserSettings.rejectAllMs;
                model.rejectAllSy = UserSettings.rejectAllSy;
                model.rejectAllCus = UserSettings.rejectAllCus;
                model.allowSearch = UserSettings.allowSearch;
                model.allowShowProfile = UserSettings.allowShowProfile;
                model.privateMode = UserSettings.privateMode;

                string json = Newtonsoft.Json.JsonConvert.SerializeObject(model);
                //Console.WriteLine(json);

                FileStream fs1 = new FileStream($"{folderBrowser.SelectedPath}\\Settings.json", FileMode.Create, FileAccess.Write);//create file
                StreamWriter sw = new StreamWriter(fs1);
                sw.WriteLine(json);//write content
                sw.Close();
                fs1.Close();

                //System.Windows.Forms.MessageBox.Show("Export successfully");
                NotificationForm messageBoxForm = new NotificationForm("success", "Export successfully");
                messageBoxForm.ShowDialog();

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
    
        private void SentLocalSetDataToDB(LoaclSettings data)
        {
            string userIDSQL = "";
            string userIDType = "";
            if (User_type.user_ID.Substring(0,3) == "Cus")
            {
                userIDSQL = $"'{User_type.user_ID}',null";
                userIDType = "UseID_cus";
            }
            else if(User_type.user_ID.Substring(0, 3) == "Sta"){
                userIDSQL = $"null,'{User_type.user_ID}'";
                userIDType = "UseID_sta";
            }

            string DeleteSQL = $"DELETE FROM Settings WHERE {userIDType}  = '{User_type.user_ID}';";
            //Console.WriteLine(sql);
            SQLCursor.Execute(DeleteSQL);


            string[] typeList = {"theme","autoTheme","homePage",
                                "rejectAllMs","rejectAllSy","rejectAllCus",
                                "allowSearch", "allowShowProfile","privateMode"};
            string[] values = { data.theme, data.autoTheme, data.homePage,
                                data.rejectAllMs, data.rejectAllSy, data.rejectAllCus,
                                data.allowSearch, data.allowShowProfile, data.privateMode,};
            string allSql = "INSERT INTO Settings VALUES ";

            for (int i = 0; i < typeList.Length -1; i++)
            {
                string sql = $"({userIDSQL},'{typeList[i]}','{values[i]}'),";
                allSql += sql;
            }

            allSql += $"({userIDSQL},'{typeList[8]}','{values[8]}');";

            Console.WriteLine(allSql);
            SQLCursor.Execute(allSql);

            
        }
    }

    public class LoaclSettings
    {
        public  string theme ;
        public  string autoTheme ;
        public  string homePage ;

        public  string rejectAllMs ;
        public  string rejectAllSy ;
        public  string rejectAllCus ;

        public  string allowSearch;
        public  string allowShowProfile;
        public  string privateMode;
    }
}
