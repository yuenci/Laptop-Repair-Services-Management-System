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
            this.SuspendLayout();
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.White;
            this.uiLine1.FillColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.uiLine1.Location = new System.Drawing.Point(3, 24);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(280, 29);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 0;
            this.uiLine1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // avatar
            // 
            this.avatar.AvatarSize = 32;
            this.avatar.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.avatar.Location = new System.Drawing.Point(7, 103);
            this.avatar.MinimumSize = new System.Drawing.Size(1, 1);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(32, 32);
            this.avatar.SymbolSize = 30;
            this.avatar.TabIndex = 2;
            this.avatar.Text = "uiAvatar1";
            this.avatar.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.avatar.MouseHover += new System.EventHandler(this.avatar_MouseHover);
            // 
            // edit
            // 
            this.edit.AvatarSize = 32;
            this.edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit.FillColor = System.Drawing.Color.Transparent;
            this.edit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.edit.ForeColor = System.Drawing.Color.Gray;
            this.edit.Location = new System.Drawing.Point(227, 3);
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
            this.time.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time.Location = new System.Drawing.Point(45, 108);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(163, 23);
            this.time.TabIndex = 6;
            this.time.Text = "2022-04-29 23:44:00";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.time.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // model
            // 
            this.model.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.model.Location = new System.Drawing.Point(3, 8);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(177, 23);
            this.model.TabIndex = 7;
            this.model.Text = "Dell ModelDe3";
            this.model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.model.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // service
            // 
            this.service.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.service.Location = new System.Drawing.Point(7, 47);
            this.service.Name = "service";
            this.service.Size = new System.Drawing.Size(290, 53);
            this.service.TabIndex = 8;
            this.service.Text = "Troubleshot and fix computer running slow";
            // 
            // more
            // 
            this.more.AvatarSize = 32;
            this.more.Cursor = System.Windows.Forms.Cursors.Hand;
            this.more.FillColor = System.Drawing.Color.Transparent;
            this.more.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.more.ForeColor = System.Drawing.Color.Gray;
            this.more.Location = new System.Drawing.Point(265, 3);
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
            this.start.FillColor = System.Drawing.Color.Transparent;
            this.start.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.start.ForeColor = System.Drawing.Color.Gray;
            this.start.Location = new System.Drawing.Point(227, 103);
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
            // 
            // done
            // 
            this.done.AvatarSize = 32;
            this.done.Cursor = System.Windows.Forms.Cursors.Hand;
            this.done.Enabled = false;
            this.done.FillColor = System.Drawing.Color.Transparent;
            this.done.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.done.ForeColor = System.Drawing.Color.Gray;
            this.done.Location = new System.Drawing.Point(265, 103);
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
            // 
            // UC_Task_Card
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.done);
            this.Controls.Add(this.start);
            this.Controls.Add(this.more);
            this.Controls.Add(this.service);
            this.Controls.Add(this.model);
            this.Controls.Add(this.time);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.uiLine1);
            this.Name = "UC_Task_Card";
            this.Size = new System.Drawing.Size(300, 140);
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
    }
}
