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
        //public static string DBString = @"Dddddata Source=LAPTOP-5ACE008F\SQLEXPRESS;Initial Catalog=CsharpRepairerInc;Integrated Security=True";
        public static string path = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("bin"));
        //E:\Materials\【LOOP】\Assignment\miniSys0.3\
    }
    public class User_type
    {
        //this is defult
        //public static string user_deparment = "Customer";
        public static string user_deparment = "Customer";
        //deparment:  Receptionist,Technician, Customer, Admin

        //test data
        public static string user_ID = "Cus000001";
        //public static string user_ID = "Sta000093";
        public static string user_name = "Jill Taylor";
        public static string user_phone = "8120633";
        public static string user_email = "test@test.mail.com";
        public static string Birthday = "19990416";
        public static string user_gender = "maleMale";
        public static string user_post = "CEO";
        public static string user_ID_number = "412722194641334317";
        public static string user_about = "best of the best";
        public static string user_Country = "China";
        public static string user_Address = "China";
        public static string user_regtime = "2022-02-22"; 
        public static string user_security_qustion = "I love coding right?";
        public static string user_security_answer = "I love coding right?";
        public static string user_password = "password123456";
        public static string user_theme = "dark";
        // light/dark


        public static Color LogoFore = Color.Black;
        public static Color LogoBkg = Color.FromArgb(70, 141, 255);
        public static string loginStatus = "Login";  //Login,Relogin
        public static bool ifCefInit = false;

        public static void ShowALLPropertyValue()
        {
            Console.WriteLine($"User_type.user_deparment: {user_deparment}");
            Console.WriteLine($"User_type.user_ID: {user_ID}");
            Console.WriteLine($"User_type.user_name: {user_name}");
            Console.WriteLine($"User_type.user_phone: {user_phone}");
            Console.WriteLine($"User_type.user_email: {user_email}");
            Console.WriteLine($"User_type.Birthday: {Birthday}");
            Console.WriteLine($"User_type.user_gender: {user_gender}");
            Console.WriteLine($"User_type.user_post: {user_post}");
            Console.WriteLine($"User_type.user_ID_number: {user_ID_number}");
            Console.WriteLine($"User_type.user_about: {user_about}");
            Console.WriteLine($"User_type.user_Country: {user_Country}");
            Console.WriteLine($"User_type.user_Address: {user_Address}");
            Console.WriteLine($"User_type.user_regtime: {user_regtime}");
            Console.WriteLine($"User_type.user_security_qustion: {user_security_qustion}");
            Console.WriteLine($"User_type.user_security_answer: {user_security_answer}");
            Console.WriteLine($"User_type.user_password: {user_password}");
            Console.WriteLine($"User_type.LogoFore: {LogoFore}");
            Console.WriteLine($"User_type.LogoBkg: {LogoBkg}");
            Console.WriteLine($"User_type.loginStatus: {loginStatus}");
            Console.WriteLine($"User_type.ifCefInit: {ifCefInit}");
        }
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

    public static class RegisterInfoCache
    {
        //public static string RegisterType = "";
        //staff / customer
        public static string user_deparment = "";
        public static string user_ID = "";
        public static string user_name = "";
        public static string user_phone = "";
        public static string user_email = "";
        public static string user_Birthday = "";
        public static string user_gender = "";
        public static string user_post = "";
        public static string user_ID_number = "";
        public static string user_about = "";
        public static string user_Country = "";
        public static string user_Address = "";
        public static string user_regtime = "";
        public static string user_security_qustion = "";
        public static string user_security_answer = "";
        public static string user_password = "";

        public static bool step1Activate = false;
        public static bool step2Activate = false;
        public static bool step3Activate = false;

        public static void ShowALLPropertyValue()
        {
            Console.WriteLine($"User_type.user_deparment: {user_deparment}");
            Console.WriteLine($"User_type.user_ID: {user_ID}");
            Console.WriteLine($"User_type.user_name: {user_name}");
            Console.WriteLine($"User_type.user_phone: {user_phone}");
            Console.WriteLine($"User_type.user_email: {user_email}");
            Console.WriteLine($"User_type.user_Birthday: {user_Birthday}");
            Console.WriteLine($"User_type.user_gender: {user_gender}");
            Console.WriteLine($"User_type.user_post: {user_post}");
            Console.WriteLine($"User_type.user_ID_number: {user_ID_number}");
            Console.WriteLine($"User_type.user_about: {user_about}");
            Console.WriteLine($"User_type.user_Country: {user_Country}");
            Console.WriteLine($"User_type.user_Address: {user_Address}");
            Console.WriteLine($"User_type.user_regtime: {user_regtime}");
            Console.WriteLine($"User_type.user_security_qustion: {user_security_qustion}");
            Console.WriteLine($"User_type.user_security_answer: {user_security_answer}");
            Console.WriteLine($"User_type.user_password: {user_password}");
            Console.WriteLine($"User_type.step1Activate: {step1Activate}");
            Console.WriteLine($"User_type.step2Activate: {step2Activate}");
            Console.WriteLine($"User_type.step3Activate: {step3Activate}");
        }
    }

    public static class ReceiptInfoCache
    {
        public static string orderID = "";
        public static string service_Type = "";
        public static string service_Name = "";
        public static string customerID = "";
        public static string receptionist = "";
        public static string urgent = "";
        public static string model = "";
        public static string time = "";
        public static string description = "";
        public static string price = "";
        public static string payment_method = "";
        public static string star = "";
        public static string Card_Account_ID = "";

        public static string customer_name = "";

        public static void ShowALLPropertyValue()
        {
            Console.WriteLine($"User_type.orderID: {orderID}");
            Console.WriteLine($"User_type.service_Type: {service_Type}");
            Console.WriteLine($"User_type.service_Type: {service_Name}");
            Console.WriteLine($"User_type.customerID: {customerID}");
            Console.WriteLine($"User_type.receptionist: {receptionist}");
            Console.WriteLine($"User_type.urgent: {urgent}");
            Console.WriteLine($"User_type.model: {model}");
            Console.WriteLine($"User_type.time: {time}");
            Console.WriteLine($"User_type.description: {description}");
            Console.WriteLine($"User_type.price: {price}");
            Console.WriteLine($"User_type.payment_method: {payment_method}");
            Console.WriteLine($"User_type.star: {star}");
            Console.WriteLine($"User_type.Card_Account_ID: {Card_Account_ID}");
        }
    }
}
