namespace miniSys0._3.Controls
{
    partial class UC_Login
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.password_input = new Sunny.UI.UITextBox();
            this.agreement = new Sunny.UI.UICheckBox();
            this.LoginButton = new Sunny.UI.UIButton();
            this.forgot = new System.Windows.Forms.Label();
            this.showPws = new Sunny.UI.UICheckBox();
            this.name_input = new Sunny.UI.UITextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font(".萍方-简", 15F);
            this.label5.Location = new System.Drawing.Point(215, 494);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 28);
            this.label5.TabIndex = 34;
            this.label5.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font(".萍方-简", 15F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.label4.Location = new System.Drawing.Point(33, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 28);
            this.label4.TabIndex = 33;
            this.label4.Text = "and";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.Font = new System.Drawing.Font(".萍方-简", 15F);
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.linkLabel2.Location = new System.Drawing.Point(76, 494);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(142, 28);
            this.linkLabel2.TabIndex = 32;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Privacy Policy";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font(".萍方-简", 15F);
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(294, 462);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(177, 28);
            this.linkLabel1.TabIndex = 31;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Terms of Service ";
            // 
            // password_input
            // 
            this.password_input.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.password_input.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.password_input.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.password_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_input.Font = new System.Drawing.Font(".萍方-简", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.password_input.Location = new System.Drawing.Point(12, 237);
            this.password_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.password_input.MinimumSize = new System.Drawing.Size(1, 16);
            this.password_input.Name = "password_input";
            this.password_input.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.password_input.Radius = 10;
            this.password_input.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.password_input.ShowText = false;
            this.password_input.Size = new System.Drawing.Size(463, 50);
            this.password_input.Style = Sunny.UI.UIStyle.Custom;
            this.password_input.TabIndex = 26;
            this.password_input.Text = "Enter your password";
            this.password_input.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.password_input.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.password_input.Leave += new System.EventHandler(this.pws_leave);
            this.password_input.Enter += new System.EventHandler(this.pwd_enter);
            // 
            // agreement
            // 
            this.agreement.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(100)))), ((int)(((byte)(221)))));
            this.agreement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agreement.Font = new System.Drawing.Font(".萍方-简", 15F);
            this.agreement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.agreement.ImageSize = 18;
            this.agreement.Location = new System.Drawing.Point(12, 462);
            this.agreement.MinimumSize = new System.Drawing.Size(1, 1);
            this.agreement.Name = "agreement";
            this.agreement.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.agreement.Size = new System.Drawing.Size(283, 29);
            this.agreement.Style = Sunny.UI.UIStyle.Custom;
            this.agreement.TabIndex = 30;
            this.agreement.Text = "I have read and accept the";
            this.agreement.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.agreement.CheckedChanged += new System.EventHandler(this.agreement_CheckedChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.LoginButton.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(100)))), ((int)(((byte)(221)))));
            this.LoginButton.Font = new System.Drawing.Font(".萍方-简", 18F);
            this.LoginButton.Location = new System.Drawing.Point(12, 379);
            this.LoginButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Radius = 10;
            this.LoginButton.RectColor = System.Drawing.Color.Transparent;
            this.LoginButton.RectDisableColor = System.Drawing.Color.Transparent;
            this.LoginButton.RectHoverColor = System.Drawing.Color.Transparent;
            this.LoginButton.RectPressColor = System.Drawing.Color.Transparent;
            this.LoginButton.RectSelectedColor = System.Drawing.Color.Transparent;
            this.LoginButton.Size = new System.Drawing.Size(463, 50);
            this.LoginButton.Style = Sunny.UI.UIStyle.Custom;
            this.LoginButton.TabIndex = 29;
            this.LoginButton.Text = "Login";
            this.LoginButton.TipsFont = null;
            this.LoginButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // forgot
            // 
            this.forgot.AutoSize = true;
            this.forgot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgot.Font = new System.Drawing.Font(".萍方-简", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.forgot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.forgot.Location = new System.Drawing.Point(294, 322);
            this.forgot.Name = "forgot";
            this.forgot.Size = new System.Drawing.Size(181, 28);
            this.forgot.TabIndex = 28;
            this.forgot.Text = "Forgot password?";
            this.forgot.Click += new System.EventHandler(this.forgot_Click);
            // 
            // showPws
            // 
            this.showPws.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(100)))), ((int)(((byte)(221)))));
            this.showPws.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPws.Font = new System.Drawing.Font(".萍方-简", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showPws.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.showPws.ImageSize = 18;
            this.showPws.Location = new System.Drawing.Point(12, 322);
            this.showPws.MinimumSize = new System.Drawing.Size(1, 1);
            this.showPws.Name = "showPws";
            this.showPws.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.showPws.Size = new System.Drawing.Size(183, 29);
            this.showPws.Style = Sunny.UI.UIStyle.Custom;
            this.showPws.TabIndex = 27;
            this.showPws.Text = "Show password";
            this.showPws.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.showPws.CheckedChanged += new System.EventHandler(this.showPws_CheckedChanged);
            // 
            // name_input
            // 
            this.name_input.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.name_input.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.name_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_input.Font = new System.Drawing.Font(".萍方-简", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.name_input.Location = new System.Drawing.Point(12, 133);
            this.name_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name_input.MinimumSize = new System.Drawing.Size(1, 16);
            this.name_input.Name = "name_input";
            this.name_input.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.name_input.Radius = 10;
            this.name_input.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.name_input.ShowText = false;
            this.name_input.Size = new System.Drawing.Size(463, 50);
            this.name_input.Style = Sunny.UI.UIStyle.Custom;
            this.name_input.TabIndex = 25;
            this.name_input.Text = "Enter the user name";
            this.name_input.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.name_input.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.name_input.Leave += new System.EventHandler(this.name_leave);
            this.name_input.Enter += new System.EventHandler(this.name_enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font(".萍方-简", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 52);
            this.label2.TabIndex = 24;
            this.label2.Text = "Welcome to C# Inc";
            // 
            // UC_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.agreement);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.forgot);
            this.Controls.Add(this.showPws);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.label2);
            this.Name = "UC_Login";
            this.Size = new System.Drawing.Size(490, 530);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Sunny.UI.UITextBox password_input;
        private Sunny.UI.UICheckBox agreement;
        private Sunny.UI.UIButton LoginButton;
        private System.Windows.Forms.Label forgot;
        private Sunny.UI.UICheckBox showPws;
        private Sunny.UI.UITextBox name_input;
        private System.Windows.Forms.Label label2;
    }
}
