namespace miniSys0._3.Controls.Others
{
    partial class UC_StaffCard1
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
            this.pictureHead = new System.Windows.Forms.PictureBox();
            this.nameLabel = new Sunny.UI.UILabel();
            this.postLabel = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHead)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureHead
            // 
            this.pictureHead.Location = new System.Drawing.Point(0, 0);
            this.pictureHead.Name = "pictureHead";
            this.pictureHead.Size = new System.Drawing.Size(50, 50);
            this.pictureHead.TabIndex = 1;
            this.pictureHead.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font(".萍方-简", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLabel.Location = new System.Drawing.Point(50, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.nameLabel.Size = new System.Drawing.Size(100, 25);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "uiLabel1";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nameLabel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // postLabel
            // 
            this.postLabel.BackColor = System.Drawing.Color.Transparent;
            this.postLabel.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.postLabel.Location = new System.Drawing.Point(52, 25);
            this.postLabel.Name = "postLabel";
            this.postLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.postLabel.Size = new System.Drawing.Size(100, 25);
            this.postLabel.TabIndex = 3;
            this.postLabel.Text = "uiLabel2";
            this.postLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.postLabel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // UC_StaffCard1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.postLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.pictureHead);
            this.Name = "UC_StaffCard1";
            this.Size = new System.Drawing.Size(230, 50);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHead)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureHead;
        public Sunny.UI.UILabel nameLabel;
        public Sunny.UI.UILabel postLabel;
    }
}
