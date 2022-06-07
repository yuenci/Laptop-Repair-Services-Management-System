using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace miniSys0._3
{
    public class AppSetting
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

        //deparment:  Receptionist,Technician, Customer, Admin

        //test data

        //customer
        //customer
        /*public static string user_deparment = "Customer";
        public static string user_ID = "Cus000002";*/

        //staff
        public static string user_deparment = "Technician";
        //public static string user_ID = "Sta000001";

        //public static string user_ID = "Sta000011";
        public static string user_ID = "Sta000052";



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
        public static string user_theme = "light";
        // light/dark
        public static string user_avatarPath = "";





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

    public static class UserSettings 
    {
        //public static string theme = User_type.user_theme;

        public static string theme = "Off";
        public static string autoTheme = "Off";
        public static string homePage = "Dashboard";

        public static string rejectAllMs = "Off";
        public static string rejectAllSy = "Off";
        public static string rejectAllCus = "Off";

        public static string allowSearch = "On";
        public static string allowShowProfile = "On";
        public static string privateMode = "Off";

        public static void DisplayStatus(UISwitch obj,string statusText)
        {
            if (statusText =="On")
            {
                obj.Active = true;
            }
           else if (statusText == "Off")
            {
                obj.Active = false;
            }
        }

        public static void SetStatus(string type, bool valueBool)
        {
            string[] typeList = {"theme","autoTheme","rejectAllMs","rejectAllSy","rejectAllCus",
                                "allowSearch", "allowShowProfile","privateMode"};

            string[] valueCacheList = { theme, autoTheme,rejectAllMs,rejectAllSy, rejectAllCus, 
                                        allowSearch, allowShowProfile, privateMode};
            string value;
            if (valueBool)
            {
                value = "On";
                setCache(type, "On");
            }
            else
            {
                value = "Off";
                setCache(type, "Off");
            }

            string userIDType = "" ;
            string userIDSQL = "";

            if (User_type.user_ID.Substring(0,3)=="Cus")
            {
                userIDType = "UseID_cus";
                userIDSQL = $"'{User_type.user_ID}',null";
            }
            else if(User_type.user_ID.Substring(0, 3) == "Sta")
            {
                userIDType = "UseID_sta";
                userIDSQL = $"null,'{User_type.user_ID}'";
            }

            if (typeList.Contains(type))
            {
                string sql;

                //exist
                if (checkIfExist(userIDType))
                {
                    sql = $"UPDATE Settings  SET Value = '{value}' WHERE Type = '{type}' " +
                        $"AND {userIDType} = '{User_type.user_ID}';";
                }
                //not exist
                else
                {
                    sql = $"INSERT INTO Settings VALUES ({userIDSQL},'{type}','{value}');";
                }
                SQLCursor.Execute(sql);
                
            }
            else
            {
                MessageBox.Show("Class UserSettings Method SetStatus ERROE ");
            }

            bool checkIfExist(string idType)
            {
                string sql = $"SELECT Value FROM Settings WHERE  Type= '{type}' AND {idType} = '{User_type.user_ID}';";
                dynamic[] data = SQLCursor.Query(sql);
                if (data.Length > 0)
                {
                    //MessageBox.Show("exist");
                    return true;
                   
                }
                else
                {
                    //MessageBox.Show(" not exist");
                    return false;
                    
                }
                
            }
            void setCache(string typeStr,string valueStr)
            {
                if(typeStr == "theme")
                {
                    theme = valueStr;
                }
                else if (typeStr == "autoTheme")
                {
                    autoTheme = valueStr;
                }
                else if (typeStr == "rejectAllMs")
                {
                    rejectAllMs = valueStr;
                }
                else if (typeStr == "rejectAllSy")
                {
                    rejectAllSy = valueStr;
                }
                else if (typeStr == "rejectAllCus")
                {
                    rejectAllCus = valueStr;
                }
                else if (typeStr == "allowSearch")
                {
                    allowSearch = valueStr;
                }
                else if (typeStr == "allowShowProfile")
                {
                    allowShowProfile = valueStr;
                }
                else if (typeStr == "privateMode")
                {
                    privateMode = valueStr;
                }
            }
        }

        public static void SetStatus(string type, string value)
        {
            string userIDType = "";
            string userIDSQL = "";

            homePage = value;

            if (User_type.user_ID.Substring(0, 3) == "Cus")
            {
                userIDType = "UseID_cus";
                userIDSQL = $"'{User_type.user_ID}',null";
            }
            else if (User_type.user_ID.Substring(0, 3) == "Sta")
            {
                userIDType = "UseID_sta";
                userIDSQL = $"null,'{User_type.user_ID}'";
            }

            string sql;

            //exist
            if (checkIfExist(userIDType))
            {
                sql = $"UPDATE Settings  SET Value = '{value}' WHERE Type = 'homePage' " +
                    $"AND {userIDType} = '{User_type.user_ID}';";
            }
            //not exist
            else
            {
                sql = $"INSERT INTO Settings VALUES ({userIDSQL},'homePage','{value}');";
            }
            SQLCursor.Execute(sql);


            bool checkIfExist(string idType)
            {
                string sql1 = $"SELECT Value FROM Settings WHERE  Type= 'homePage' AND {idType} = '{User_type.user_ID}';";
                dynamic[] data = SQLCursor.Query(sql1);
                if (data.Length > 0)
                {
                    //MessageBox.Show("exist");
                    return true;
                }
                else
                {
                    //MessageBox.Show(" not exist");
                    return false;

                }

            }
        }
   
        public static void InitStatusData()
        {
            string UseIDRowName;

            if (User_type.user_ID.Substring(0, 3) == "Cus")
            {
                UseIDRowName = "UseID_cus";
            }
            else
            {
                UseIDRowName = "UseID_sta";
            }

            string[] typeList = {"theme","autoTheme","homePage","rejectAllMs","rejectAllSy","rejectAllCus",
                                "allowSearch", "allowShowProfile","privateMode"};

            string allSQL = "";
            for (int i = 0; i < typeList.Length; i++)
            {
                string sql = $"SELECT Value FROM Settings WHERE {UseIDRowName} = '{User_type.user_ID}' " +
                    $"AND Type = '{typeList[i]}';";
                allSQL += sql;
            }

            dynamic[] allData = SQLCursor.QueryMany(allSQL);
            for (int i = 0; i < allData.Length; i++)
            {
                if (allData[i][0] != "")
                {
                    setCache(typeList[i], allData[i][0]);
                }
            }

            void setCache(string typeStr, string valueStr)
            {
                if (typeStr == "theme")
                {
                    theme = valueStr;
                    if (theme == "Off")
                    {
                        User_type.user_theme = "light";
                    }
                    else if(theme == "On")
                    {
                        User_type.user_theme = "dark";
                    }
                }
                else if (typeStr == "autoTheme")
                {
                    autoTheme = valueStr;
                }
                else if (typeStr == "homePage")
                {
                    homePage = valueStr;
                }
                else if (typeStr == "rejectAllMs")
                {
                    rejectAllMs = valueStr;
                }
                else if (typeStr == "rejectAllSy")
                {
                    rejectAllSy = valueStr;
                }
                else if (typeStr == "rejectAllCus")
                {
                    rejectAllCus = valueStr;
                }
                else if (typeStr == "allowSearch")
                {
                    allowSearch = valueStr;
                }
                else if (typeStr == "allowShowProfile")
                {
                    allowShowProfile = valueStr;
                }
                else if (typeStr == "privateMode")
                {
                    privateMode = valueStr;
                }
            }
        }
        public static void ResetToDefault()
        {
            theme = "Off";
            autoTheme = "Off";
            homePage = "Dashboard";

            rejectAllMs = "Off";
            rejectAllSy = "Off";
            rejectAllCus = "Off";

            allowSearch = "On";
            allowShowProfile = "On";
            privateMode = "Off";
    }
        
        public static string GetSettingsValue(string UserId, string settingName)
        {
            string userRow = "";
            if (UserId.Substring(0, 3) == "Cus")
            {
                userRow = "UseID_cus";
            }
            else
            {
                userRow = "UseID_sta";
            }


            string[] typeList = {"theme","autoTheme","homePage","rejectAllMs","rejectAllSy","rejectAllCus",
                                "allowSearch", "allowShowProfile","privateMode"};
            if (typeList.Contains(settingName))
            {
                string sql = $"SELECT Value FROM Settings WHERE {userRow} = '{UserId}' AND Type = '{settingName}' ;";

                Console.WriteLine(sql);

                dynamic[] data = SQLCursor.Query(sql);
                if (data.Length == 1)
                {
                    return data[0];
                }
                else if (data.Length == 0)
                {
                    //pass
                }
                else
                {
                    MessageBox.Show("Setting value more than one");
                    return null;
                }
            }
            else
            {
                MessageBox.Show("settingName Error");
            }
            return null;
        }

        public static void ShowAllPropertyValue()
        {
            Console.WriteLine("-------------");
            Console.WriteLine($"theme:{theme}");
            Console.WriteLine($"autoTheme:{autoTheme}");
            Console.WriteLine($"homePage:{homePage}");
            Console.WriteLine($"rejectAllMs:{rejectAllMs}");
            Console.WriteLine($"rejectAllSy:{rejectAllSy}");
            Console.WriteLine($"rejectAllCus:{rejectAllCus}");
            Console.WriteLine($"allowSearch:{allowSearch}");
            Console.WriteLine($"allowShowProfile:{allowShowProfile}");
            Console.WriteLine($"privateMode:{privateMode}");
            Console.WriteLine("-------------");
        }
    }

}
