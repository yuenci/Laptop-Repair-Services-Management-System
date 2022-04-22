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
            this.nameLable = new System.Windows.Forms.Label();
            this.deparName = new System.Windows.Forms.Label();
            this.pictureHead = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHead)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Font = new System.Drawing.Font(".萍方-简", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLable.Location = new System.Drawing.Point(56, 1);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(65, 28);
            this.nameLable.TabIndex = 1;
            this.nameLable.Text = "Name";
            // 
            // deparName
            // 
            this.deparName.AutoSize = true;
            this.deparName.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deparName.Location = new System.Drawing.Point(58, 28);
            this.deparName.Name = "deparName";
            this.deparName.Size = new System.Drawing.Size(96, 22);
            this.deparName.TabIndex = 2;
            this.deparName.Text = "department";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deparName);
            this.Controls.Add(this.nameLable);
            this.Controls.Add(this.pictureHead);
            this.Name = "UC_StaffCard";
            this.Size = new System.Drawing.Size(230, 50);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureHead;
        public System.Windows.Forms.Label nameLable;
        public System.Windows.Forms.Label deparName;
    }
}
