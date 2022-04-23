using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniSys0._3
{
    public class Setting
    {
        public static string DBString = @"Data Source=LAPTOP-5ACE008F\SQLEXPRESS;Initial Catalog=CsharpRepairerInc;Integrated Security=True";
    }
    public class User_type
    {
        //this is defult
        //public static string user_deparment = "Customer";
        public static string user_deparment = "Admin";
        //deparment:  Receptionist,Technician, Customer, Admin

        //test data
        public static string user_name = "Innis";
        public static string user_post = "CEO";
        public static string user_ID = "Sta000000";
        public static string user_Country = "China";
        public static string user_regtime = "2022-02-22";
        public static string user_gender = "maleMale";
        public static string user_phone = "8120633";
        public static string user_email = "test@test.mail.com";
        public static string user_ID_number = "412722194641334317";
        public static string user_security_qustion = "I love coding right?";
        public static string user_security_answer = "I love coding right?";
        public static string user_password = "password123456";


        public static Color LogoFore = Color.Black;
        public static Color LogoBkg = Color.FromArgb(70, 141, 255);
        public static string loginStatus = "Login";  //Login,Relogin
        public static bool ifCefInit = false;
    }

    public class ArticlesInfo
    {
        public static string[] ArticlelDList = new string[5];
        public static string[] titleParaList = new string[5];
        public static string[] posterParaList = new string[5];
        public static string[] staffpostParaList = new string[5];
        public static string[] viewsParaList = new string[5];
        public static string[] likesParaList = new string[5];
        public static string[] timeParaList = new string[5];
        public static string[] urlParaList = new string[5];
        public static string currentArticlelD = "";
        public static string currentArticleType = "";
        public static int currentnewsLablelD = -1;

    }

    public static class NoticeInfo
    {
        public static string[] ArticlelDList = new string[5];
        public static string[] titleParaList = new string[5];
        public static string[] posterParaList = new string[5];
        public static string[] staffpostParaList = new string[5];
        public static string[] viewsParaList = new string[5];
        public static string[] likesParaList = new string[5];
        public static string[] timeParaList = new string[5];
        public static string[] urlParaList = new string[5];
        public static string currentArticlelD = "";
        public static int currentnoticeLablelD = -1;
    }
}
