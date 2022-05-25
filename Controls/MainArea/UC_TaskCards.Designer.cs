namespace miniSys0._3.Controls.MainArea
{
    partial class UC_TaskCards
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
            this.searchIcon = new Sunny.UI.UIAvatar();
            this.searchBox = new Sunny.UI.UITextBox();
            this.dfinishedCard = new Sunny.UI.UIButton();
            this.repairingCard = new Sunny.UI.UIButton();
            this.noStartCard = new Sunny.UI.UIButton();
            this.allCard = new Sunny.UI.UIButton();
            this.pagination = new miniSys0._3.Controls.Others.UC_Pagination();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.uC_Task_Card9 = new miniSys0._3.Controls.Others.UC_Task_Card();
            this.uC_Task_Card8 = new miniSys0._3.Controls.Others.UC_Task_Card();
            this.uC_Task_Card7 = new miniSys0._3.Controls.Others.UC_Task_Card();
            this.uC_Task_Card6 = new miniSys0._3.Controls.Others.UC_Task_Card();
            this.uC_Task_Card5 = new miniSys0._3.Controls.Others.UC_Task_Card();
            this.uC_Task_Card4 = new miniSys0._3.Controls.Others.UC_Task_Card();
            this.uC_Task_Card3 = new miniSys0._3.Controls.Others.UC_Task_Card();
            this.uC_Task_Card2 = new miniSys0._3.Controls.Others.UC_Task_Card();
            this.uC_Task_Card1 = new miniSys0._3.Controls.Others.UC_Task_Card();
            this.label1 = new System.Windows.Forms.Label();
            this.urC_Crumbs1 = new miniSys0._3.Controls.Others.UrC_Crumbs();
            this.Container.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.Container.Controls.Add(this.searchIcon);
            this.Container.Controls.Add(this.searchBox);
            this.Container.Controls.Add(this.dfinishedCard);
            this.Container.Controls.Add(this.repairingCard);
            this.Container.Controls.Add(this.noStartCard);
            this.Container.Controls.Add(this.allCard);
            this.Container.Controls.Add(this.pagination);
            this.Container.Controls.Add(this.contentPanel);
            this.Container.Controls.Add(this.label1);
            this.Container.FillColor = System.Drawing.Color.White;
            this.Container.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Container.Location = new System.Drawing.Point(3, 58);
            this.Container.MinimumSize = new System.Drawing.Size(1, 1);
            this.Container.Name = "Container";
            this.Container.RectColor = System.Drawing.Color.White;
            this.Container.Size = new System.Drawing.Size(1118, 662);
            this.Container.Style = Sunny.UI.UIStyle.Custom;
            this.Container.TabIndex = 4;
            this.Container.Text = "Start time";
            this.Container.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Container.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // searchIcon
            // 
            this.searchIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchIcon.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchIcon.Location = new System.Drawing.Point(1021, 49);
            this.searchIcon.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Shape = Sunny.UI.UIShape.Square;
            this.searchIcon.Size = new System.Drawing.Size(33, 33);
            this.searchIcon.Style = Sunny.UI.UIStyle.Custom;
            this.searchIcon.Symbol = 61442;
            this.searchIcon.SymbolSize = 30;
            this.searchIcon.TabIndex = 91;
            this.searchIcon.Text = "uiAvatar2";
            this.searchIcon.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.searchIcon.Click += new System.EventHandler(this.searchIcon_Click);
            // 
            // searchBox
            // 
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchBox.Location = new System.Drawing.Point(753, 48);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.searchBox.Name = "searchBox";
            this.searchBox.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.searchBox.ShowText = false;
            this.searchBox.Size = new System.Drawing.Size(269, 35);
            this.searchBox.Style = Sunny.UI.UIStyle.Custom;
            this.searchBox.TabIndex = 90;
            this.searchBox.Text = "Search";
            this.searchBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.searchBox.Leave += new System.EventHandler(this.searchBox_Leave);
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Enter);
            // 
            // dfinishedCard
            // 
            this.dfinishedCard.BackColor = System.Drawing.Color.Transparent;
            this.dfinishedCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dfinishedCard.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dfinishedCard.Location = new System.Drawing.Point(458, 52);
            this.dfinishedCard.MinimumSize = new System.Drawing.Size(1, 1);
            this.dfinishedCard.Name = "dfinishedCard";
            this.dfinishedCard.Radius = 25;
            this.dfinishedCard.Size = new System.Drawing.Size(100, 30);
            this.dfinishedCard.Style = Sunny.UI.UIStyle.Custom;
            this.dfinishedCard.TabIndex = 89;
            this.dfinishedCard.Text = "Finished";
            this.dfinishedCard.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dfinishedCard.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.dfinishedCard.Click += new System.EventHandler(this.switchButton4_Click);
            // 
            // repairingCard
            // 
            this.repairingCard.BackColor = System.Drawing.Color.Transparent;
            this.repairingCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.repairingCard.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.repairingCard.Location = new System.Drawing.Point(325, 52);
            this.repairingCard.MinimumSize = new System.Drawing.Size(1, 1);
            this.repairingCard.Name = "repairingCard";
            this.repairingCard.Radius = 25;
            this.repairingCard.Size = new System.Drawing.Size(100, 30);
            this.repairingCard.Style = Sunny.UI.UIStyle.Custom;
            this.repairingCard.TabIndex = 88;
            this.repairingCard.Text = "Repairing";
            this.repairingCard.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.repairingCard.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.repairingCard.Click += new System.EventHandler(this.switchButton3_Click);
            // 
            // noStartCard
            // 
            this.noStartCard.BackColor = System.Drawing.Color.Transparent;
            this.noStartCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noStartCard.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.noStartCard.Location = new System.Drawing.Point(192, 52);
            this.noStartCard.MinimumSize = new System.Drawing.Size(1, 1);
            this.noStartCard.Name = "noStartCard";
            this.noStartCard.Radius = 25;
            this.noStartCard.Size = new System.Drawing.Size(100, 30);
            this.noStartCard.Style = Sunny.UI.UIStyle.Custom;
            this.noStartCard.TabIndex = 87;
            this.noStartCard.Text = "NotStart";
            this.noStartCard.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.noStartCard.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.noStartCard.Click += new System.EventHandler(this.switchButton2_Click);
            // 
            // allCard
            // 
            this.allCard.BackColor = System.Drawing.Color.Transparent;
            this.allCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allCard.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.allCard.Location = new System.Drawing.Point(59, 52);
            this.allCard.MinimumSize = new System.Drawing.Size(1, 1);
            this.allCard.Name = "allCard";
            this.allCard.Radius = 25;
            this.allCard.Size = new System.Drawing.Size(100, 30);
            this.allCard.Style = Sunny.UI.UIStyle.Custom;
            this.allCard.TabIndex = 86;
            this.allCard.Text = "All ";
            this.allCard.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.allCard.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.allCard.Click += new System.EventHandler(this.switchButton1_Click);
            // 
            // pagination
            // 
            this.pagination.BackColor = System.Drawing.Color.White;
            this.pagination.Location = new System.Drawing.Point(59, 617);
            this.pagination.Name = "pagination";
            this.pagination.Size = new System.Drawing.Size(1000, 40);
            this.pagination.TabIndex = 85;
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.Transparent;
            this.contentPanel.Controls.Add(this.uC_Task_Card9);
            this.contentPanel.Controls.Add(this.uC_Task_Card8);
            this.contentPanel.Controls.Add(this.uC_Task_Card7);
            this.contentPanel.Controls.Add(this.uC_Task_Card6);
            this.contentPanel.Controls.Add(this.uC_Task_Card5);
            this.contentPanel.Controls.Add(this.uC_Task_Card4);
            this.contentPanel.Controls.Add(this.uC_Task_Card3);
            this.contentPanel.Controls.Add(this.uC_Task_Card2);
            this.contentPanel.Controls.Add(this.uC_Task_Card1);
            this.contentPanel.Location = new System.Drawing.Point(3, 108);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1115, 504);
            this.contentPanel.TabIndex = 84;
            // 
            // uC_Task_Card9
            // 
            this.uC_Task_Card9.BackColor = System.Drawing.Color.White;
            this.uC_Task_Card9.Location = new System.Drawing.Point(750, 344);
            this.uC_Task_Card9.Name = "uC_Task_Card9";
            this.uC_Task_Card9.Size = new System.Drawing.Size(305, 145);
            this.uC_Task_Card9.TabIndex = 8;
            // 
            // uC_Task_Card8
            // 
            this.uC_Task_Card8.BackColor = System.Drawing.Color.White;
            this.uC_Task_Card8.Location = new System.Drawing.Point(403, 344);
            this.uC_Task_Card8.Name = "uC_Task_Card8";
            this.uC_Task_Card8.Size = new System.Drawing.Size(305, 145);
            this.uC_Task_Card8.TabIndex = 7;
            // 
            // uC_Task_Card7
            // 
            this.uC_Task_Card7.BackColor = System.Drawing.Color.White;
            this.uC_Task_Card7.Location = new System.Drawing.Point(56, 344);
            this.uC_Task_Card7.Name = "uC_Task_Card7";
            this.uC_Task_Card7.Size = new System.Drawing.Size(305, 145);
            this.uC_Task_Card7.TabIndex = 6;
            // 
            // uC_Task_Card6
            // 
            this.uC_Task_Card6.BackColor = System.Drawing.Color.White;
            this.uC_Task_Card6.Location = new System.Drawing.Point(750, 175);
            this.uC_Task_Card6.Name = "uC_Task_Card6";
            this.uC_Task_Card6.Size = new System.Drawing.Size(305, 145);
            this.uC_Task_Card6.TabIndex = 5;
            // 
            // uC_Task_Card5
            // 
            this.uC_Task_Card5.BackColor = System.Drawing.Color.White;
            this.uC_Task_Card5.Location = new System.Drawing.Point(403, 175);
            this.uC_Task_Card5.Name = "uC_Task_Card5";
            this.uC_Task_Card5.Size = new System.Drawing.Size(305, 145);
            this.uC_Task_Card5.TabIndex = 4;
            // 
            // uC_Task_Card4
            // 
            this.uC_Task_Card4.BackColor = System.Drawing.Color.White;
            this.uC_Task_Card4.Location = new System.Drawing.Point(56, 175);
            this.uC_Task_Card4.Name = "uC_Task_Card4";
            this.uC_Task_Card4.Size = new System.Drawing.Size(305, 145);
            this.uC_Task_Card4.TabIndex = 3;
            // 
            // uC_Task_Card3
            // 
            this.uC_Task_Card3.BackColor = System.Drawing.Color.White;
            this.uC_Task_Card3.Location = new System.Drawing.Point(750, 6);
            this.uC_Task_Card3.Name = "uC_Task_Card3";
            this.uC_Task_Card3.Size = new System.Drawing.Size(305, 145);
            this.uC_Task_Card3.TabIndex = 2;
            // 
            // uC_Task_Card2
            // 
            this.uC_Task_Card2.BackColor = System.Drawing.Color.White;
            this.uC_Task_Card2.Location = new System.Drawing.Point(403, 6);
            this.uC_Task_Card2.Name = "uC_Task_Card2";
            this.uC_Task_Card2.Size = new System.Drawing.Size(305, 145);
            this.uC_Task_Card2.TabIndex = 1;
            // 
            // uC_Task_Card1
            // 
            this.uC_Task_Card1.BackColor = System.Drawing.Color.White;
            this.uC_Task_Card1.Location = new System.Drawing.Point(56, 6);
            this.uC_Task_Card1.Name = "uC_Task_Card1";
            this.uC_Task_Card1.Size = new System.Drawing.Size(305, 145);
            this.uC_Task_Card1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font(".萍方-简", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Service requested Cards";
            // 
            // urC_Crumbs1
            // 
            this.urC_Crumbs1.BackColor = System.Drawing.SystemColors.Control;
            this.urC_Crumbs1.Location = new System.Drawing.Point(0, 4);
            this.urC_Crumbs1.Name = "urC_Crumbs1";
            this.urC_Crumbs1.Size = new System.Drawing.Size(300, 35);
            this.urC_Crumbs1.TabIndex = 0;
            // 
            // UC_TaskCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.Container);
            this.Controls.Add(this.urC_Crumbs1);
            this.Name = "UC_TaskCards";
            this.Size = new System.Drawing.Size(1125, 720);
            this.Container.ResumeLayout(false);
            this.Container.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Others.UrC_Crumbs urC_Crumbs1;
        private Sunny.UI.UIUserControl Container;
        public System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label label1;
        private Others.UC_Pagination pagination;
        public Others.UC_Task_Card uC_Task_Card5;
        public Others.UC_Task_Card uC_Task_Card4;
        public Others.UC_Task_Card uC_Task_Card3;
        public Others.UC_Task_Card uC_Task_Card2;
        public Others.UC_Task_Card uC_Task_Card1;
        public Others.UC_Task_Card uC_Task_Card9;
        public Others.UC_Task_Card uC_Task_Card8;
        public Others.UC_Task_Card uC_Task_Card7;
        public Others.UC_Task_Card uC_Task_Card6;
        private Sunny.UI.UIButton dfinishedCard;
        private Sunny.UI.UIButton repairingCard;
        private Sunny.UI.UIButton noStartCard;
        private Sunny.UI.UIButton allCard;
        private Sunny.UI.UITextBox searchBox;
        private Sunny.UI.UIAvatar searchIcon;
    }
}
