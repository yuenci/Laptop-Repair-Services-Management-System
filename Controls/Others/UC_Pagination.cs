using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using miniSys0._3.Controls.MainArea;
using Sunny.UI;

namespace miniSys0._3.Controls.Others
{
    public partial class UC_Pagination : UserControl
    {
        private int pageNum;
        private int DataAmount;
        public int pageID;
        public int currentPerNum = 10;
        public string type = "";

        public UC_Pagination()
        {     
            InitializeComponent();
        }

        
        //card ; list
        public void Init(int dataAmount,int perPage)
        {
            this.DataAmount = dataAmount;
            InitTotal();

            int pages = culPageNum(perPage);
            IntButtonRender(pages);
            InitButtonEvent();

        }
        public void InitTheme()
        {    
            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(28, 47, 70);

                dynamic[] lable = { total, uiLabel4, uiLabel1 };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }

                dynamic[] btns = {symButton0,symButton1,symButton2,symButton3,symButton4,symButton5,
                                  symButton6,symButton7,symButton8,symButton9,symButton10 };
                foreach (var item in btns)
                {
                    item.FillColor = Color.FromArgb(55, 55, 57);
                    item.BackColor = Color.FromArgb(55, 55, 57);
                    item.ForeColor = Color.White;
                }

            }
        }



        //private bool ifLessEight;
        private void InitTotal()
        {
            total.Text = $"Total {DataAmount} items";
            pageNumEnter.Text = "";
        }
        private void BoldFont(object senter, EventArgs e)
        {
            if (senter.Equals(symButton1))
            {
                symButton1.Font = new Font(".萍方-简", 12, FontStyle.Bold);
            }
            else if (senter.Equals(symButton2))
            {
                symButton2.Font = new Font(".萍方-简", 12, FontStyle.Bold);
            }
            else if (senter.Equals(symButton3))
            {
                symButton3.Font = new Font(".萍方-简", 12, FontStyle.Bold);
            }
            else if (senter.Equals(symButton4))
            {
                symButton4.Font = new Font(".萍方-简", 12, FontStyle.Bold);

            }
            else if (senter.Equals(symButton5))
            {
                symButton5.Font = new Font(".萍方-简", 12, FontStyle.Bold);

            }
            else if (senter.Equals(symButton6))
            {
                symButton6.Font = new Font(".萍方-简", 12, FontStyle.Bold);

            }
            else if (senter.Equals(symButton7))
            {
                symButton7.Font = new Font(".萍方-简", 12, FontStyle.Bold);
            }
            else if (senter.Equals(symButton8))
            {
                symButton8.Font = new Font(".萍方-简", 12, FontStyle.Bold);
            }
            else if (senter.Equals(symButton9))
            {
                symButton9.Font = new Font(".萍方-简", 12, FontStyle.Bold);
            }

        }
        private void BoldRegular(object senter, EventArgs e)
        {
            if (senter.Equals(symButton1))
            {
                symButton1.Font = new Font(".萍方-简", 12, FontStyle.Regular);
            }
            else if (senter.Equals(symButton2))
            {
                symButton2.Font = new Font(".萍方-简", 12, FontStyle.Regular);
            }
            else if (senter.Equals(symButton3))
            {
                symButton3.Font = new Font(".萍方-简", 12, FontStyle.Regular);
            }
            else if (senter.Equals(symButton4))
            {
                symButton4.Font = new Font(".萍方-简", 12, FontStyle.Regular);

            }
            else if (senter.Equals(symButton5))
            {
                symButton5.Font = new Font(".萍方-简", 12, FontStyle.Regular);

            }
            else if (senter.Equals(symButton6))
            {
                symButton6.Font = new Font(".萍方-简", 12, FontStyle.Regular);

            }
            else if (senter.Equals(symButton7))
            {
                symButton7.Font = new Font(".萍方-简", 12, FontStyle.Regular);
            }
            else if (senter.Equals(symButton8))
            {
                symButton8.Font = new Font(".萍方-简", 12, FontStyle.Regular);
            }
            else if (senter.Equals(symButton9))
            {
                symButton9.Font = new Font(".萍方-简", 12, FontStyle.Regular);
            }
            else if (senter.Equals(symButton10))
            {
                symButton10.Font = new Font(".萍方-简", 12, FontStyle.Regular);
            }

        }
        private void InitButtonEvent()
        {

            symButton0.Click += new EventHandler(symButtonsClick);

            symButton1.MouseHover += new EventHandler(BoldFont);
            symButton1.MouseLeave += new EventHandler(BoldRegular);
            symButton1.Click += new EventHandler(symButtonsClick);

            symButton2.MouseHover += new EventHandler(BoldFont);
            symButton2.MouseHover += new EventHandler(leftRightHover);
            symButton2.MouseLeave += new EventHandler(leftRightLeave);
            symButton2.MouseLeave += new EventHandler(BoldRegular);
            symButton2.Click += new EventHandler(symButtonsClick);

            symButton3.MouseHover += new EventHandler(BoldFont);
            symButton3.MouseLeave += new EventHandler(BoldRegular);
            symButton3.Click += new EventHandler(symButtonsClick);

            symButton4.MouseHover += new EventHandler(BoldFont);
            symButton4.MouseLeave += new EventHandler(BoldRegular);
            symButton4.Click += new EventHandler(symButtonsClick);

            symButton5.MouseHover += new EventHandler(BoldFont);
            symButton5.MouseLeave += new EventHandler(BoldRegular);
            symButton5.Click += new EventHandler(symButtonsClick);

            symButton6.MouseHover += new EventHandler(BoldFont);
            symButton6.MouseLeave += new EventHandler(BoldRegular);
            symButton6.Click += new EventHandler(symButtonsClick);

            symButton7.MouseHover += new EventHandler(BoldFont);
            symButton7.MouseLeave += new EventHandler(BoldRegular);
            symButton7.MouseHover += new EventHandler(leftRightHover);
            symButton7.MouseLeave += new EventHandler(leftRightLeave);
            symButton7.Click += new EventHandler(symButtonsClick);

            symButton8.MouseHover += new EventHandler(BoldFont);
            symButton8.MouseHover += new EventHandler(leftRightHover);
            symButton8.MouseLeave += new EventHandler(BoldRegular);
            symButton8.MouseLeave += new EventHandler(leftRightLeave);
            symButton8.Click += new EventHandler(symButtonsClick);

            symButton9.MouseHover += new EventHandler(BoldFont);
            symButton9.MouseLeave += new EventHandler(BoldRegular);
            symButton9.Click += new EventHandler(symButtonsClick);

            symButton10.Click += new EventHandler(symButtonsClick);
        }
        private void IntButtonRender(int pages)
        {
            /*if (pages < 8)
            {
                ifLessEight = true;
            }
            else
            {
                ifLessEight = false;
            }*/

            pageNum = pages;
            Dictionary<int, string> eleDict = new Dictionary<int, string>();

            if (pages == 1)
            {
                eleDict.Add(5, "1");
                justOnePage(symButton5);
            }
            else if (pages == 2)
            {
                eleDict.Add(4, "1");
                eleDict.Add(5, "2");
                justOnePage(symButton4);
            }
            else if (pages == 3)
            {
                eleDict.Add(4, "1");
                eleDict.Add(5, "2");
                eleDict.Add(6, "3");
                justOnePage(symButton4);
            }
            else if (pages == 4)
            {
                eleDict.Add(3, "1");
                eleDict.Add(4, "2");
                eleDict.Add(5, "3");
                eleDict.Add(6, "4");
                justOnePage(symButton3);
            }
            else if (pages == 5)
            {
                eleDict.Add(3, "1");
                eleDict.Add(4, "2");
                eleDict.Add(5, "3");
                eleDict.Add(6, "4");
                eleDict.Add(7, "5");
                justOnePage(symButton3);
            }
            else if (pages == 6)
            {
                eleDict.Add(2, "1");
                eleDict.Add(3, "2");
                eleDict.Add(4, "3");
                eleDict.Add(5, "4");
                eleDict.Add(6, "5");
                eleDict.Add(7, "6");
                justOnePage(symButton2);
            }
            else if (pages == 7)
            {
                eleDict.Add(2, "1");
                eleDict.Add(3, "2");
                eleDict.Add(4, "3");
                eleDict.Add(5, "4");
                eleDict.Add(6, "5");
                eleDict.Add(7, "6");
                eleDict.Add(8, "7");
                justOnePage(symButton2);
            }
            else
            {
                eleDict.Add(2, "1");
                eleDict.Add(3, "2");
                eleDict.Add(4, "3");
                eleDict.Add(5, "4");
                eleDict.Add(6, "5");
                eleDict.Add(7, "...");
                eleDict.Add(8, pages.ToString());
                justOnePage(symButton2);
            }

            render(eleDict);

        }
        private string status = "odd";
        private void render(Dictionary<int, string> eleDict)
        {
            //sort
            var eleDictSorted = from pair in eleDict orderby pair.Key ascending select pair;

            List<int> keys = new List<int>();
            List<string> values = new List<string>();
            int listLength = 0;

            foreach (KeyValuePair<int, string> kvp in eleDictSorted)
            {
                keys.Add(kvp.Key);
                values.Add(kvp.Value);
                listLength++;
            }

            /// reset
            UISymbolButton[] uISymbolButtons = { symButton0,
            symButton1, symButton2, symButton3, symButton4,
            symButton5, symButton6, symButton7, symButton8, symButton9,
            symButton10
            };
            foreach (var item in uISymbolButtons)
            {
                item.Visible = true;
                item.Text = "";
                item.Symbol = 0;
            }
            //Console.WriteLine($"count:{eleDict.Count}");
            /// set position
            //even-> odd
            if (status == "even" && eleDict.Count % 2 != 0)
            {
                symButton10.Visible = false;
                for (int i = 0; i < uISymbolButtons.Length; i++)
                {
                    int xValue = uISymbolButtons[i].Location.X;
                    int yValue = uISymbolButtons[i].Location.Y;
                    uISymbolButtons[i].Location = new Point(xValue - 21, yValue);
                }
                status = "odd";
                //Console.WriteLine("even-> odd");
            }
            //odd-> even
            else if (status == "odd" && eleDict.Count % 2 == 0)
            {
                for (int i = 0; i < uISymbolButtons.Length; i++)
                {
                    int xValue = uISymbolButtons[i].Location.X;
                    int yValue = uISymbolButtons[i].Location.Y;
                    uISymbolButtons[i].Location = new Point(xValue + 21, yValue);
                }
                status = "even";
                // Console.WriteLine("odd-> even");
            }


            ///0-10
            //symbolLeft
            //Console.WriteLine($"keys0：{keys[0]}");
            uISymbolButtons[keys[0] - 1].Symbol = 52;
            uISymbolButtons[keys[0] + listLength].Symbol = 53;

            //button
            for (int i = 0; i < listLength; i++)
            {
                uISymbolButtons[keys[i]].Text = values[i];
            }

            //hide empty ele
            for (int i = 0; i <= keys[0] - 2; i++)
            {
                uISymbolButtons[i].Visible = false;
            }
            for (int i = keys[0] + listLength + 1; i < 11; i++)
            {
                uISymbolButtons[i].Visible = false;
            }
            //Console.WriteLine("____________________");
        }
        private void symButtonsClick(object senter, EventArgs e)
        {
            string buttonText = "";
            int symBum = -1;
            if (senter.Equals(symButton0))
            {
                buttonText = symButton0.Text;
                symBum = symButton0.Symbol;
            }
            else if (senter.Equals(symButton1))
            {
                buttonText = symButton1.Text;
                symBum = symButton1.Symbol;
            }
            else if (senter.Equals(symButton2))
            {
                buttonText = symButton2.Text;
                symBum = symButton2.Symbol;
            }
            else if (senter.Equals(symButton3))
            {
                buttonText = symButton3.Text;
                symBum = symButton3.Symbol;
            }
            else if (senter.Equals(symButton4))
            {
                buttonText = symButton4.Text;
                symBum = symButton4.Symbol;
            }
            else if (senter.Equals(symButton5))
            {
                buttonText = symButton5.Text;
                symBum = symButton5.Symbol;
            }
            else if (senter.Equals(symButton6))
            {
                buttonText = symButton6.Text;
                symBum = symButton6.Symbol;
            }
            else if (senter.Equals(symButton7))
            {
                buttonText = symButton7.Text;
                symBum = symButton7.Symbol;
            }
            else if (senter.Equals(symButton8))
            {
                buttonText = symButton8.Text;
                symBum = symButton8.Symbol;
            }
            else if (senter.Equals(symButton9))
            {
                buttonText = symButton9.Text;
                symBum = symButton9.Symbol;
            }
            else if (senter.Equals(symButton10))
            {
                buttonText = symButton10.Text;
                symBum = symButton10.Symbol;
            }
            UISymbolButton currentBlueNum = currentBlue();
            /*Console.WriteLine($"currentBlueNum:{currentBlueNum.Text}");
            Console.WriteLine($"-------------------");*/
            logic(buttonText, symBum, currentBlueNum);

        }
        private void logic(string ClikedButtonText, int ClikedButtonSymbol, UISymbolButton currentBlueObj)
        {
            if (pageNum == 2)
            {
                if (ClikedButtonText == "1")
                {
                    justOnePage(symButton4);
                    pageID = 1;
                }
                else if (ClikedButtonText == "2")
                {
                    justOnePage(symButton5);
                    pageID = 2;
                }
                else if (ClikedButtonSymbol == 52)
                {
                    if (currentBlueObj.Text == "2")
                    {
                        justOnePage(symButton4);
                        pageID = 1;
                    }
                }
                else if (ClikedButtonSymbol == 53)
                {
                    if (currentBlueObj.Text == "1")
                    {
                        justOnePage(symButton5);
                        pageID = 2;
                    }
                }
            }
            else if (pageNum == 3)
            {
                UISymbolButton[] uISymbolButtons = { symButton4, symButton5, symButton6 };
                if (ClikedButtonText == "1")
                {
                    justOnePage(symButton4);
                    pageID = 1;
                }
                else if (ClikedButtonText == "2")
                {
                    justOnePage(symButton5);
                    pageID = 2;
                }
                else if (ClikedButtonText == "3")
                {
                    justOnePage(symButton6);
                    pageID = 3;
                }
                else if (ClikedButtonSymbol == 52)
                {
                    if (int.Parse(currentBlueObj.Text) > 1)
                    {
                        int currentIndex = Array.IndexOf(uISymbolButtons, currentBlueObj);
                        justOnePage(uISymbolButtons[currentIndex - 1]);
                        pageID = int.Parse(currentBlueObj.Text)-1;
                    }
                }
                else if (ClikedButtonSymbol == 53)
                {
                    if (int.Parse(currentBlueObj.Text) < 3)
                    {
                        int currentIndex = Array.IndexOf(uISymbolButtons, currentBlueObj);
                        justOnePage(uISymbolButtons[currentIndex + 1]);
                        pageID = int.Parse(currentBlueObj.Text) + 1;
                    }
                }
            }
            else if (pageNum == 4)
            {
                UISymbolButton[] uISymbolButtons = { symButton3, symButton4, symButton5, symButton6 };
                if (ClikedButtonText == "1")
                {
                    justOnePage(symButton3);
                }
                else if (ClikedButtonText == "2")
                {
                    justOnePage(symButton4);
                }
                else if (ClikedButtonText == "3")
                {
                    justOnePage(symButton5);
                }
                else if (ClikedButtonText == "4")
                {
                    justOnePage(symButton6);
                }
                else if (ClikedButtonSymbol == 52)
                {
                    if (int.Parse(currentBlueObj.Text) > 1)
                    {
                        int currentIndex = Array.IndexOf(uISymbolButtons, currentBlueObj);
                        justOnePage(uISymbolButtons[currentIndex - 1]);
                        pageID = int.Parse(currentBlueObj.Text) - 1;
                    }
                }
                else if (ClikedButtonSymbol == 53)
                {
                    if (int.Parse(currentBlueObj.Text) < 4)
                    {
                        int currentIndex = Array.IndexOf(uISymbolButtons, currentBlueObj);
                        justOnePage(uISymbolButtons[currentIndex + 1]);
                        pageID = int.Parse(currentBlueObj.Text) + 1;
                    }
                }
            }
            else if (pageNum == 5)
            {
                UISymbolButton[] uISymbolButtons = { symButton3, symButton4, symButton5, symButton6, symButton7 };
                if (ClikedButtonText == "1")
                {
                    justOnePage(symButton3);
                }
                else if (ClikedButtonText == "2")
                {
                    justOnePage(symButton4);
                }
                else if (ClikedButtonText == "3")
                {
                    justOnePage(symButton5);
                }
                else if (ClikedButtonText == "4")
                {
                    justOnePage(symButton6);
                }
                else if (ClikedButtonText == "5")
                {
                    justOnePage(symButton7);
                }
                else if (ClikedButtonSymbol == 52)
                {
                    if (int.Parse(currentBlueObj.Text) > 1)
                    {
                        int currentIndex = Array.IndexOf(uISymbolButtons, currentBlueObj);
                        justOnePage(uISymbolButtons[currentIndex - 1]);
                        pageID = int.Parse(currentBlueObj.Text) - 1;
                        pageID = int.Parse(currentBlueObj.Text) - 1;
                    }
                }
                else if (ClikedButtonSymbol == 53)
                {
                    if (int.Parse(currentBlueObj.Text) < 5)
                    {
                        int currentIndex = Array.IndexOf(uISymbolButtons, currentBlueObj);
                        justOnePage(uISymbolButtons[currentIndex + 1]);
                        pageID = int.Parse(currentBlueObj.Text) + 1;
                    }
                }
            }
            else if (pageNum == 6)
            {
                UISymbolButton[] uISymbolButtons = { symButton2, symButton3, symButton4, symButton5, symButton6, symButton7 };
                if (ClikedButtonText == "1")
                {
                    justOnePage(symButton2);
                }
                else if (ClikedButtonText == "2")
                {
                    justOnePage(symButton3);
                }
                else if (ClikedButtonText == "3")
                {
                    justOnePage(symButton4);
                }
                else if (ClikedButtonText == "4")
                {
                    justOnePage(symButton5);
                }
                else if (ClikedButtonText == "5")
                {
                    justOnePage(symButton6);
                }
                else if (ClikedButtonText == "6")
                {
                    justOnePage(symButton7);
                }
                else if (ClikedButtonSymbol == 52)
                {
                    if (int.Parse(currentBlueObj.Text) > 1)
                    {
                        int currentIndex = Array.IndexOf(uISymbolButtons, currentBlueObj);
                        justOnePage(uISymbolButtons[currentIndex - 1]);
                        pageID = int.Parse(currentBlueObj.Text) - 1;
                    }
                }
                else if (ClikedButtonSymbol == 53)
                {
                    if (int.Parse(currentBlueObj.Text) < 6)
                    {
                        int currentIndex = Array.IndexOf(uISymbolButtons, currentBlueObj);
                        justOnePage(uISymbolButtons[currentIndex + 1]);
                        pageID = int.Parse(currentBlueObj.Text) + 1;
                    }
                }
            }
            else if (pageNum == 7)
            {
                UISymbolButton[] uISymbolButtons = { symButton2, symButton3, symButton4, symButton5, symButton6, symButton7, symButton8 };
                if (ClikedButtonText == "1")
                {
                    justOnePage(symButton2);
                }
                else if (ClikedButtonText == "2")
                {
                    justOnePage(symButton3);
                }
                else if (ClikedButtonText == "3")
                {
                    justOnePage(symButton4);
                }
                else if (ClikedButtonText == "4")
                {
                    justOnePage(symButton5);
                }
                else if (ClikedButtonText == "5")
                {
                    justOnePage(symButton6);
                }
                else if (ClikedButtonText == "6")
                {
                    justOnePage(symButton7);
                }
                else if (ClikedButtonText == "7")
                {
                    justOnePage(symButton8);
                }
                else if (ClikedButtonSymbol == 52)
                {
                    if (int.Parse(currentBlueObj.Text) > 1)
                    {
                        int currentIndex = Array.IndexOf(uISymbolButtons, currentBlueObj);
                        justOnePage(uISymbolButtons[currentIndex - 1]);
                        pageID = int.Parse(currentBlueObj.Text) - 1;
                    }
                }
                else if (ClikedButtonSymbol == 53)
                {
                    if (int.Parse(currentBlueObj.Text) < 7)
                    {
                        int currentIndex = Array.IndexOf(uISymbolButtons, currentBlueObj);
                        justOnePage(uISymbolButtons[currentIndex + 1]);
                        pageID = int.Parse(currentBlueObj.Text) + 1;
                    }
                }
            }
            else
            {
                if (ClikedButtonText != "" && ClikedButtonText != "...")
                {
                    if (ClikedButtonText == "1")
                    {
                        Dictionary<int, string> eleDict = new Dictionary<int, string>();
                        eleDict.Add(2, "1");
                        eleDict.Add(3, "2");
                        eleDict.Add(4, "3");
                        eleDict.Add(5, "4");
                        eleDict.Add(6, "5");
                        eleDict.Add(7, "...");
                        eleDict.Add(8, pageNum.ToString());
                        render(eleDict);
                        justOnePage(symButton2);
                        pageID = 1;
                    }
                    else if (ClikedButtonText == "2")
                    {
                        Dictionary<int, string> eleDict = new Dictionary<int, string>();
                        eleDict.Add(2, "1");
                        eleDict.Add(3, "2");
                        eleDict.Add(4, "3");
                        eleDict.Add(5, "4");
                        eleDict.Add(6, "5");
                        eleDict.Add(7, "...");
                        eleDict.Add(8, pageNum.ToString());
                        render(eleDict);
                        justOnePage(symButton3);
                        pageID = 2;
                    }
                    else if (ClikedButtonText == "3")
                    {
                        Dictionary<int, string> eleDict = new Dictionary<int, string>();
                        eleDict.Add(2, "1");
                        eleDict.Add(3, "2");
                        eleDict.Add(4, "3");
                        eleDict.Add(5, "4");
                        eleDict.Add(6, "5");
                        eleDict.Add(7, "...");
                        eleDict.Add(8, pageNum.ToString());
                        render(eleDict);
                        justOnePage(symButton4);
                        pageID = 3;
                    }
                    else if (ClikedButtonText == "4")
                    {
                        Dictionary<int, string> eleDict = new Dictionary<int, string>();
                        eleDict.Add(1, "1");
                        eleDict.Add(2, "2");
                        eleDict.Add(3, "3");
                        eleDict.Add(4, "4");
                        eleDict.Add(5, "5");
                        eleDict.Add(6, "6");
                        eleDict.Add(7, "...");
                        eleDict.Add(8, pageNum.ToString());
                        render(eleDict);
                        justOnePage(symButton4);
                        pageID = 4;
                    }
                    else if (int.Parse(ClikedButtonText) > pageNum - 4)
                    {
                        UISymbolButton[] uISymbolButtons = { symButton8, symButton7, symButton6, symButton5 };
                        Dictionary<int, string> eleDict = new Dictionary<int, string>();
                        eleDict.Add(1, "1");
                        eleDict.Add(2, "...");
                        eleDict.Add(3, (pageNum - 5).ToString());
                        eleDict.Add(4, (pageNum - 4).ToString());
                        eleDict.Add(5, (pageNum - 3).ToString());
                        eleDict.Add(6, (pageNum - 2).ToString());
                        eleDict.Add(7, (pageNum - 1).ToString());
                        eleDict.Add(8, pageNum.ToString());
                        render(eleDict);
                        int index = pageNum - int.Parse(ClikedButtonText);
                        justOnePage(uISymbolButtons[index]);
                        pageID = int.Parse(ClikedButtonText);
                    }
                    else
                    {
                        Dictionary<int, string> eleDict = new Dictionary<int, string>();
                        eleDict.Add(1, "1");
                        eleDict.Add(2, "...");
                        eleDict.Add(3, ((int.Parse(ClikedButtonText) - 2)).ToString());
                        eleDict.Add(4, (int.Parse(ClikedButtonText) - 1).ToString());
                        eleDict.Add(5, ClikedButtonText);
                        eleDict.Add(6, ((int.Parse(ClikedButtonText) + 1)).ToString());
                        eleDict.Add(7, ((int.Parse(ClikedButtonText) + 2)).ToString());
                        eleDict.Add(8, "...");
                        eleDict.Add(9, pageNum.ToString());
                        render(eleDict);
                        justOnePage(symButton5);
                        pageID = int.Parse(ClikedButtonText);
                    }
                }
                else if (ClikedButtonText == "" && ClikedButtonSymbol == 52)
                {
                    if (int.Parse(currentBlueObj.Text) > 1)
                    {
                        logic((int.Parse(currentBlueObj.Text) - 1).ToString(), 0, currentBlueObj);
                        pageID = int.Parse(currentBlueObj.Text) - 1;
                    }
                }
                else if (ClikedButtonText == "" && ClikedButtonSymbol == 53)
                {
                    if (int.Parse(currentBlueObj.Text) < pageNum)
                    {
                        logic((int.Parse(currentBlueObj.Text) + 1).ToString(), 0, currentBlueObj);
                        pageID = int.Parse(currentBlueObj.Text) + 1;
                    }
                }
                else if (ClikedButtonText == "" && ClikedButtonSymbol == 56)
                {
                    if (int.Parse(currentBlueObj.Text) < pageNum)
                    {
                        logic((int.Parse(currentBlueObj.Text) - 5).ToString(), 0, currentBlueObj);
                        pageID = int.Parse(currentBlueObj.Text) - 5;
                    }
                }
                else if (ClikedButtonText == "" && ClikedButtonSymbol == 57)
                {
                    if (int.Parse(currentBlueObj.Text) < pageNum)
                    {
                        logic((int.Parse(currentBlueObj.Text) + 5).ToString(), 0, currentBlueObj);
                        pageID = int.Parse(currentBlueObj.Text) + 5;
                    }
                }
            }
            Console.WriteLine(pageID);
            cardCallBack();
        }
        private void clearRect()
        {
            UISymbolButton[] uISymbolButtons = { symButton0,
            symButton1, symButton2, symButton3, symButton4,
            symButton5, symButton6, symButton7, symButton8, symButton9,
            symButton10
            };

            foreach (var item in uISymbolButtons)
            {
                item.RectColor = Color.White;
            }
        }
        private void justOnePage(UISymbolButton symBtn)
        {
            clearRect();
            symBtn.RectColor = Color.FromArgb(22, 93, 255);
            symBtn.RectHoverColor = Color.FromArgb(22, 93, 255);
        }

        private UISymbolButton currentBlue()
        {
            UISymbolButton[] uISymbolButtons = { symButton0,
            symButton1, symButton2, symButton3, symButton4,
            symButton5, symButton6, symButton7, symButton8, symButton9,
            symButton10
            };

            for (int i = 0; i < uISymbolButtons.Length; i++)
            {
                if (uISymbolButtons[i].RectColor == Color.FromArgb(22, 93, 255))
                {
                    return uISymbolButtons[i];
                }
            }
            return null;
        }

        private void leftRightHover(object senter, EventArgs e)
        {
            if (senter.Equals(symButton2))
            {
                if (symButton2.Text == "...")
                {
                    symButton2.Text = "";
                    symButton2.Symbol = 56;
                }
            }
            else if (senter.Equals(symButton7))
            {
                //Console.WriteLine("hover");
                if (symButton7.Text == "...")
                {
                    symButton7.Text = "";
                    symButton7.Symbol = 57;
                }
            }
            else if (senter.Equals(symButton8))
            {
                if (symButton8.Text == "...")
                {
                    symButton8.Text = "";
                    symButton8.Symbol = 57;
                }
            }
        }

        private void leftRightLeave(object senter, EventArgs e)
        {
            if (senter.Equals(symButton2))
            {
                if (symButton2.Text == "")
                {
                    symButton2.Text = "...";
                    symButton2.Symbol = 0;
                }

            }
            else if (senter.Equals(symButton7))
            {
                if (symButton7.Text == "")
                {
                    symButton7.Text = "...";
                    symButton7.Symbol = 0;
                }
            }
            else if (senter.Equals(symButton8))
            {
                if (symButton8.Text == "")
                {
                    symButton8.Text = "...";
                    symButton8.Symbol = 0;
                }
            }
        }
        
        private void ComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (ComboBox.SelectedIndex == 0)
            {
                //Console.WriteLine("10");
                IntButtonRender(culPageNum());
                currentPerNum = 10;
            }
            else if (ComboBox.SelectedIndex == 1)
            {
                //Console.WriteLine("20");
                IntButtonRender(culPageNum(20));
                currentPerNum = 20;
            }
            else if (ComboBox.SelectedIndex == 2)
            {
                //Console.WriteLine("30");
                IntButtonRender(culPageNum(30));
                currentPerNum = 30;
            }
            else if (ComboBox.SelectedIndex == 3)
            {
                IntButtonRender(culPageNum(40));
                currentPerNum = 40;
            }
            else if (ComboBox.SelectedIndex == 4)
            {
                IntButtonRender(culPageNum(50));
                currentPerNum = 50;
            }
            UC_TaskList.instance.renderNewList(0, currentPerNum);

        }
        private int culPageNum(int perPage = 10)
        {
            int totalPages = (int)Math.Ceiling((double)DataAmount / perPage);
            return totalPages;
        }

        private void UITextBoxPageNo_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void pageNumEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)// press enter key
            {
                string str = pageNumEnter.Text;
                if (str != null && Regex.IsMatch(str, @"^\d+$"))
                {
                    if (int.Parse(str)<= pageNum && int.Parse(str) >=1)
                    {
                        logic(pageNumEnter.Text, 0, currentBlue());
                    }
                    
                }
                Console.WriteLine("enter");
            }
        }

        public dynamic[] orderList;
        private void cardCallBack()
        {
            if (type == "card")
            {
                Console.WriteLine("called");
                /*string sql = "WITH A AS(SELECT DISTINCT OrderID,Time from Schedule WhERE Status = 'Finished'),";
                sql += "B AS(SELECT DISTINCT OrderID,Time from Schedule)";
                sql += "select * from B where (select count(1) as num from A where A.OrderID = B.OrderID) = 0  Order by Time";*/

                dynamic[] data = orderList;

                dynamic[] card = { UC_TaskCards.uc_TaskCards.uC_Task_Card1,
                UC_TaskCards.uc_TaskCards.uC_Task_Card2,
                UC_TaskCards.uc_TaskCards.uC_Task_Card3,
                UC_TaskCards.uc_TaskCards.uC_Task_Card4,
                UC_TaskCards.uc_TaskCards.uC_Task_Card5,
                UC_TaskCards.uc_TaskCards.uC_Task_Card6,
                UC_TaskCards.uc_TaskCards.uC_Task_Card7,
                UC_TaskCards.uc_TaskCards.uC_Task_Card8,
                UC_TaskCards.uc_TaskCards.uC_Task_Card9,};

                if (pageID != pageNum)
                {
                    for (int i = 0; i < card.Length; i++)
                    {
                        card[i].Init(data[9 * pageID - 9 + i][0]);
                    }
                }
                else
                {
                    int lastPageCardNum = data.Length % 9;
                    int index = data.Length - lastPageCardNum;

                    Console.WriteLine(lastPageCardNum);

                    for (int i = 0; i < lastPageCardNum; i++)
                    {
                        card[i].Init(data[index+i][0]);
                    }


                    for (int i = lastPageCardNum; i < card.Length; i++)
                    {
                        card[i].Hide();
                    }
                }


            }
            else if(type == "list")
            {
                if (pageID != pageNum)
                {
                    Console.WriteLine($"{(pageID-1) * currentPerNum},{currentPerNum}");
                    UC_TaskList.instance.renderNewList((pageID-1) * currentPerNum, currentPerNum);
                }
                else
                {
                    int range = orderList.Length - (pageNum - 1) * currentPerNum;
                    int start = currentPerNum * (pageNum - 1);
                    UC_TaskList.instance.renderNewList(start, range);
                }
            }
        }
    }
}
