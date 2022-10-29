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
            this.successIcon = new Sunny.UI.UIAvatar();
            this.errorBar = new Sunny.UI.UISymbolLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nextStepBtn
            // 
            this.nextStepBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextStepBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.nextStepBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.nextStepBtn.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.nextStepBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nextStepBtn.Location = new System.Drawing.Point(435, 415);
            this.nextStepBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.nextStepBtn.Name = "nextStepBtn";
            this.nextStepBtn.RectColor = System.Drawing.Color.Transparent;
            this.nextStepBtn.RectHoverColor = System.Drawing.Color.Transparent;
            this.nextStepBtn.RectPressColor = System.Drawing.Color.Transparent;
            this.nextStepBtn.RectSelectedColor = System.Drawing.Color.Transparent;
            this.nextStepBtn.Size = new System.Drawing.Size(100, 35);
            this.nextStepBtn.Style = Sunny.UI.UIStyle.Custom;
            this.nextStepBtn.TabIndex = 91;
            this.nextStepBtn.Text = "Next";
            this.nextStepBtn.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nextStepBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.nextStepBtn.Click += new System.EventHandler(this.nextStepBtn_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.nameTextBox.Font = new System.Drawing.Font(".PingFang SC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            this.nameTextBox.Enter += new System.EventHandler(this.nameTextBox_Enter);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font(".PingFang SC", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(430, 116);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(406, 80);
            this.uiLabel1.TabIndex = 99;
            this.uiLabel1.Text = "Enter the name as a good start.";
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
            // successIcon
            // 
            this.successIcon.BackColor = System.Drawing.Color.Transparent;
            this.successIcon.FillColor = System.Drawing.Color.Transparent;
            this.successIcon.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.successIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(42)))));
            this.successIcon.Location = new System.Drawing.Point(789, 282);
            this.successIcon.MinimumSize = new System.Drawing.Size(1, 1);
            this.successIcon.Name = "successIcon";
            this.successIcon.Size = new System.Drawing.Size(50, 50);
            this.successIcon.Style = Sunny.UI.UIStyle.Custom;
            this.successIcon.Symbol = 61528;
            this.successIcon.SymbolSize = 30;
            this.successIcon.TabIndex = 101;
            this.successIcon.Text = "uiAvatar1";
            this.successIcon.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // errorBar
            // 
            this.errorBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.errorBar.Font = new System.Drawing.Font(".PingFang SC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.errorBar.Location = new System.Drawing.Point(435, 232);
            this.errorBar.MinimumSize = new System.Drawing.Size(1, 1);
            this.errorBar.Name = "errorBar";
            this.errorBar.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.errorBar.Size = new System.Drawing.Size(343, 35);
            this.errorBar.Style = Sunny.UI.UIStyle.Custom;
            this.errorBar.Symbol = 61527;
            this.errorBar.SymbolColor = System.Drawing.Color.Red;
            this.errorBar.TabIndex = 100;
            this.errorBar.Text = "Name has already existed";
            this.errorBar.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // UC_Registe_Customer_Basicinfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.successIcon);
            this.Controls.Add(this.errorBar);
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
        public Sunny.UI.UIAvatar successIcon;
        private Sunny.UI.UISymbolLabel errorBar;
    }
}
