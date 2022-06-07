namespace miniSys0._3.Controls.Setting
{
    partial class UC_Setting_Privacy
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
            this.components = new System.ComponentModel.Container();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.allowShowProfile = new Sunny.UI.UISwitch();
            this.allowSearch = new Sunny.UI.UISwitch();
            this.privateMode = new Sunny.UI.UISwitch();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.info = new Sunny.UI.UIAvatar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(25, 156);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(149, 23);
            this.uiLabel3.TabIndex = 15;
            this.uiLabel3.Text = "Private mode";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(25, 103);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(195, 44);
            this.uiLabel2.TabIndex = 14;
            this.uiLabel2.Text = "Public your information";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(25, 45);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(195, 49);
            this.uiLabel1.TabIndex = 13;
            this.uiLabel1.Text = "Allows to be searched by users.";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // allowShowProfile
            // 
            this.allowShowProfile.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.allowShowProfile.ActiveText = "On";
            this.allowShowProfile.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.allowShowProfile.InActiveText = "Off";
            this.allowShowProfile.Location = new System.Drawing.Point(260, 108);
            this.allowShowProfile.MinimumSize = new System.Drawing.Size(1, 1);
            this.allowShowProfile.Name = "allowShowProfile";
            this.allowShowProfile.Size = new System.Drawing.Size(75, 29);
            this.allowShowProfile.Style = Sunny.UI.UIStyle.Custom;
            this.allowShowProfile.TabIndex = 12;
            this.allowShowProfile.Text = "uiSwitch2";
            this.allowShowProfile.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.allowShowProfile.Click += new System.EventHandler(this.allowShowProfile_Click);
            // 
            // allowSearch
            // 
            this.allowSearch.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.allowSearch.ActiveText = "On";
            this.allowSearch.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.allowSearch.InActiveText = "Off";
            this.allowSearch.Location = new System.Drawing.Point(260, 56);
            this.allowSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.allowSearch.Name = "allowSearch";
            this.allowSearch.Size = new System.Drawing.Size(75, 29);
            this.allowSearch.Style = Sunny.UI.UIStyle.Custom;
            this.allowSearch.TabIndex = 11;
            this.allowSearch.Text = "uiSwitch1";
            this.allowSearch.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.allowSearch.Click += new System.EventHandler(this.allowSearch_Click);
            // 
            // privateMode
            // 
            this.privateMode.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.privateMode.ActiveText = "On";
            this.privateMode.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.privateMode.InActiveText = "Off";
            this.privateMode.Location = new System.Drawing.Point(260, 153);
            this.privateMode.MinimumSize = new System.Drawing.Size(1, 1);
            this.privateMode.Name = "privateMode";
            this.privateMode.Size = new System.Drawing.Size(75, 30);
            this.privateMode.Style = Sunny.UI.UIStyle.Custom;
            this.privateMode.TabIndex = 16;
            this.privateMode.Text = "uiSwitch3";
            this.privateMode.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.privateMode.Click += new System.EventHandler(this.privateMode_Click);
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine1.LineColor = System.Drawing.Color.Gainsboro;
            this.uiLine1.Location = new System.Drawing.Point(0, 188);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(360, 10);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 17;
            this.uiLine1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font(".萍方-简", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(25, 5);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(122, 31);
            this.uiLabel4.TabIndex = 19;
            this.uiLabel4.Text = "Privacy";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // info
            // 
            this.info.AvatarSize = 20;
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.info.Location = new System.Drawing.Point(215, 153);
            this.info.MinimumSize = new System.Drawing.Size(1, 1);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(30, 30);
            this.info.Style = Sunny.UI.UIStyle.Custom;
            this.info.Symbol = 61737;
            this.info.SymbolSize = 17;
            this.info.TabIndex = 100;
            this.info.Text = "uiAvatar1";
            this.info.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.info.MouseHover += new System.EventHandler(this.info_MouseHover);
            // 
            // UC_Setting_Privacy
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.info);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.privateMode);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.allowShowProfile);
            this.Controls.Add(this.allowSearch);
            this.Name = "UC_Setting_Privacy";
            this.Size = new System.Drawing.Size(360, 200);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UISwitch allowShowProfile;
        private Sunny.UI.UISwitch allowSearch;
        private Sunny.UI.UISwitch privateMode;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIAvatar info;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
