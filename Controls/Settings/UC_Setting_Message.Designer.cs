namespace miniSys0._3.Controls.Setting
{
    partial class UC_Setting_Message
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
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.rejectAllSy = new Sunny.UI.UISwitch();
            this.rejectAllMs = new Sunny.UI.UISwitch();
            this.rejectAllCus = new Sunny.UI.UISwitch();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(25, 125);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(149, 47);
            this.uiLabel3.TabIndex = 15;
            this.uiLabel3.Text = "Allows users send \r\nmessage to you";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(25, 87);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(196, 23);
            this.uiLabel2.TabIndex = 14;
            this.uiLabel2.Text = "Reject system message";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(25, 49);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(149, 23);
            this.uiLabel1.TabIndex = 13;
            this.uiLabel1.Text = "Reject all message";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // rejectAllSy
            // 
            this.rejectAllSy.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.rejectAllSy.ActiveText = "On";
            this.rejectAllSy.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rejectAllSy.InActiveText = "Off";
            this.rejectAllSy.Location = new System.Drawing.Point(260, 87);
            this.rejectAllSy.MinimumSize = new System.Drawing.Size(1, 1);
            this.rejectAllSy.Name = "rejectAllSy";
            this.rejectAllSy.Size = new System.Drawing.Size(75, 29);
            this.rejectAllSy.Style = Sunny.UI.UIStyle.Custom;
            this.rejectAllSy.TabIndex = 12;
            this.rejectAllSy.Text = "uiSwitch2";
            this.rejectAllSy.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.rejectAllSy.Click += new System.EventHandler(this.rejectAllSy_Click);
            // 
            // rejectAllMs
            // 
            this.rejectAllMs.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.rejectAllMs.ActiveText = "On";
            this.rejectAllMs.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rejectAllMs.InActiveText = "Off";
            this.rejectAllMs.Location = new System.Drawing.Point(260, 43);
            this.rejectAllMs.MinimumSize = new System.Drawing.Size(1, 1);
            this.rejectAllMs.Name = "rejectAllMs";
            this.rejectAllMs.Size = new System.Drawing.Size(75, 29);
            this.rejectAllMs.Style = Sunny.UI.UIStyle.Custom;
            this.rejectAllMs.TabIndex = 11;
            this.rejectAllMs.Text = "uiSwitch1";
            this.rejectAllMs.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.rejectAllMs.Click += new System.EventHandler(this.rejectAllMs_Click);
            // 
            // rejectAllCus
            // 
            this.rejectAllCus.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.rejectAllCus.ActiveText = "On";
            this.rejectAllCus.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rejectAllCus.InActiveText = "Off";
            this.rejectAllCus.Location = new System.Drawing.Point(260, 143);
            this.rejectAllCus.MinimumSize = new System.Drawing.Size(1, 1);
            this.rejectAllCus.Name = "rejectAllCus";
            this.rejectAllCus.Size = new System.Drawing.Size(75, 29);
            this.rejectAllCus.Style = Sunny.UI.UIStyle.Custom;
            this.rejectAllCus.TabIndex = 16;
            this.rejectAllCus.Text = "uiSwitch3";
            this.rejectAllCus.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.rejectAllCus.Click += new System.EventHandler(this.rejectAllCus_Click);
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine1.LineColor = System.Drawing.Color.Gainsboro;
            this.uiLine1.Location = new System.Drawing.Point(0, 187);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(360, 10);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 17;
            this.uiLine1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font(".萍方-简", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(25, 5);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(122, 29);
            this.uiLabel4.TabIndex = 18;
            this.uiLabel4.Text = "Message";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // UC_Setting_Message
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.rejectAllCus);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.rejectAllSy);
            this.Controls.Add(this.rejectAllMs);
            this.Name = "UC_Setting_Message";
            this.Size = new System.Drawing.Size(360, 200);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UISwitch rejectAllSy;
        private Sunny.UI.UISwitch rejectAllMs;
        private Sunny.UI.UISwitch rejectAllCus;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILabel uiLabel4;
    }
}
