namespace miniSys0._3.Controls.Others
{
    partial class UC_ReportTable_card
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
            this.ProcessBar = new Sunny.UI.UIProcessBar();
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.ratio = new Sunny.UI.UILabel();
            this.dataTime = new Sunny.UI.UILabel();
            this.quantity = new Sunny.UI.UILabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ProcessBar
            // 
            this.ProcessBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ProcessBar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProcessBar.Location = new System.Drawing.Point(599, 15);
            this.ProcessBar.MinimumSize = new System.Drawing.Size(70, 3);
            this.ProcessBar.Name = "ProcessBar";
            this.ProcessBar.Radius = 10;
            this.ProcessBar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.ProcessBar.Size = new System.Drawing.Size(260, 20);
            this.ProcessBar.Style = Sunny.UI.UIStyle.Custom;
            this.ProcessBar.TabIndex = 3;
            this.ProcessBar.Text = "uiProcessBar1";
            this.ProcessBar.Value = 50;
            this.ProcessBar.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiAvatar1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiAvatar1.Icon = Sunny.UI.UIAvatar.UIIcon.Text;
            this.uiAvatar1.Location = new System.Drawing.Point(14, 3);
            this.uiAvatar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Radius = 10;
            this.uiAvatar1.Shape = Sunny.UI.UIShape.Square;
            this.uiAvatar1.Size = new System.Drawing.Size(45, 45);
            this.uiAvatar1.TabIndex = 4;
            this.uiAvatar1.Text = "abcd";
            this.uiAvatar1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiAvatar1.MouseHover += new System.EventHandler(this.uiAvatar1_MouseHover);
            // 
            // ratio
            // 
            this.ratio.Font = new System.Drawing.Font(".PingFang SC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ratio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.ratio.Location = new System.Drawing.Point(865, 14);
            this.ratio.Name = "ratio";
            this.ratio.Size = new System.Drawing.Size(91, 23);
            this.ratio.Style = Sunny.UI.UIStyle.Custom;
            this.ratio.TabIndex = 5;
            this.ratio.Text = "100.00%";
            this.ratio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ratio.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // dataTime
            // 
            this.dataTime.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataTime.ForeColor = System.Drawing.Color.Black;
            this.dataTime.Location = new System.Drawing.Point(177, 15);
            this.dataTime.Name = "dataTime";
            this.dataTime.Size = new System.Drawing.Size(93, 23);
            this.dataTime.Style = Sunny.UI.UIStyle.Custom;
            this.dataTime.TabIndex = 6;
            this.dataTime.Text = "2022-06";
            this.dataTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dataTime.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.quantity.ForeColor = System.Drawing.Color.Black;
            this.quantity.Location = new System.Drawing.Point(352, 14);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(167, 23);
            this.quantity.Style = Sunny.UI.UIStyle.Custom;
            this.quantity.TabIndex = 7;
            this.quantity.Text = "1000";
            this.quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.quantity.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // UC_ReportTable_card
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.dataTime);
            this.Controls.Add(this.ratio);
            this.Controls.Add(this.uiAvatar1);
            this.Controls.Add(this.ProcessBar);
            this.Name = "UC_ReportTable_card";
            this.Size = new System.Drawing.Size(973, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIProcessBar ProcessBar;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UILabel ratio;
        private Sunny.UI.UILabel dataTime;
        private Sunny.UI.UILabel quantity;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
