namespace miniSys0._3.Controls.Setting
{
    partial class UC_Setting_General
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.auto = new Sunny.UI.UISwitch();
            this.theme = new Sunny.UI.UISwitch();
            this.homePage = new Sunny.UI.UIComboBox();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(25, 143);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(149, 23);
            this.uiLabel3.TabIndex = 9;
            this.uiLabel3.Text = "Home page";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(25, 97);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(103, 23);
            this.uiLabel2.TabIndex = 8;
            this.uiLabel2.Text = "Auto theme";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(25, 51);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(122, 23);
            this.uiLabel1.TabIndex = 7;
            this.uiLabel1.Text = "Default theme";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // auto
            // 
            this.auto.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.auto.ActiveText = "On";
            this.auto.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.auto.InActiveText = "Off";
            this.auto.Location = new System.Drawing.Point(260, 97);
            this.auto.MinimumSize = new System.Drawing.Size(1, 1);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(75, 29);
            this.auto.Style = Sunny.UI.UIStyle.Custom;
            this.auto.TabIndex = 6;
            this.auto.Text = "uiSwitch2";
            this.auto.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.auto.Click += new System.EventHandler(this.auto_Click);
            // 
            // theme
            // 
            this.theme.ActiveColor = System.Drawing.Color.Black;
            this.theme.ActiveText = "Dark";
            this.theme.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.theme.InActiveText = "Light";
            this.theme.Location = new System.Drawing.Point(260, 45);
            this.theme.MinimumSize = new System.Drawing.Size(1, 1);
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(75, 29);
            this.theme.Style = Sunny.UI.UIStyle.Custom;
            this.theme.TabIndex = 5;
            this.theme.Text = "uiSwitch1";
            this.theme.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.theme.Click += new System.EventHandler(this.theme_Click);
            // 
            // homePage
            // 
            this.homePage.DataSource = null;
            this.homePage.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.homePage.DropDownWidth = 200;
            this.homePage.FillColor = System.Drawing.Color.White;
            this.homePage.FilterMaxCount = 50;
            this.homePage.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.homePage.Location = new System.Drawing.Point(145, 143);
            this.homePage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.homePage.MinimumSize = new System.Drawing.Size(63, 0);
            this.homePage.Name = "homePage";
            this.homePage.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.homePage.RectColor = System.Drawing.Color.Gainsboro;
            this.homePage.Size = new System.Drawing.Size(190, 29);
            this.homePage.Style = Sunny.UI.UIStyle.Custom;
            this.homePage.TabIndex = 10;
            this.homePage.Text = "lala";
            this.homePage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.homePage.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.homePage.DropDownClosed += new System.EventHandler(this.homePage_DropDownClosed);
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine1.LineColor = System.Drawing.Color.Gainsboro;
            this.uiLine1.Location = new System.Drawing.Point(0, 189);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(360, 10);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 11;
            this.uiLine1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font(".萍方-简", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(25, 5);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(122, 23);
            this.uiLabel4.TabIndex = 12;
            this.uiLabel4.Text = "General";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // UC_Setting_General
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.homePage);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.auto);
            this.Controls.Add(this.theme);
            this.Name = "UC_Setting_General";
            this.Size = new System.Drawing.Size(360, 200);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UISwitch auto;
        private Sunny.UI.UISwitch theme;
        private Sunny.UI.UIComboBox homePage;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILabel uiLabel4;
    }
}
