namespace miniSys0._3.Controls.Others
{
    partial class UC_ReciptComplete
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
            this.uiUserControl1 = new Sunny.UI.UIUserControl();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiUserControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiUserControl1
            // 
            this.uiUserControl1.Controls.Add(this.pictureBox1);
            this.uiUserControl1.Controls.Add(this.uiLabel1);
            this.uiUserControl1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiUserControl1.Location = new System.Drawing.Point(24, 26);
            this.uiUserControl1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiUserControl1.Name = "uiUserControl1";
            this.uiUserControl1.Size = new System.Drawing.Size(1052, 527);
            this.uiUserControl1.TabIndex = 0;
            this.uiUserControl1.Text = "uiUserControl1";
            this.uiUserControl1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiUserControl1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(136, 43);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(279, 57);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "RECEIPT";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // UC_ReciptComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiUserControl1);
            this.Name = "UC_ReciptComplete";
            this.Size = new System.Drawing.Size(1115, 578);
            this.uiUserControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIUserControl uiUserControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UILabel uiLabel1;
    }
}
