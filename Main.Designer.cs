namespace miniSys0._3
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelTop = new System.Windows.Forms.Panel();
            this.searchBox = new Sunny.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.searchIcon = new Sunny.UI.UISymbolButton();
            this.swithTheme = new Sunny.UI.UISymbolButton();
            this.message = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.profile = new Sunny.UI.UIAvatar();
            this.uiUserControl1 = new Sunny.UI.UIUserControl();
            this.copyRight = new Sunny.UI.UILabel();
            this.navMenuPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CSharpInc = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenuStrip = new Sunny.UI.UIContextMenuStrip();
            this.minimize = new System.Windows.Forms.ToolStripMenuItem();
            this.maximize = new System.Windows.Forms.ToolStripMenuItem();
            this.restart = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.exist = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.uiUserControl1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.searchBox);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.pictureBox2);
            this.panelTop.Controls.Add(this.searchIcon);
            this.panelTop.Controls.Add(this.swithTheme);
            this.panelTop.Controls.Add(this.message);
            this.panelTop.Controls.Add(this.uiSymbolButton1);
            this.panelTop.Controls.Add(this.profile);
            resources.ApplyResources(this.panelTop, "panelTop");
            this.panelTop.Name = "panelTop";
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drag_down);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drag_move);
            // 
            // searchBox
            // 
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.searchBox, "searchBox");
            this.searchBox.Name = "searchBox";
            this.searchBox.Radius = 30;
            this.searchBox.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.searchBox.ShowText = false;
            this.searchBox.Style = Sunny.UI.UIStyle.Custom;
            this.searchBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.Leave += new System.EventHandler(this.search_leave);
            this.searchBox.Enter += new System.EventHandler(this.search_enter);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::miniSys0._3.Properties.Resources.rocket_icon_128;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // searchIcon
            // 
            this.searchIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchIcon.FillColor = System.Drawing.Color.White;
            this.searchIcon.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            resources.ApplyResources(this.searchIcon, "searchIcon");
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Radius = 32;
            this.searchIcon.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.searchIcon.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.searchIcon.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.searchIcon.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.searchIcon.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.searchIcon.Style = Sunny.UI.UIStyle.Custom;
            this.searchIcon.Symbol = 61442;
            this.searchIcon.SymbolColor = System.Drawing.Color.Black;
            this.searchIcon.SymbolHoverColor = System.Drawing.Color.Black;
            this.searchIcon.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchIcon.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.searchIcon.Click += new System.EventHandler(this.searchIcon_Click);
            // 
            // swithTheme
            // 
            this.swithTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swithTheme.FillColor = System.Drawing.Color.White;
            this.swithTheme.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            resources.ApplyResources(this.swithTheme, "swithTheme");
            this.swithTheme.Name = "swithTheme";
            this.swithTheme.Radius = 32;
            this.swithTheme.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.swithTheme.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.swithTheme.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.swithTheme.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.swithTheme.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.swithTheme.Style = Sunny.UI.UIStyle.Custom;
            this.swithTheme.Symbol = 61506;
            this.swithTheme.SymbolColor = System.Drawing.Color.Black;
            this.swithTheme.SymbolHoverColor = System.Drawing.Color.Black;
            this.swithTheme.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.swithTheme.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.swithTheme.Click += new System.EventHandler(this.uiSymbolButton3_Click);
            // 
            // message
            // 
            this.message.Cursor = System.Windows.Forms.Cursors.Hand;
            this.message.FillColor = System.Drawing.Color.White;
            this.message.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            resources.ApplyResources(this.message, "message");
            this.message.Name = "message";
            this.message.Radius = 32;
            this.message.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.message.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.message.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.message.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.message.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.message.Style = Sunny.UI.UIStyle.Custom;
            this.message.Symbol = 61683;
            this.message.SymbolColor = System.Drawing.Color.Black;
            this.message.SymbolHoverColor = System.Drawing.Color.Black;
            this.message.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.message.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.message.Click += new System.EventHandler(this.uiSymbolButton2_Click);
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.FillColor = System.Drawing.Color.White;
            this.uiSymbolButton1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            resources.ApplyResources(this.uiSymbolButton1, "uiSymbolButton1");
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Radius = 32;
            this.uiSymbolButton1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.uiSymbolButton1.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.uiSymbolButton1.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.uiSymbolButton1.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.uiSymbolButton1.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.uiSymbolButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton1.Symbol = 57399;
            this.uiSymbolButton1.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolButton1.SymbolHoverColor = System.Drawing.Color.Black;
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // profile
            // 
            this.profile.AvatarSize = 32;
            this.profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.profile, "profile");
            this.profile.ForeColor = System.Drawing.Color.Black;
            this.profile.Icon = Sunny.UI.UIAvatar.UIIcon.Text;
            this.profile.Image = ((System.Drawing.Image)(resources.GetObject("profile.Image")));
            this.profile.Name = "profile";
            this.profile.Style = Sunny.UI.UIStyle.Custom;
            this.profile.Symbol = 61453;
            this.profile.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // uiUserControl1
            // 
            this.uiUserControl1.BackColor = System.Drawing.Color.White;
            this.uiUserControl1.Controls.Add(this.copyRight);
            this.uiUserControl1.Controls.Add(this.navMenuPanel);
            this.uiUserControl1.FillColor = System.Drawing.Color.White;
            resources.ApplyResources(this.uiUserControl1, "uiUserControl1");
            this.uiUserControl1.Name = "uiUserControl1";
            this.uiUserControl1.Radius = 10;
            this.uiUserControl1.RectColor = System.Drawing.Color.Gainsboro;
            this.uiUserControl1.Style = Sunny.UI.UIStyle.Custom;
            this.uiUserControl1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiUserControl1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // copyRight
            // 
            resources.ApplyResources(this.copyRight, "copyRight");
            this.copyRight.Name = "copyRight";
            this.copyRight.Style = Sunny.UI.UIStyle.Custom;
            this.copyRight.TagString = "";
            this.copyRight.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // navMenuPanel
            // 
            resources.ApplyResources(this.navMenuPanel, "navMenuPanel");
            this.navMenuPanel.Name = "navMenuPanel";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.webBrowser1);
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.Name = "mainPanel";
            // 
            // webBrowser1
            // 
            resources.ApplyResources(this.webBrowser1, "webBrowser1");
            this.webBrowser1.Name = "webBrowser1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CSharpInc
            // 
            this.CSharpInc.ContextMenuStrip = this.ContextMenuStrip;
            resources.ApplyResources(this.CSharpInc, "CSharpInc");
            this.CSharpInc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.ContextMenuStrip, "ContextMenuStrip");
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimize,
            this.maximize,
            this.restart,
            this.logout,
            this.exist});
            this.ContextMenuStrip.Name = "ContextMenuStrip";
            this.ContextMenuStrip.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip_Opening);
            // 
            // minimize
            // 
            resources.ApplyResources(this.minimize, "minimize");
            this.minimize.Name = "minimize";
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // maximize
            // 
            resources.ApplyResources(this.maximize, "maximize");
            this.maximize.Name = "maximize";
            this.maximize.Click += new System.EventHandler(this.maximize_Click);
            // 
            // restart
            // 
            this.restart.Name = "restart";
            resources.ApplyResources(this.restart, "restart");
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // logout
            // 
            this.logout.Name = "logout";
            resources.ApplyResources(this.logout, "logout");
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // exist
            // 
            this.exist.Name = "exist";
            resources.ApplyResources(this.exist, "exist");
            this.exist.Click += new System.EventHandler(this.exist_Click);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.uiUserControl1);
            this.Controls.Add(this.panelTop);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.uiUserControl1.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private Sunny.UI.UIAvatar profile;
        private Sunny.UI.UISymbolButton searchIcon;
        private Sunny.UI.UISymbolButton swithTheme;
        private Sunny.UI.UISymbolButton message;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UIUserControl uiUserControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public Sunny.UI.UITextBox searchBox;
        private System.Windows.Forms.Panel navMenuPanel;
        public System.Windows.Forms.Panel mainPanel;
        private Sunny.UI.UILabel copyRight;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.NotifyIcon CSharpInc;
        private Sunny.UI.UIContextMenuStrip ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem minimize;
        private System.Windows.Forms.ToolStripMenuItem maximize;
        private System.Windows.Forms.ToolStripMenuItem restart;
        private System.Windows.Forms.ToolStripMenuItem logout;
        private System.Windows.Forms.ToolStripMenuItem exist;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}