namespace miniSys0._3.Controls.Others
{
    partial class UC_Task_Item
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
            this.statusIcon = new Sunny.UI.UIUserControl();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.finish = new Sunny.UI.UILabel();
            this.start = new Sunny.UI.UILabel();
            this.updateTime = new Sunny.UI.UILabel();
            this.statusText = new Sunny.UI.UILabel();
            this.description = new Sunny.UI.UILabel();
            this.orderId = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // statusIcon
            // 
            this.statusIcon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.statusIcon.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusIcon.Location = new System.Drawing.Point(571, 17);
            this.statusIcon.MinimumSize = new System.Drawing.Size(1, 1);
            this.statusIcon.Name = "statusIcon";
            this.statusIcon.RectColor = System.Drawing.Color.White;
            this.statusIcon.Size = new System.Drawing.Size(10, 10);
            this.statusIcon.Style = Sunny.UI.UIStyle.Custom;
            this.statusIcon.TabIndex = 9;
            this.statusIcon.Text = "uiUserControl1";
            this.statusIcon.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.statusIcon.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMarkLabel1.Location = new System.Drawing.Point(4, 38);
            this.uiMarkLabel1.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.uiMarkLabel1.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Bottom;
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.uiMarkLabel1.Size = new System.Drawing.Size(1094, 5);
            this.uiMarkLabel1.TabIndex = 10;
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiMarkLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // finish
            // 
            this.finish.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.finish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.finish.Location = new System.Drawing.Point(1009, 9);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(62, 29);
            this.finish.Style = Sunny.UI.UIStyle.Custom;
            this.finish.TabIndex = 22;
            this.finish.Text = "Finish";
            this.finish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.finish.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.finish.Click += new System.EventHandler(this.finish_TextChanged);
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.start.Location = new System.Drawing.Point(927, 9);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(54, 29);
            this.start.Style = Sunny.UI.UIStyle.Custom;
            this.start.TabIndex = 21;
            this.start.Text = "Start";
            this.start.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.start.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.start.Click += new System.EventHandler(this.start_TextChanged);
            // 
            // updateTime
            // 
            this.updateTime.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.updateTime.Location = new System.Drawing.Point(707, 9);
            this.updateTime.Name = "updateTime";
            this.updateTime.Size = new System.Drawing.Size(192, 29);
            this.updateTime.TabIndex = 20;
            this.updateTime.Text = "2016-08-25 22:11:46";
            this.updateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateTime.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // statusText
            // 
            this.statusText.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusText.Location = new System.Drawing.Point(588, 9);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(91, 29);
            this.statusText.TabIndex = 19;
            this.statusText.Text = "Status";
            this.statusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusText.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.description.Location = new System.Drawing.Point(158, 9);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(391, 29);
            this.description.TabIndex = 18;
            this.description.Text = "Decription text";
            this.description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.description.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.description.Click += new System.EventHandler(this.description_TextChanged);
            // 
            // orderId
            // 
            this.orderId.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.orderId.Location = new System.Drawing.Point(10, 9);
            this.orderId.Name = "orderId";
            this.orderId.Size = new System.Drawing.Size(114, 29);
            this.orderId.TabIndex = 17;
            this.orderId.Text = "00000001";
            this.orderId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderId.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // UC_Task_Item
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.finish);
            this.Controls.Add(this.start);
            this.Controls.Add(this.updateTime);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.description);
            this.Controls.Add(this.orderId);
            this.Controls.Add(this.uiMarkLabel1);
            this.Controls.Add(this.statusIcon);
            this.Name = "UC_Task_Item";
            this.Size = new System.Drawing.Size(1100, 47);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIUserControl statusIcon;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private Sunny.UI.UILabel finish;
        private Sunny.UI.UILabel start;
        private Sunny.UI.UILabel updateTime;
        private Sunny.UI.UILabel statusText;
        private Sunny.UI.UILabel description;
        private Sunny.UI.UILabel orderId;
    }
}
