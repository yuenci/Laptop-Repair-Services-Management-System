namespace miniSys0._3.Controls.Others
{
    partial class UC_StaffCard
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
            this.staffNameLable = new System.Windows.Forms.Label();
            this.deparNameLable = new System.Windows.Forms.Label();
            this.pictureHead = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHead)).BeginInit();
            this.SuspendLayout();
            // 
            // staffNameLable
            // 
            this.staffNameLable.AutoSize = true;
            this.staffNameLable.BackColor = System.Drawing.Color.Transparent;
            this.staffNameLable.Font = new System.Drawing.Font(".萍方-简", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.staffNameLable.Location = new System.Drawing.Point(56, 1);
            this.staffNameLable.Name = "staffNameLable";
            this.staffNameLable.Size = new System.Drawing.Size(65, 28);
            this.staffNameLable.TabIndex = 1;
            this.staffNameLable.Text = "Name";
            // 
            // deparNameLable
            // 
            this.deparNameLable.AutoSize = true;
            this.deparNameLable.BackColor = System.Drawing.Color.Transparent;
            this.deparNameLable.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deparNameLable.Location = new System.Drawing.Point(58, 28);
            this.deparNameLable.Name = "deparNameLable";
            this.deparNameLable.Size = new System.Drawing.Size(96, 22);
            this.deparNameLable.TabIndex = 2;
            this.deparNameLable.Text = "department";
            // 
            // pictureHead
            // 
            this.pictureHead.Location = new System.Drawing.Point(0, 0);
            this.pictureHead.Name = "pictureHead";
            this.pictureHead.Size = new System.Drawing.Size(50, 50);
            this.pictureHead.TabIndex = 0;
            this.pictureHead.TabStop = false;
            // 
            // UC_StaffCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.deparNameLable);
            this.Controls.Add(this.staffNameLable);
            this.Controls.Add(this.pictureHead);
            this.Name = "UC_StaffCard";
            this.Size = new System.Drawing.Size(230, 50);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureHead;
        public System.Windows.Forms.Label staffNameLable;
        public System.Windows.Forms.Label deparNameLable;
    }
}
