namespace miniSys0._3.Controls.Others
{
    partial class UC_BasicInfo
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ResetButton = new Sunny.UI.UIButton();
            this.profile = new Sunny.UI.UITextBox();
            this.OKButton = new Sunny.UI.UIButton();
            this.address = new Sunny.UI.UITextBox();
            this.street = new Sunny.UI.UITextBox();
            this.country = new Sunny.UI.UITextBox();
            this.name = new Sunny.UI.UITextBox();
            this.email = new Sunny.UI.UITextBox();
            this.uiLabel16 = new Sunny.UI.UILabel();
            this.uiLabel15 = new Sunny.UI.UILabel();
            this.uiLabel14 = new Sunny.UI.UILabel();
            this.uiLabel13 = new Sunny.UI.UILabel();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(101, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 27);
            this.label4.TabIndex = 29;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(18, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 27);
            this.label3.TabIndex = 28;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(96, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 27);
            this.label2.TabIndex = 27;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(101, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 27);
            this.label1.TabIndex = 26;
            this.label1.Text = "*";
            // 
            // ResetButton
            // 
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ResetButton.Location = new System.Drawing.Point(316, 390);
            this.ResetButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Radius = 2;
            this.ResetButton.Size = new System.Drawing.Size(65, 35);
            this.ResetButton.Style = Sunny.UI.UIStyle.Custom;
            this.ResetButton.TabIndex = 18;
            this.ResetButton.Text = "Reset";
            this.ResetButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ResetButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // profile
            // 
            this.profile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.profile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.profile.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.profile.ForeColor = System.Drawing.Color.Gray;
            this.profile.Location = new System.Drawing.Point(210, 290);
            this.profile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.profile.MinimumSize = new System.Drawing.Size(1, 16);
            this.profile.Multiline = true;
            this.profile.Name = "profile";
            this.profile.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.profile.Radius = 2;
            this.profile.RectColor = System.Drawing.Color.White;
            this.profile.ShowText = false;
            this.profile.Size = new System.Drawing.Size(366, 88);
            this.profile.Style = Sunny.UI.UIStyle.Custom;
            this.profile.TabIndex = 24;
            this.profile.Text = "Please enter your personal introduction with a maximum of 300 characters.";
            this.profile.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.profile.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.profile.Leave += new System.EventHandler(this.profile_Leave_1);
            this.profile.Enter += new System.EventHandler(this.profile_Enter);
            // 
            // OKButton
            // 
            this.OKButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OKButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OKButton.Location = new System.Drawing.Point(210, 390);
            this.OKButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.OKButton.Name = "OKButton";
            this.OKButton.Radius = 2;
            this.OKButton.Size = new System.Drawing.Size(65, 35);
            this.OKButton.Style = Sunny.UI.UIStyle.Custom;
            this.OKButton.TabIndex = 17;
            this.OKButton.Text = "OK";
            this.OKButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OKButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // address
            // 
            this.address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.address.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.address.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.address.ForeColor = System.Drawing.Color.Gray;
            this.address.Location = new System.Drawing.Point(210, 235);
            this.address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.address.MinimumSize = new System.Drawing.Size(1, 16);
            this.address.Name = "address";
            this.address.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.address.Radius = 2;
            this.address.RectColor = System.Drawing.Color.White;
            this.address.ShowText = false;
            this.address.Size = new System.Drawing.Size(366, 40);
            this.address.Style = Sunny.UI.UIStyle.Custom;
            this.address.TabIndex = 23;
            this.address.Text = "Enter the detailed address";
            this.address.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.address.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.address.Leave += new System.EventHandler(this.address_Leave_1);
            this.address.Enter += new System.EventHandler(this.address_Enter);
            // 
            // street
            // 
            this.street.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.street.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.street.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.street.ForeColor = System.Drawing.Color.Gray;
            this.street.Location = new System.Drawing.Point(210, 180);
            this.street.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.street.MinimumSize = new System.Drawing.Size(1, 16);
            this.street.Name = "street";
            this.street.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.street.Radius = 2;
            this.street.RectColor = System.Drawing.Color.White;
            this.street.ShowText = false;
            this.street.Size = new System.Drawing.Size(366, 40);
            this.street.Style = Sunny.UI.UIStyle.Custom;
            this.street.TabIndex = 22;
            this.street.Text = "Enter the street where you live";
            this.street.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.street.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.street.Leave += new System.EventHandler(this.street_Leave_1);
            this.street.Enter += new System.EventHandler(this.street_Enter);
            // 
            // country
            // 
            this.country.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.country.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.country.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.country.ForeColor = System.Drawing.Color.Gray;
            this.country.Location = new System.Drawing.Point(210, 125);
            this.country.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.country.MinimumSize = new System.Drawing.Size(1, 16);
            this.country.Name = "country";
            this.country.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.country.Radius = 2;
            this.country.RectColor = System.Drawing.Color.White;
            this.country.ShowText = false;
            this.country.Size = new System.Drawing.Size(366, 40);
            this.country.Style = Sunny.UI.UIStyle.Custom;
            this.country.TabIndex = 25;
            this.country.Text = "Enter your country";
            this.country.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.country.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.country.Leave += new System.EventHandler(this.country_Leave_1);
            this.country.Enter += new System.EventHandler(this.country_Enter);
            // 
            // name
            // 
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.name.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.ForeColor = System.Drawing.Color.Gray;
            this.name.Location = new System.Drawing.Point(210, 70);
            this.name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name.MinimumSize = new System.Drawing.Size(1, 16);
            this.name.Name = "name";
            this.name.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.name.Radius = 2;
            this.name.RectColor = System.Drawing.Color.White;
            this.name.ShowText = false;
            this.name.Size = new System.Drawing.Size(366, 40);
            this.name.Style = Sunny.UI.UIStyle.Custom;
            this.name.TabIndex = 21;
            this.name.Text = "Enter your name";
            this.name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.name.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.name.Leave += new System.EventHandler(this.name_Leave_1);
            this.name.Enter += new System.EventHandler(this.name_Enter);
            // 
            // email
            // 
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.email.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.email.ForeColor = System.Drawing.Color.Gray;
            this.email.Location = new System.Drawing.Point(210, 15);
            this.email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.email.MinimumSize = new System.Drawing.Size(1, 16);
            this.email.Name = "email";
            this.email.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.email.Radius = 2;
            this.email.RectColor = System.Drawing.Color.White;
            this.email.ShowText = false;
            this.email.Size = new System.Drawing.Size(366, 40);
            this.email.Style = Sunny.UI.UIStyle.Custom;
            this.email.TabIndex = 20;
            this.email.Text = "Enter your email address";
            this.email.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.email.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.email.Leave += new System.EventHandler(this.email_Leave_1);
            this.email.Enter += new System.EventHandler(this.email_enter);
            // 
            // uiLabel16
            // 
            this.uiLabel16.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel16.Location = new System.Drawing.Point(19, 294);
            this.uiLabel16.Name = "uiLabel16";
            this.uiLabel16.Size = new System.Drawing.Size(156, 23);
            this.uiLabel16.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel16.TabIndex = 19;
            this.uiLabel16.Text = "Personal profile";
            this.uiLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel16.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel15
            // 
            this.uiLabel15.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel15.Location = new System.Drawing.Point(15, 240);
            this.uiLabel15.Name = "uiLabel15";
            this.uiLabel15.Size = new System.Drawing.Size(160, 23);
            this.uiLabel15.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel15.TabIndex = 16;
            this.uiLabel15.TagString = "";
            this.uiLabel15.Text = "Detailed address";
            this.uiLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel15.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel14
            // 
            this.uiLabel14.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel14.Location = new System.Drawing.Point(75, 186);
            this.uiLabel14.Name = "uiLabel14";
            this.uiLabel14.Size = new System.Drawing.Size(100, 23);
            this.uiLabel14.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel14.TabIndex = 15;
            this.uiLabel14.Text = "Street";
            this.uiLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel14.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel13
            // 
            this.uiLabel13.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel13.Location = new System.Drawing.Point(2, 132);
            this.uiLabel13.Name = "uiLabel13";
            this.uiLabel13.Size = new System.Drawing.Size(173, 23);
            this.uiLabel13.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel13.TabIndex = 14;
            this.uiLabel13.Text = "Country / region";
            this.uiLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel13.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel12
            // 
            this.uiLabel12.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel12.Location = new System.Drawing.Point(75, 78);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(100, 23);
            this.uiLabel12.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel12.TabIndex = 13;
            this.uiLabel12.Text = "Name:";
            this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel12.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel11
            // 
            this.uiLabel11.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel11.Location = new System.Drawing.Point(75, 24);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(100, 23);
            this.uiLabel11.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel11.TabIndex = 12;
            this.uiLabel11.Text = "Email:";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel11.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // UC_BasicInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.address);
            this.Controls.Add(this.street);
            this.Controls.Add(this.country);
            this.Controls.Add(this.name);
            this.Controls.Add(this.email);
            this.Controls.Add(this.uiLabel16);
            this.Controls.Add(this.uiLabel15);
            this.Controls.Add(this.uiLabel14);
            this.Controls.Add(this.uiLabel13);
            this.Controls.Add(this.uiLabel12);
            this.Controls.Add(this.uiLabel11);
            this.Name = "UC_BasicInfo";
            this.Size = new System.Drawing.Size(610, 440);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIButton ResetButton;
        private Sunny.UI.UITextBox profile;
        private Sunny.UI.UIButton OKButton;
        private Sunny.UI.UITextBox address;
        private Sunny.UI.UITextBox street;
        private Sunny.UI.UITextBox country;
        private Sunny.UI.UITextBox name;
        private Sunny.UI.UITextBox email;
        private Sunny.UI.UILabel uiLabel16;
        private Sunny.UI.UILabel uiLabel15;
        private Sunny.UI.UILabel uiLabel14;
        private Sunny.UI.UILabel uiLabel13;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UILabel uiLabel11;
    }
}
