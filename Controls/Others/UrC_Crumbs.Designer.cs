namespace miniSys0._3.Controls.Others
{
    partial class UrC_Crumbs
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
            this.crumbsText = new System.Windows.Forms.Label();
            this.crumbsHome = new Sunny.UI.UISymbolButton();
            this.crumbText = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // crumbsText
            // 
            this.crumbsText.AutoSize = true;
            this.crumbsText.BackColor = System.Drawing.SystemColors.Control;
            this.crumbsText.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.crumbsText.Location = new System.Drawing.Point(212, 195);
            this.crumbsText.Name = "crumbsText";
            this.crumbsText.Size = new System.Drawing.Size(0, 22);
            this.crumbsText.TabIndex = 13;
            // 
            // crumbsHome
            // 
            this.crumbsHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.crumbsHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.crumbsHome.Enabled = false;
            this.crumbsHome.FillColor = System.Drawing.Color.White;
            this.crumbsHome.FillDisableColor = System.Drawing.Color.Transparent;
            this.crumbsHome.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.crumbsHome.ForeColor = System.Drawing.Color.Black;
            this.crumbsHome.Location = new System.Drawing.Point(0, 0);
            this.crumbsHome.MinimumSize = new System.Drawing.Size(1, 1);
            this.crumbsHome.Name = "crumbsHome";
            this.crumbsHome.RectColor = System.Drawing.Color.Transparent;
            this.crumbsHome.RectDisableColor = System.Drawing.Color.Transparent;
            this.crumbsHome.Size = new System.Drawing.Size(188, 35);
            this.crumbsHome.Style = Sunny.UI.UIStyle.Custom;
            this.crumbsHome.Symbol = 57353;
            this.crumbsHome.SymbolColor = System.Drawing.Color.Black;
            this.crumbsHome.SymbolOffset = new System.Drawing.Point(5, 0);
            this.crumbsHome.TabIndex = 12;
            this.crumbsHome.Text = " / Profile / User info";
            this.crumbsHome.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.crumbsHome.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // crumbText
            // 
            this.crumbText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.crumbText.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.crumbText.Location = new System.Drawing.Point(110, 0);
            this.crumbText.Name = "crumbText";
            this.crumbText.Size = new System.Drawing.Size(187, 35);
            this.crumbText.TabIndex = 14;
            this.crumbText.Text = "User info";
            this.crumbText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.crumbText.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // UrC_Crumbs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.crumbText);
            this.Controls.Add(this.crumbsText);
            this.Controls.Add(this.crumbsHome);
            this.Name = "UrC_Crumbs";
            this.Size = new System.Drawing.Size(300, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label crumbsText;
        public Sunny.UI.UISymbolButton crumbsHome;
        public Sunny.UI.UILabel crumbText;
    }
}
