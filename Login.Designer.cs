namespace miniSys0._3
{
    partial class Login
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLeftSide = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelUpperLeft = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name_input = new Sunny.UI.UITextBox();
            this.showPws = new Sunny.UI.UICheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginButton = new Sunny.UI.UIButton();
            this.agreement = new Sunny.UI.UICheckBox();
            this.password_input = new Sunny.UI.UITextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeftSide
            // 
            this.panelLeftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(100)))), ((int)(((byte)(221)))));
            this.panelLeftSide.Controls.Add(this.pictureBox1);
            this.panelLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSide.Location = new System.Drawing.Point(0, 80);
            this.panelLeftSide.Name = "panelLeftSide";
            this.panelLeftSide.Size = new System.Drawing.Size(450, 720);
            this.panelLeftSide.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::miniSys0._3.Properties.Resources.loginDev;
            this.pictureBox1.Location = new System.Drawing.Point(3, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 346);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.FillColor = System.Drawing.Color.White;
            this.uiSymbolButton1.FillHoverColor = System.Drawing.Color.Red;
            this.uiSymbolButton1.FillPressColor = System.Drawing.Color.Red;
            this.uiSymbolButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.Location = new System.Drawing.Point(1289, -1);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Radius = 0;
            this.uiSymbolButton1.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton1.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton1.RectPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton1.Size = new System.Drawing.Size(52, 50);
            this.uiSymbolButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton1.Symbol = 77;
            this.uiSymbolButton1.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolButton1.SymbolSize = 50;
            this.uiSymbolButton1.TabIndex = 10;
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.pictureBox2);
            this.panelTop.Controls.Add(this.panelUpperLeft);
            this.panelTop.Controls.Add(this.uiSymbolButton1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1340, 80);
            this.panelTop.TabIndex = 11;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drag_down);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drag_move);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font(".萍方-简", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(541, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 52);
            this.label1.TabIndex = 12;
            this.label1.Text = "C# Inc";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::miniSys0._3.Properties.Resources.rocket_icon_128;
            this.pictureBox2.Location = new System.Drawing.Point(451, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // panelUpperLeft
            // 
            this.panelUpperLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(100)))), ((int)(((byte)(221)))));
            this.panelUpperLeft.Location = new System.Drawing.Point(0, 0);
            this.panelUpperLeft.Name = "panelUpperLeft";
            this.panelUpperLeft.Size = new System.Drawing.Size(450, 80);
            this.panelUpperLeft.TabIndex = 12;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::miniSys0._3.Properties.Resources.login_panel;
            this.pictureBox3.Location = new System.Drawing.Point(616, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(562, 602);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font(".萍方-简", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(661, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 52);
            this.label2.TabIndex = 13;
            this.label2.Text = "Welcome to C# Inc";
            // 
            // name_input
            // 
            this.name_input.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.name_input.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.name_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_input.Font = new System.Drawing.Font(".萍方-简", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.name_input.Location = new System.Drawing.Point(670, 261);
            this.name_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name_input.MinimumSize = new System.Drawing.Size(1, 16);
            this.name_input.Name = "name_input";
            this.name_input.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.name_input.Radius = 10;
            this.name_input.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.name_input.ShowText = false;
            this.name_input.Size = new System.Drawing.Size(463, 50);
            this.name_input.Style = Sunny.UI.UIStyle.Custom;
            this.name_input.TabIndex = 14;
            this.name_input.Text = "Enter the user name";
            this.name_input.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.name_input.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.name_input.Leave += new System.EventHandler(this.name_leave);
            this.name_input.Enter += new System.EventHandler(this.name_enter);
            // 
            // showPws
            // 
            this.showPws.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(100)))), ((int)(((byte)(221)))));
            this.showPws.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPws.Font = new System.Drawing.Font(".萍方-简", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showPws.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.showPws.ImageSize = 18;
            this.showPws.Location = new System.Drawing.Point(670, 450);
            this.showPws.MinimumSize = new System.Drawing.Size(1, 1);
            this.showPws.Name = "showPws";
            this.showPws.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.showPws.Size = new System.Drawing.Size(183, 29);
            this.showPws.Style = Sunny.UI.UIStyle.Custom;
            this.showPws.TabIndex = 16;
            this.showPws.Text = "Show password";
            this.showPws.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.showPws.CheckedChanged += new System.EventHandler(this.uiCheckBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font(".萍方-简", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.label3.Location = new System.Drawing.Point(952, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Forgot password?";
            // 
            // LoginButton
            // 
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.LoginButton.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(100)))), ((int)(((byte)(221)))));
            this.LoginButton.Font = new System.Drawing.Font(".萍方-简", 18F);
            this.LoginButton.Location = new System.Drawing.Point(670, 508);
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
            this.LoginButton.TabIndex = 18;
            this.LoginButton.Text = "Login";
            this.LoginButton.TipsFont = null;
            this.LoginButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.LoginButton.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // agreement
            // 
            this.agreement.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(100)))), ((int)(((byte)(221)))));
            this.agreement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agreement.Font = new System.Drawing.Font(".萍方-简", 15F);
            this.agreement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.agreement.ImageSize = 18;
            this.agreement.Location = new System.Drawing.Point(670, 596);
            this.agreement.MinimumSize = new System.Drawing.Size(1, 1);
            this.agreement.Name = "agreement";
            this.agreement.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.agreement.Size = new System.Drawing.Size(283, 29);
            this.agreement.Style = Sunny.UI.UIStyle.Custom;
            this.agreement.TabIndex = 19;
            this.agreement.Text = "I have read and accept the";
            this.agreement.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.agreement.CheckedChanged += new System.EventHandler(this.agreement_CheckedChanged);
            // 
            // password_input
            // 
            this.password_input.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.password_input.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.password_input.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.password_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_input.Font = new System.Drawing.Font(".萍方-简", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.password_input.Location = new System.Drawing.Point(670, 365);
            this.password_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.password_input.MinimumSize = new System.Drawing.Size(1, 16);
            this.password_input.Name = "password_input";
            this.password_input.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.password_input.Radius = 10;
            this.password_input.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.password_input.ShowText = false;
            this.password_input.Size = new System.Drawing.Size(463, 50);
            this.password_input.Style = Sunny.UI.UIStyle.Custom;
            this.password_input.TabIndex = 15;
            this.password_input.Text = "Enter your password";
            this.password_input.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.password_input.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.password_input.Leave += new System.EventHandler(this.pws_leave);
            this.password_input.Enter += new System.EventHandler(this.pwd_enter);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font(".萍方-简", 15F);
            this.linkLabel1.Location = new System.Drawing.Point(952, 596);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(177, 28);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Terms of Service ";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.Font = new System.Drawing.Font(".萍方-简", 15F);
            this.linkLabel2.Location = new System.Drawing.Point(734, 628);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(142, 28);
            this.linkLabel2.TabIndex = 21;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Privacy Policy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font(".萍方-简", 15F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.label4.Location = new System.Drawing.Point(691, 629);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "and";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font(".萍方-简", 15F);
            this.label5.Location = new System.Drawing.Point(871, 628);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 28);
            this.label5.TabIndex = 23;
            this.label5.Text = ".";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1340, 800);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.agreement);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showPws);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panelLeftSide);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form1";
            this.panelLeftSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftSide;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelUpperLeft;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UITextBox name_input;
        private Sunny.UI.UICheckBox showPws;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UIButton LoginButton;
        private Sunny.UI.UICheckBox agreement;
        private Sunny.UI.UITextBox password_input;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

