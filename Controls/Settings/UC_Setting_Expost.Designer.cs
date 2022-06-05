namespace miniSys0._3.Controls.Setting
{
    partial class UC_Setting_Expost
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
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.exportBtn = new Sunny.UI.UIButton();
            this.importBtn = new Sunny.UI.UIButton();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.resetBtn = new Sunny.UI.UIButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(25, 88);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(149, 56);
            this.uiLabel2.TabIndex = 14;
            this.uiLabel2.Text = "Import Settings from local";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(25, 37);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(149, 47);
            this.uiLabel1.TabIndex = 13;
            this.uiLabel1.Text = "Export Settings to local";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // exportBtn
            // 
            this.exportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.exportBtn.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exportBtn.Location = new System.Drawing.Point(237, 47);
            this.exportBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(100, 35);
            this.exportBtn.Style = Sunny.UI.UIStyle.Custom;
            this.exportBtn.TabIndex = 15;
            this.exportBtn.Text = "Export";
            this.exportBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exportBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.exportBtn.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // importBtn
            // 
            this.importBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.importBtn.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.importBtn.Location = new System.Drawing.Point(237, 104);
            this.importBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(100, 35);
            this.importBtn.Style = Sunny.UI.UIStyle.Custom;
            this.importBtn.TabIndex = 16;
            this.importBtn.Text = "Import";
            this.importBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.importBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.importBtn.Click += new System.EventHandler(this.FileOpen_Click);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font(".萍方-简", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(25, 5);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(122, 23);
            this.uiLabel4.TabIndex = 20;
            this.uiLabel4.Text = "Export";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // resetBtn
            // 
            this.resetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.resetBtn.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resetBtn.Location = new System.Drawing.Point(237, 161);
            this.resetBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(100, 35);
            this.resetBtn.Style = Sunny.UI.UIStyle.Custom;
            this.resetBtn.TabIndex = 21;
            this.resetBtn.Text = "Reset";
            this.resetBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resetBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.resetBtn.Click += new System.EventHandler(this.reset_Click);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(25, 147);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(149, 56);
            this.uiLabel3.TabIndex = 22;
            this.uiLabel3.Text = "Reset settings to default";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // UC_Setting_Expost
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Name = "UC_Setting_Expost";
            this.Size = new System.Drawing.Size(360, 213);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton exportBtn;
        private Sunny.UI.UIButton importBtn;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIButton resetBtn;
        private Sunny.UI.UILabel uiLabel3;
    }
}
