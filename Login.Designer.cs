namespace miniSys0._3
{
    partial class Login
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLeftSide = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelUpperLeft = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeftSide
            // 
            this.panelLeftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(100)))), ((int)(((byte)(221)))));
            this.panelLeftSide.Controls.Add(this.pictureBox1);
            this.panelLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSide.Location = new System.Drawing.Point(0, 80);
            this.panelLeftSide.Name = "panelLeftSide";
            this.panelLeftSide.Size = new System.Drawing.Size(450, 720);
            this.panelLeftSide.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::miniSys0._3.Properties.Resources.loginDev;
            this.pictureBox1.Location = new System.Drawing.Point(3, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 346);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.FillColor = System.Drawing.Color.White;
            this.uiSymbolButton1.FillHoverColor = System.Drawing.Color.Red;
            this.uiSymbolButton1.FillPressColor = System.Drawing.Color.Red;
            this.uiSymbolButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.Location = new System.Drawing.Point(1289, -1);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Radius = 0;
            this.uiSymbolButton1.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton1.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton1.RectPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton1.Size = new System.Drawing.Size(52, 50);
            this.uiSymbolButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton1.Symbol = 77;
            this.uiSymbolButton1.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolButton1.SymbolSize = 50;
            this.uiSymbolButton1.TabIndex = 10;
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.pictureBox2);
            this.panelTop.Controls.Add(this.panelUpperLeft);
            this.panelTop.Controls.Add(this.uiSymbolButton1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1340, 80);
            this.panelTop.TabIndex = 11;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drag_down);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drag_move);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font(".萍方-简", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(541, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 52);
            this.label1.TabIndex = 12;
            this.label1.Text = "C# Inc";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::miniSys0._3.Properties.Resources.rocket_icon_128;
            this.pictureBox2.Location = new System.Drawing.Point(451, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // panelUpperLeft
            // 
            this.panelUpperLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(100)))), ((int)(((byte)(221)))));
            this.panelUpperLeft.Location = new System.Drawing.Point(0, 0);
            this.panelUpperLeft.Name = "panelUpperLeft";
            this.panelUpperLeft.Size = new System.Drawing.Size(450, 80);
            this.panelUpperLeft.TabIndex = 12;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::miniSys0._3.Properties.Resources.login_panel;
            this.pictureBox3.Location = new System.Drawing.Point(620, 125);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(560, 600);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelContainer.Location = new System.Drawing.Point(659, 156);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(490, 530);
            this.panelContainer.TabIndex = 24;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1340, 800);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panelLeftSide);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form1";
            this.panelLeftSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftSide;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelUpperLeft;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Panel panelContainer;
    }
}

