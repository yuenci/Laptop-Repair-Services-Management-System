namespace miniSys0._3.Controls.Others
{
    partial class UC_Message_Card
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.message = new Sunny.UI.UILabel();
            this.time = new Sunny.UI.UILabel();
            this.name = new Sunny.UI.UILabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tag = new Sunny.UI.UIAvatar();
            this.uiLine1 = new Sunny.UI.UILine();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiLabel1.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(88, 3);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(122, 23);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "Message From";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.Color.Transparent;
            this.message.Cursor = System.Windows.Forms.Cursors.Hand;
            this.message.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.message.Location = new System.Drawing.Point(88, 27);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(342, 23);
            this.message.TabIndex = 2;
            this.message.Text = "This is a message This is a message This is a message";
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.message.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Cursor = System.Windows.Forms.Cursors.Hand;
            this.time.Font = new System.Drawing.Font(".萍方-简", 10F);
            this.time.Location = new System.Drawing.Point(88, 51);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(122, 15);
            this.time.TabIndex = 3;
            this.time.Text = "2002-11-24";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.time.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.name.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.Location = new System.Drawing.Point(204, 3);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(122, 23);
            this.name.TabIndex = 4;
            this.name.Text = "Jack";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.name.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::miniSys0._3.Properties.Resources.avatar_male;
            this.pictureBox1.Location = new System.Drawing.Point(10, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tag
            // 
            this.tag.AvatarSize = 80;
            this.tag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tag.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.tag.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tag.Icon = Sunny.UI.UIAvatar.UIIcon.Text;
            this.tag.Location = new System.Drawing.Point(341, 4);
            this.tag.MinimumSize = new System.Drawing.Size(1, 1);
            this.tag.Name = "tag";
            this.tag.Shape = Sunny.UI.UIShape.Square;
            this.tag.Size = new System.Drawing.Size(86, 23);
            this.tag.Style = Sunny.UI.UIStyle.Custom;
            this.tag.SymbolSize = 100;
            this.tag.TabIndex = 17;
            this.tag.Text = "Unread";
            this.tag.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.FillColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine1.LineColor = System.Drawing.Color.Gainsboro;
            this.uiLine1.Location = new System.Drawing.Point(0, 73);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(430, 10);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 18;
            this.uiLine1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // UC_Message_Card
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.time);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.tag);
            this.Controls.Add(this.name);
            this.Controls.Add(this.message);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UC_Message_Card";
            this.Size = new System.Drawing.Size(430, 80);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel message;
        private Sunny.UI.UILabel time;
        private Sunny.UI.UILabel name;
        private Sunny.UI.UIAvatar tag;
        private Sunny.UI.UILine uiLine1;
    }
}
