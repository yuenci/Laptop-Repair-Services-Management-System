namespace miniSys0._3
{
    partial class NotificationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationForm));
            this.icon = new Sunny.UI.UIAvatar();
            this.typeText = new Sunny.UI.UILabel();
            this.ok = new Sunny.UI.UIButton();
            this.cancel = new Sunny.UI.UIButton();
            this.content = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // icon
            // 
            this.icon.AvatarSize = 24;
            this.icon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.icon.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.icon.ForeColor = System.Drawing.Color.White;
            this.icon.Location = new System.Drawing.Point(16, 10);
            this.icon.MinimumSize = new System.Drawing.Size(1, 1);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(30, 30);
            this.icon.Style = Sunny.UI.UIStyle.Custom;
            this.icon.Symbol = 61737;
            this.icon.SymbolSize = 20;
            this.icon.TabIndex = 17;
            this.icon.Text = "uiAvatar2";
            this.icon.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // typeText
            // 
            this.typeText.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.typeText.Location = new System.Drawing.Point(52, 14);
            this.typeText.Name = "typeText";
            this.typeText.Size = new System.Drawing.Size(100, 30);
            this.typeText.TabIndex = 18;
            this.typeText.Text = "Notification";
            this.typeText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.typeText.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ok
            // 
            this.ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.ok.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ok.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ok.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ok.Location = new System.Drawing.Point(251, 103);
            this.ok.MinimumSize = new System.Drawing.Size(1, 1);
            this.ok.Name = "ok";
            this.ok.RectColor = System.Drawing.Color.Transparent;
            this.ok.RectHoverColor = System.Drawing.Color.Transparent;
            this.ok.RectPressColor = System.Drawing.Color.Transparent;
            this.ok.RectSelectedColor = System.Drawing.Color.Transparent;
            this.ok.Size = new System.Drawing.Size(77, 32);
            this.ok.Style = Sunny.UI.UIStyle.Custom;
            this.ok.TabIndex = 19;
            this.ok.Text = "OK";
            this.ok.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ok.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.cancel.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.cancel.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.cancel.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.cancel.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.cancel.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.cancel.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.cancel.Location = new System.Drawing.Point(149, 103);
            this.cancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.cancel.Name = "cancel";
            this.cancel.RectColor = System.Drawing.Color.Transparent;
            this.cancel.RectDisableColor = System.Drawing.Color.Transparent;
            this.cancel.RectHoverColor = System.Drawing.Color.Transparent;
            this.cancel.RectPressColor = System.Drawing.Color.Transparent;
            this.cancel.RectSelectedColor = System.Drawing.Color.Transparent;
            this.cancel.Size = new System.Drawing.Size(77, 32);
            this.cancel.Style = Sunny.UI.UIStyle.Custom;
            this.cancel.TabIndex = 20;
            this.cancel.Text = "Cancel";
            this.cancel.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // content
            // 
            this.content.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.content.Location = new System.Drawing.Point(20, 49);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(305, 47);
            this.content.TabIndex = 21;
            this.content.Text = "This is a notification!This is a notification!This is a notification!";
            this.content.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.content.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // NotificationForm
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 150);
            this.Controls.Add(this.content);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.typeText);
            this.Controls.Add(this.icon);
            this.Name = "NotificationForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowInTaskbar = false;
            this.ShowRect = false;
            this.ShowTitle = false;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = resources.GetString("$this.Text");
            this.TopMost = true;
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIAvatar icon;
        private Sunny.UI.UILabel typeText;
        private Sunny.UI.UIButton ok;
        private Sunny.UI.UIButton cancel;
        private Sunny.UI.UILabel content;
    }
}