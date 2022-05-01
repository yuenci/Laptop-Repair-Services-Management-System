namespace miniSys0._3.Controls.MainArea
{
    partial class UC_Payment
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
            this.Container = new Sunny.UI.UIUserControl();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.urC_Crumbs1 = new miniSys0._3.Controls.Others.UrC_Crumbs();
            this.Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.Color.White;
            this.Container.Controls.Add(this.contentPanel);
            this.Container.Controls.Add(this.label1);
            this.Container.FillColor = System.Drawing.Color.White;
            this.Container.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Container.Location = new System.Drawing.Point(4, 58);
            this.Container.MinimumSize = new System.Drawing.Size(1, 1);
            this.Container.Name = "Container";
            this.Container.RectColor = System.Drawing.Color.White;
            this.Container.Size = new System.Drawing.Size(1118, 659);
            this.Container.Style = Sunny.UI.UIStyle.Custom;
            this.Container.TabIndex = 2;
            this.Container.Text = "uiUserControl1";
            this.Container.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Container.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // contentPanel
            // 
            this.contentPanel.Location = new System.Drawing.Point(0, 61);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1115, 578);
            this.contentPanel.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font(".萍方-简", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Receipt generating Form";
            // 
            // urC_Crumbs1
            // 
            this.urC_Crumbs1.BackColor = System.Drawing.Color.Transparent;
            this.urC_Crumbs1.Location = new System.Drawing.Point(4, 3);
            this.urC_Crumbs1.Name = "urC_Crumbs1";
            this.urC_Crumbs1.Size = new System.Drawing.Size(300, 35);
            this.urC_Crumbs1.TabIndex = 1;
            // 
            // UC_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.Container);
            this.Controls.Add(this.urC_Crumbs1);
            this.Name = "UC_Payment";
            this.Size = new System.Drawing.Size(1125, 720);
            this.Container.ResumeLayout(false);
            this.Container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Others.UrC_Crumbs urC_Crumbs1;
        private Sunny.UI.UIUserControl Container;
        public System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}
