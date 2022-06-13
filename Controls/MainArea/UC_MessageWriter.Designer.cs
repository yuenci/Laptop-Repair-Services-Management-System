namespace miniSys0._3.Controls.MainArea
{
    partial class UC_MessageWriter
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Container = new Sunny.UI.UIUserControl();
            this.showMessageNum = new Sunny.UI.UILabel();
            this.delect = new Sunny.UI.UIButton();
            this.counter = new Sunny.UI.UILabel();
            this.ok = new Sunny.UI.UIButton();
            this.textbox = new Sunny.UI.UIRichTextBox();
            this.pageTitle = new System.Windows.Forms.Label();
            this.urC_Crumbs1 = new miniSys0._3.Controls.Others.UrC_Crumbs();
            this.Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.Color.White;
            this.Container.Controls.Add(this.showMessageNum);
            this.Container.Controls.Add(this.delect);
            this.Container.Controls.Add(this.counter);
            this.Container.Controls.Add(this.ok);
            this.Container.Controls.Add(this.textbox);
            this.Container.Controls.Add(this.pageTitle);
            this.Container.FillColor = System.Drawing.Color.White;
            this.Container.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Container.Location = new System.Drawing.Point(4, 58);
            this.Container.MinimumSize = new System.Drawing.Size(1, 1);
            this.Container.Name = "Container";
            this.Container.RectColor = System.Drawing.Color.White;
            this.Container.Size = new System.Drawing.Size(1118, 659);
            this.Container.Style = Sunny.UI.UIStyle.Custom;
            this.Container.TabIndex = 3;
            this.Container.Text = "uiUserControl1";
            this.Container.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Container.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // showMessageNum
            // 
            this.showMessageNum.BackColor = System.Drawing.Color.Transparent;
            this.showMessageNum.Font = new System.Drawing.Font(".PingFang SC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showMessageNum.Location = new System.Drawing.Point(653, 71);
            this.showMessageNum.Name = "showMessageNum";
            this.showMessageNum.Size = new System.Drawing.Size(286, 35);
            this.showMessageNum.Style = Sunny.UI.UIStyle.Custom;
            this.showMessageNum.TabIndex = 11;
            this.showMessageNum.Text = "3 system messages currently";
            this.showMessageNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showMessageNum.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // delect
            // 
            this.delect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delect.Font = new System.Drawing.Font(".PingFang SC", 12F, System.Drawing.FontStyle.Bold);
            this.delect.Location = new System.Drawing.Point(973, 71);
            this.delect.MinimumSize = new System.Drawing.Size(1, 1);
            this.delect.Name = "delect";
            this.delect.Size = new System.Drawing.Size(100, 35);
            this.delect.Style = Sunny.UI.UIStyle.Custom;
            this.delect.TabIndex = 10;
            this.delect.Text = "Delect";
            this.delect.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delect.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.delect.Click += new System.EventHandler(this.delect_Click);
            // 
            // counter
            // 
            this.counter.BackColor = System.Drawing.Color.Transparent;
            this.counter.Font = new System.Drawing.Font(".PingFang SC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.counter.Location = new System.Drawing.Point(809, 608);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(130, 35);
            this.counter.Style = Sunny.UI.UIStyle.Custom;
            this.counter.TabIndex = 9;
            this.counter.Text = "0/280";
            this.counter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.counter.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ok
            // 
            this.ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok.Font = new System.Drawing.Font(".PingFang SC", 12F, System.Drawing.FontStyle.Bold);
            this.ok.Location = new System.Drawing.Point(973, 608);
            this.ok.MinimumSize = new System.Drawing.Size(1, 1);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(100, 35);
            this.ok.Style = Sunny.UI.UIStyle.Custom;
            this.ok.TabIndex = 8;
            this.ok.Text = "Post";
            this.ok.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ok.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // textbox
            // 
            this.textbox.FillColor = System.Drawing.Color.White;
            this.textbox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textbox.Location = new System.Drawing.Point(33, 133);
            this.textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox.MinimumSize = new System.Drawing.Size(1, 1);
            this.textbox.Name = "textbox";
            this.textbox.Padding = new System.Windows.Forms.Padding(2);
            this.textbox.ShowText = false;
            this.textbox.Size = new System.Drawing.Size(1040, 448);
            this.textbox.Style = Sunny.UI.UIStyle.Custom;
            this.textbox.TabIndex = 7;
            this.textbox.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.textbox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.textbox.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // pageTitle
            // 
            this.pageTitle.AutoSize = true;
            this.pageTitle.BackColor = System.Drawing.Color.Transparent;
            this.pageTitle.Font = new System.Drawing.Font(".PingFang SC", 15F, System.Drawing.FontStyle.Bold);
            this.pageTitle.Location = new System.Drawing.Point(29, 19);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(218, 20);
            this.pageTitle.TabIndex = 6;
            this.pageTitle.Text = "Post system message";
            // 
            // urC_Crumbs1
            // 
            this.urC_Crumbs1.BackColor = System.Drawing.SystemColors.Control;
            this.urC_Crumbs1.Location = new System.Drawing.Point(4, 3);
            this.urC_Crumbs1.Name = "urC_Crumbs1";
            this.urC_Crumbs1.Size = new System.Drawing.Size(289, 35);
            this.urC_Crumbs1.TabIndex = 0;
            // 
            // UC_MessageWriter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.Container);
            this.Controls.Add(this.urC_Crumbs1);
            this.Name = "UC_MessageWriter";
            this.Size = new System.Drawing.Size(1125, 720);
            this.Container.ResumeLayout(false);
            this.Container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Others.UrC_Crumbs urC_Crumbs1;
        private Sunny.UI.UIUserControl Container;
        private System.Windows.Forms.Label pageTitle;
        private Sunny.UI.UIRichTextBox textbox;
        private Sunny.UI.UILabel showMessageNum;
        private Sunny.UI.UIButton delect;
        private Sunny.UI.UILabel counter;
        private Sunny.UI.UIButton ok;
    }
}
