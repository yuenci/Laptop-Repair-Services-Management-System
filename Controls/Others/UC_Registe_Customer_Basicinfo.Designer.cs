namespace miniSys0._3.Controls.Others
{
    partial class UC_Registe_Customer_Basicinfo
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
            this.nextStepBtn = new Sunny.UI.UIButton();
            this.nameTextBox = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nextStepBtn
            // 
            this.nextStepBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextStepBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.nextStepBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.nextStepBtn.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.nextStepBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nextStepBtn.Location = new System.Drawing.Point(435, 415);
            this.nextStepBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.nextStepBtn.Name = "nextStepBtn";
            this.nextStepBtn.RectColor = System.Drawing.Color.White;
            this.nextStepBtn.RectHoverColor = System.Drawing.Color.White;
            this.nextStepBtn.RectPressColor = System.Drawing.Color.White;
            this.nextStepBtn.RectSelectedColor = System.Drawing.Color.White;
            this.nextStepBtn.Size = new System.Drawing.Size(100, 35);
            this.nextStepBtn.Style = Sunny.UI.UIStyle.Custom;
            this.nextStepBtn.TabIndex = 91;
            this.nextStepBtn.Text = "Next";
            this.nextStepBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nextStepBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.nextStepBtn.Click += new System.EventHandler(this.nextStepBtn_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.nameTextBox.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.nameTextBox.Location = new System.Drawing.Point(435, 288);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.nameTextBox.RectColor = System.Drawing.Color.Gray;
            this.nameTextBox.RectDisableColor = System.Drawing.Color.White;
            this.nameTextBox.ShowText = false;
            this.nameTextBox.Size = new System.Drawing.Size(343, 35);
            this.nameTextBox.Style = Sunny.UI.UIStyle.Custom;
            this.nameTextBox.TabIndex = 98;
            this.nameTextBox.Text = "Enter Customer\'s name";
            this.nameTextBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.nameTextBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font(".萍方-简", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(430, 116);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(406, 80);
            this.uiLabel1.TabIndex = 99;
            this.uiLabel1.Text = "Enter the  name as a good start.";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::miniSys0._3.Properties.Resources.Ask_me_anything;
            this.pictureBox1.Location = new System.Drawing.Point(41, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 429);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UC_Registe_Customer_Basicinfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nextStepBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UC_Registe_Customer_Basicinfo";
            this.Size = new System.Drawing.Size(1115, 492);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UIButton nextStepBtn;
        public Sunny.UI.UITextBox nameTextBox;
        private Sunny.UI.UILabel uiLabel1;
    }
}
