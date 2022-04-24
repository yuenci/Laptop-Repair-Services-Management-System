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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelTop = new System.Windows.Forms.Panel();
            this.searchBox = new Sunny.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.searchIcon = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton3 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.profile = new Sunny.UI.UIAvatar();
            this.uiUserControl1 = new Sunny.UI.UIUserControl();
            this.navMenuPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.uiUserControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            resources.ApplyResources(this.panelTop, "panelTop");
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.searchBox);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.pictureBox2);
            this.panelTop.Controls.Add(this.searchIcon);
            this.panelTop.Controls.Add(this.uiSymbolButton3);
            this.panelTop.Controls.Add(this.uiSymbolButton2);
            this.panelTop.Controls.Add(this.uiSymbolButton1);
            this.panelTop.Controls.Add(this.profile);
            this.panelTop.Name = "panelTop";
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drag_down);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drag_move);
            // 
            // searchBox
            // 
            resources.ApplyResources(this.searchBox, "searchBox");
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.Name = "searchBox";
            this.searchBox.Radius = 30;
            this.searchBox.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.searchBox.ShowText = false;
            this.searchBox.Style = Sunny.UI.UIStyle.Custom;
            this.searchBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
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
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::miniSys0._3.Properties.Resources.rocket_icon_128;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // searchIcon
            // 
            resources.ApplyResources(this.searchIcon, "searchIcon");
            this.searchIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchIcon.FillColor = System.Drawing.Color.White;
            this.searchIcon.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
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
            this.searchIcon.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchIcon.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.searchIcon.Click += new System.EventHandler(this.searchIcon_Click);
            // 
            // uiSymbolButton3
            // 
            resources.ApplyResources(this.uiSymbolButton3, "uiSymbolButton3");
            this.uiSymbolButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton3.FillColor = System.Drawing.Color.White;
            this.uiSymbolButton3.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.uiSymbolButton3.Name = "uiSymbolButton3";
            this.uiSymbolButton3.Radius = 32;
            this.uiSymbolButton3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.uiSymbolButton3.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.uiSymbolButton3.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.uiSymbolButton3.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.uiSymbolButton3.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.uiSymbolButton3.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton3.Symbol = 61506;
            this.uiSymbolButton3.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolButton3.SymbolHoverColor = System.Drawing.Color.Black;
            this.uiSymbolButton3.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolButton2
            // 
            resources.ApplyResources(this.uiSymbolButton2, "uiSymbolButton2");
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.FillColor = System.Drawing.Color.White;
            this.uiSymbolButton2.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.Radius = 32;
            this.uiSymbolButton2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.uiSymbolButton2.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.uiSymbolButton2.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.uiSymbolButton2.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.uiSymbolButton2.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.uiSymbolButton2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton2.Symbol = 61683;
            this.uiSymbolButton2.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolButton2.SymbolHoverColor = System.Drawing.Color.Black;
            this.uiSymbolButton2.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolButton1
            // 
            resources.ApplyResources(this.uiSymbolButton1, "uiSymbolButton1");
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.FillColor = System.Drawing.Color.White;
            this.uiSymbolButton1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
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
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // profile
            // 
            resources.ApplyResources(this.profile, "profile");
            this.profile.AvatarSize = 32;
            this.profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.profile.ForeColor = System.Drawing.Color.Black;
            this.profile.Icon = Sunny.UI.UIAvatar.UIIcon.Text;
            this.profile.Name = "profile";
            this.profile.Style = Sunny.UI.UIStyle.Custom;
            this.profile.Symbol = 61453;
            this.profile.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // uiUserControl1
            // 
            resources.ApplyResources(this.uiUserControl1, "uiUserControl1");
            this.uiUserControl1.BackColor = System.Drawing.Color.White;
            this.uiUserControl1.Controls.Add(this.navMenuPanel);
            this.uiUserControl1.FillColor = System.Drawing.Color.White;
            this.uiUserControl1.Name = "uiUserControl1";
            this.uiUserControl1.Radius = 10;
            this.uiUserControl1.RectColor = System.Drawing.Color.Gainsboro;
            this.uiUserControl1.Style = Sunny.UI.UIStyle.Custom;
            this.uiUserControl1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiUserControl1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // navMenuPanel
            // 
            resources.ApplyResources(this.navMenuPanel, "navMenuPanel");
            this.navMenuPanel.Name = "navMenuPanel";
            // 
            // mainPanel
            // 
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.Name = "mainPanel";
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
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.uiUserControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private Sunny.UI.UIAvatar profile;
        private Sunny.UI.UISymbolButton searchIcon;
        private Sunny.UI.UISymbolButton uiSymbolButton3;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UIUserControl uiUserControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Sunny.UI.UITextBox searchBox;
        private System.Windows.Forms.Panel navMenuPanel;
        public System.Windows.Forms.Panel mainPanel;
    }
}