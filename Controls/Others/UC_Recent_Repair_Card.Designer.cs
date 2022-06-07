namespace miniSys0._3.Controls.Others
{
    partial class UC_Recent_Repair_Card
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
            this.time = new Sunny.UI.UILabel();
            this.serverType = new Sunny.UI.UILabel();
            this.model = new Sunny.UI.UILabel();
            this.line = new Sunny.UI.UILine();
            this.uiUserControl1 = new Sunny.UI.UIUserControl();
            this.uiUserControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time.Location = new System.Drawing.Point(3, 103);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(223, 23);
            this.time.Style = Sunny.UI.UIStyle.Custom;
            this.time.TabIndex = 5;
            this.time.Text = "2017-12-13 02:00:31";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.time.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // serverType
            // 
            this.serverType.BackColor = System.Drawing.Color.Transparent;
            this.serverType.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.serverType.Location = new System.Drawing.Point(3, 46);
            this.serverType.Name = "serverType";
            this.serverType.Size = new System.Drawing.Size(213, 47);
            this.serverType.Style = Sunny.UI.UIStyle.Custom;
            this.serverType.TabIndex = 4;
            this.serverType.Text = "Troubleshot and fix computer running slow";
            this.serverType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.serverType.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // model
            // 
            this.model.BackColor = System.Drawing.Color.Transparent;
            this.model.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.model.Location = new System.Drawing.Point(2, 7);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(224, 23);
            this.model.Style = Sunny.UI.UIStyle.Custom;
            this.model.TabIndex = 3;
            this.model.Text = "Honor";
            this.model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.model.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Transparent;
            this.line.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.line.Location = new System.Drawing.Point(3, 33);
            this.line.MinimumSize = new System.Drawing.Size(1, 1);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(235, 10);
            this.line.Style = Sunny.UI.UIStyle.Custom;
            this.line.TabIndex = 6;
            this.line.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiUserControl1
            // 
            this.uiUserControl1.Controls.Add(this.serverType);
            this.uiUserControl1.Controls.Add(this.model);
            this.uiUserControl1.Controls.Add(this.line);
            this.uiUserControl1.Controls.Add(this.time);
            this.uiUserControl1.FillColor = System.Drawing.Color.White;
            this.uiUserControl1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiUserControl1.Location = new System.Drawing.Point(3, 3);
            this.uiUserControl1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiUserControl1.Name = "uiUserControl1";
            this.uiUserControl1.RectColor = System.Drawing.Color.Gainsboro;
            this.uiUserControl1.Size = new System.Drawing.Size(240, 140);
            this.uiUserControl1.Style = Sunny.UI.UIStyle.Custom;
            this.uiUserControl1.TabIndex = 7;
            this.uiUserControl1.Text = "uiUserControl1";
            this.uiUserControl1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiUserControl1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // UC_Recent_Repair_Card
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uiUserControl1);
            this.Name = "UC_Recent_Repair_Card";
            this.Size = new System.Drawing.Size(246, 146);
            this.uiUserControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel time;
        private Sunny.UI.UILabel serverType;
        private Sunny.UI.UILabel model;
        private Sunny.UI.UILine line;
        private Sunny.UI.UIUserControl uiUserControl1;
    }
}
