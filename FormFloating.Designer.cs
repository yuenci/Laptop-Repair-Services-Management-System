namespace miniSys0._3
{
    partial class FormFloating
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
            this.exitButton1 = new Sunny.UI.UISymbolButton();
            this.logoutButton2 = new Sunny.UI.UISymbolButton();
            this.icon = new Sunny.UI.UIAvatar();
            this.userName = new Sunny.UI.UILabel();
            this.userPost = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // exitButton1
            // 
            this.exitButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton1.FillColor = System.Drawing.Color.LightGray;
            this.exitButton1.FillHoverColor = System.Drawing.Color.DarkGray;
            this.exitButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exitButton1.ForeColor = System.Drawing.Color.Black;
            this.exitButton1.ForeHoverColor = System.Drawing.Color.Black;
            this.exitButton1.ForePressColor = System.Drawing.Color.Black;
            this.exitButton1.Location = new System.Drawing.Point(0, 253);
            this.exitButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Radius = 0;
            this.exitButton1.RectColor = System.Drawing.Color.Transparent;
            this.exitButton1.RectHoverColor = System.Drawing.Color.Transparent;
            this.exitButton1.RectPressColor = System.Drawing.Color.Transparent;
            this.exitButton1.RectSelectedColor = System.Drawing.Color.Transparent;
            this.exitButton1.Size = new System.Drawing.Size(250, 40);
            this.exitButton1.Style = Sunny.UI.UIStyle.Custom;
            this.exitButton1.Symbol = 61457;
            this.exitButton1.SymbolColor = System.Drawing.Color.Black;
            this.exitButton1.SymbolHoverColor = System.Drawing.Color.Black;
            this.exitButton1.SymbolOffset = new System.Drawing.Point(-77, 0);
            this.exitButton1.SymbolPressColor = System.Drawing.Color.Black;
            this.exitButton1.TabIndex = 10;
            this.exitButton1.Text = "Exit";
            this.exitButton1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exitButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.exitButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // logoutButton2
            // 
            this.logoutButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton2.FillColor = System.Drawing.Color.LightGray;
            this.logoutButton2.FillHoverColor = System.Drawing.Color.DarkGray;
            this.logoutButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logoutButton2.ForeColor = System.Drawing.Color.Black;
            this.logoutButton2.ForeHoverColor = System.Drawing.Color.Black;
            this.logoutButton2.ForePressColor = System.Drawing.Color.Black;
            this.logoutButton2.Location = new System.Drawing.Point(0, 212);
            this.logoutButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.logoutButton2.Name = "logoutButton2";
            this.logoutButton2.Radius = 0;
            this.logoutButton2.RectColor = System.Drawing.Color.Transparent;
            this.logoutButton2.RectHoverColor = System.Drawing.Color.Transparent;
            this.logoutButton2.RectPressColor = System.Drawing.Color.Transparent;
            this.logoutButton2.RectSelectedColor = System.Drawing.Color.Transparent;
            this.logoutButton2.Size = new System.Drawing.Size(250, 40);
            this.logoutButton2.Style = Sunny.UI.UIStyle.Custom;
            this.logoutButton2.Symbol = 362197;
            this.logoutButton2.SymbolColor = System.Drawing.Color.Black;
            this.logoutButton2.SymbolHoverColor = System.Drawing.Color.Black;
            this.logoutButton2.SymbolOffset = new System.Drawing.Point(-60, 0);
            this.logoutButton2.SymbolPressColor = System.Drawing.Color.Black;
            this.logoutButton2.TabIndex = 11;
            this.logoutButton2.Text = "Log out";
            this.logoutButton2.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logoutButton2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.logoutButton2.Click += new System.EventHandler(this.logoutButton2_Click);
            // 
            // icon
            // 
            this.icon.AvatarSize = 80;
            this.icon.Font = new System.Drawing.Font(".萍方-简", 40F, System.Drawing.FontStyle.Bold);
            this.icon.Icon = Sunny.UI.UIAvatar.UIIcon.Text;
            this.icon.Location = new System.Drawing.Point(85, 12);
            this.icon.MinimumSize = new System.Drawing.Size(1, 1);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(80, 80);
            this.icon.Style = Sunny.UI.UIStyle.Custom;
            this.icon.TabIndex = 12;
            this.icon.Text = "X";
            this.icon.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userName.Location = new System.Drawing.Point(0, 95);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(250, 33);
            this.userName.Style = Sunny.UI.UIStyle.Custom;
            this.userName.TabIndex = 15;
            this.userName.Text = "uiLabel1";
            this.userName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // userPost
            // 
            this.userPost.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userPost.Location = new System.Drawing.Point(0, 134);
            this.userPost.Name = "userPost";
            this.userPost.Size = new System.Drawing.Size(250, 33);
            this.userPost.Style = Sunny.UI.UIStyle.Custom;
            this.userPost.TabIndex = 16;
            this.userPost.Text = "uiLabel2";
            this.userPost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userPost.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // FormFloating
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(250, 300);
            this.ControlBox = false;
            this.Controls.Add(this.userPost);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.logoutButton2);
            this.Controls.Add(this.exitButton1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFloating";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.RectColor = System.Drawing.Color.Gainsboro;
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.ShowTitle = false;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "ProfileFloating";
            this.TopMost = true;
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton exitButton1;
        private Sunny.UI.UISymbolButton logoutButton2;
        private Sunny.UI.UIAvatar icon;
        private Sunny.UI.UILabel userName;
        private Sunny.UI.UILabel userPost;
    }
}