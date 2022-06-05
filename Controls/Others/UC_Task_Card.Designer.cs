namespace miniSys0._3.Controls.Others
{
    partial class UC_Task_Card
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
            this.uiLine1 = new Sunny.UI.UILine();
            this.avatar = new Sunny.UI.UIAvatar();
            this.edit = new Sunny.UI.UIAvatar();
            this.time = new Sunny.UI.UILabel();
            this.model = new Sunny.UI.UILabel();
            this.service = new System.Windows.Forms.Label();
            this.more = new Sunny.UI.UIAvatar();
            this.start = new Sunny.UI.UIAvatar();
            this.done = new Sunny.UI.UIAvatar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.uiUserControl1 = new Sunny.UI.UIUserControl();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.uiUserControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine1.Location = new System.Drawing.Point(3, 36);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(280, 10);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 0;
            this.uiLine1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // avatar
            // 
            this.avatar.AvatarSize = 30;
            this.avatar.BackColor = System.Drawing.Color.Transparent;
            this.avatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avatar.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.avatar.Icon = Sunny.UI.UIAvatar.UIIcon.Text;
            this.avatar.Location = new System.Drawing.Point(7, 102);
            this.avatar.MinimumSize = new System.Drawing.Size(1, 1);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(32, 32);
            this.avatar.Style = Sunny.UI.UIStyle.Custom;
            this.avatar.Symbol = 0;
            this.avatar.SymbolSize = 30;
            this.avatar.TabIndex = 2;
            this.avatar.Text = "I";
            this.avatar.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.avatar.Click += new System.EventHandler(this.avatar_Click);
            this.avatar.MouseHover += new System.EventHandler(this.avatar_MouseHover);
            // 
            // edit
            // 
            this.edit.AvatarSize = 32;
            this.edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.edit.Location = new System.Drawing.Point(227, 2);
            this.edit.MinimumSize = new System.Drawing.Size(1, 1);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(32, 32);
            this.edit.Style = Sunny.UI.UIStyle.Custom;
            this.edit.Symbol = 108;
            this.edit.SymbolSize = 30;
            this.edit.TabIndex = 4;
            this.edit.Text = "uiAvatar2";
            this.edit.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font(".萍方-简", 12F);
            this.time.Location = new System.Drawing.Point(45, 107);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(163, 23);
            this.time.Style = Sunny.UI.UIStyle.Custom;
            this.time.TabIndex = 6;
            this.time.Text = "2022-04-29 23:44:00";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.time.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // model
            // 
            this.model.BackColor = System.Drawing.Color.Transparent;
            this.model.Font = new System.Drawing.Font(".萍方-简", 12F);
            this.model.Location = new System.Drawing.Point(3, 7);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(177, 23);
            this.model.Style = Sunny.UI.UIStyle.Custom;
            this.model.TabIndex = 7;
            this.model.Text = "Dell ModelDe3";
            this.model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.model.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // service
            // 
            this.service.BackColor = System.Drawing.Color.Transparent;
            this.service.Cursor = System.Windows.Forms.Cursors.Hand;
            this.service.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.service.Location = new System.Drawing.Point(7, 46);
            this.service.Name = "service";
            this.service.Size = new System.Drawing.Size(290, 53);
            this.service.TabIndex = 8;
            this.service.Text = "Troubleshot and fix computer running slow";
            this.service.Click += new System.EventHandler(this.service_Click);
            // 
            // more
            // 
            this.more.AvatarSize = 32;
            this.more.Cursor = System.Windows.Forms.Cursors.Hand;
            this.more.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.more.Location = new System.Drawing.Point(265, 2);
            this.more.MinimumSize = new System.Drawing.Size(1, 1);
            this.more.Name = "more";
            this.more.Size = new System.Drawing.Size(32, 32);
            this.more.Style = Sunny.UI.UIStyle.Custom;
            this.more.Symbol = 48;
            this.more.SymbolSize = 30;
            this.more.TabIndex = 9;
            this.more.Text = "uiAvatar3";
            this.more.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.more.Click += new System.EventHandler(this.more_Click);
            // 
            // start
            // 
            this.start.AvatarSize = 32;
            this.start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.start.Location = new System.Drawing.Point(227, 102);
            this.start.MinimumSize = new System.Drawing.Size(1, 1);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(32, 32);
            this.start.Style = Sunny.UI.UIStyle.Custom;
            this.start.Symbol = 73;
            this.start.SymbolSize = 30;
            this.start.TabIndex = 10;
            this.start.Text = "uiAvatar4";
            this.start.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.start.Click += new System.EventHandler(this.start_Click);
            this.start.MouseHover += new System.EventHandler(this.start_MouseHover);
            // 
            // done
            // 
            this.done.AvatarSize = 32;
            this.done.Cursor = System.Windows.Forms.Cursors.Hand;
            this.done.Enabled = false;
            this.done.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.done.Location = new System.Drawing.Point(265, 102);
            this.done.MinimumSize = new System.Drawing.Size(1, 1);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(32, 32);
            this.done.Style = Sunny.UI.UIStyle.Custom;
            this.done.Symbol = 78;
            this.done.SymbolSize = 30;
            this.done.TabIndex = 11;
            this.done.Text = "uiAvatar5";
            this.done.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.done.Click += new System.EventHandler(this.done_Click);
            this.done.MouseHover += new System.EventHandler(this.done_MouseHover);
            // 
            // uiUserControl1
            // 
            this.uiUserControl1.Controls.Add(this.more);
            this.uiUserControl1.Controls.Add(this.edit);
            this.uiUserControl1.Controls.Add(this.model);
            this.uiUserControl1.Controls.Add(this.service);
            this.uiUserControl1.Controls.Add(this.done);
            this.uiUserControl1.Controls.Add(this.uiLine1);
            this.uiUserControl1.Controls.Add(this.start);
            this.uiUserControl1.Controls.Add(this.avatar);
            this.uiUserControl1.Controls.Add(this.time);
            this.uiUserControl1.FillColor = System.Drawing.Color.White;
            this.uiUserControl1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiUserControl1.Location = new System.Drawing.Point(3, 2);
            this.uiUserControl1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiUserControl1.Name = "uiUserControl1";
            this.uiUserControl1.RectColor = System.Drawing.Color.Gainsboro;
            this.uiUserControl1.Size = new System.Drawing.Size(300, 140);
            this.uiUserControl1.Style = Sunny.UI.UIStyle.Custom;
            this.uiUserControl1.TabIndex = 12;
            this.uiUserControl1.Text = "uiUserControl1";
            this.uiUserControl1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiUserControl1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // UC_Task_Card
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uiUserControl1);
            this.Name = "UC_Task_Card";
            this.Size = new System.Drawing.Size(305, 145);
            this.uiUserControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UIAvatar avatar;
        private Sunny.UI.UIAvatar edit;
        private Sunny.UI.UILabel time;
        private Sunny.UI.UILabel model;
        private System.Windows.Forms.Label service;
        private Sunny.UI.UIAvatar more;
        private Sunny.UI.UIAvatar start;
        private Sunny.UI.UIAvatar done;
        private System.Windows.Forms.ToolTip toolTip1;
        private Sunny.UI.UIUserControl uiUserControl1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}
