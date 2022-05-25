namespace miniSys0._3.Controls.MainArea
{
    partial class UC_TaskList
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
            this.contentPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pagination = new miniSys0._3.Controls.Others.UC_Pagination();
            this.uC_Task_Item2 = new miniSys0._3.Controls.Others.UC_Task_Item();
            this.uC_Task_Item1 = new miniSys0._3.Controls.Others.UC_Task_Item();
            this.urC_Crumbs1 = new miniSys0._3.Controls.Others.UrC_Crumbs();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.Container.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.Color.White;
            this.Container.Controls.Add(this.pagination);
            this.Container.Controls.Add(this.searchIcon);
            this.Container.Controls.Add(this.searchBox);
            this.Container.Controls.Add(this.dfinishedCard);
            this.Container.Controls.Add(this.repairingCard);
            this.Container.Controls.Add(this.noStartCard);
            this.Container.Controls.Add(this.allCard);
            this.Container.Controls.Add(this.contentPanel);
            this.Container.Controls.Add(this.label1);
            this.Container.FillColor = System.Drawing.Color.White;
            this.Container.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Container.Location = new System.Drawing.Point(3, 59);
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
            // searchIcon
            // 
            this.searchIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchIcon.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchIcon.Location = new System.Drawing.Point(1021, 54);
            this.searchIcon.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Shape = Sunny.UI.UIShape.Square;
            this.searchIcon.Size = new System.Drawing.Size(33, 33);
            this.searchIcon.Style = Sunny.UI.UIStyle.Custom;
            this.searchIcon.Symbol = 61442;
            this.searchIcon.SymbolSize = 30;
            this.searchIcon.TabIndex = 97;
            this.searchIcon.Text = "uiAvatar2";
            this.searchIcon.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // searchBox
            // 
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchBox.Location = new System.Drawing.Point(753, 53);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.searchBox.Name = "searchBox";
            this.searchBox.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.searchBox.ShowText = false;
            this.searchBox.Size = new System.Drawing.Size(269, 35);
            this.searchBox.Style = Sunny.UI.UIStyle.Custom;
            this.searchBox.TabIndex = 96;
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
            this.dfinishedCard.Location = new System.Drawing.Point(458, 57);
            this.dfinishedCard.MinimumSize = new System.Drawing.Size(1, 1);
            this.dfinishedCard.Name = "dfinishedCard";
            this.dfinishedCard.Radius = 25;
            this.dfinishedCard.Size = new System.Drawing.Size(100, 30);
            this.dfinishedCard.Style = Sunny.UI.UIStyle.Custom;
            this.dfinishedCard.TabIndex = 95;
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
            this.repairingCard.Location = new System.Drawing.Point(325, 57);
            this.repairingCard.MinimumSize = new System.Drawing.Size(1, 1);
            this.repairingCard.Name = "repairingCard";
            this.repairingCard.Radius = 25;
            this.repairingCard.Size = new System.Drawing.Size(100, 30);
            this.repairingCard.Style = Sunny.UI.UIStyle.Custom;
            this.repairingCard.TabIndex = 94;
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
            this.noStartCard.Location = new System.Drawing.Point(192, 57);
            this.noStartCard.MinimumSize = new System.Drawing.Size(1, 1);
            this.noStartCard.Name = "noStartCard";
            this.noStartCard.Radius = 25;
            this.noStartCard.Size = new System.Drawing.Size(100, 30);
            this.noStartCard.Style = Sunny.UI.UIStyle.Custom;
            this.noStartCard.TabIndex = 93;
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
            this.allCard.Location = new System.Drawing.Point(59, 57);
            this.allCard.MinimumSize = new System.Drawing.Size(1, 1);
            this.allCard.Name = "allCard";
            this.allCard.Radius = 25;
            this.allCard.Size = new System.Drawing.Size(100, 30);
            this.allCard.Style = Sunny.UI.UIStyle.Custom;
            this.allCard.TabIndex = 92;
            this.allCard.Text = "All ";
            this.allCard.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.allCard.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.allCard.Click += new System.EventHandler(this.switchButton1_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.uiLabel5);
            this.contentPanel.Controls.Add(this.uiLabel4);
            this.contentPanel.Controls.Add(this.uiLabel3);
            this.contentPanel.Controls.Add(this.uiLabel2);
            this.contentPanel.Controls.Add(this.uiLabel1);
            this.contentPanel.Controls.Add(this.uC_Task_Item2);
            this.contentPanel.Controls.Add(this.uC_Task_Item1);
            this.contentPanel.Location = new System.Drawing.Point(0, 96);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1115, 506);
            this.contentPanel.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font(".萍方-简", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Service requested list";
            // 
            // pagination
            // 
            this.pagination.BackColor = System.Drawing.Color.White;
            this.pagination.Location = new System.Drawing.Point(59, 616);
            this.pagination.Name = "pagination";
            this.pagination.Size = new System.Drawing.Size(1000, 40);
            this.pagination.TabIndex = 98;
            // 
            // uC_Task_Item2
            // 
            this.uC_Task_Item2.BackColor = System.Drawing.Color.White;
            this.uC_Task_Item2.Location = new System.Drawing.Point(3, 96);
            this.uC_Task_Item2.Name = "uC_Task_Item2";
            this.uC_Task_Item2.Size = new System.Drawing.Size(1100, 47);
            this.uC_Task_Item2.TabIndex = 8;
            // 
            // uC_Task_Item1
            // 
            this.uC_Task_Item1.BackColor = System.Drawing.Color.White;
            this.uC_Task_Item1.Location = new System.Drawing.Point(3, 43);
            this.uC_Task_Item1.Name = "uC_Task_Item1";
            this.uC_Task_Item1.Size = new System.Drawing.Size(1100, 47);
            this.uC_Task_Item1.TabIndex = 7;
            // 
            // urC_Crumbs1
            // 
            this.urC_Crumbs1.BackColor = System.Drawing.Color.Transparent;
            this.urC_Crumbs1.Location = new System.Drawing.Point(0, 4);
            this.urC_Crumbs1.Name = "urC_Crumbs1";
            this.urC_Crumbs1.Size = new System.Drawing.Size(300, 35);
            this.urC_Crumbs1.TabIndex = 2;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(15, 11);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 9;
            this.uiLabel1.Text = "Order ID";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(165, 17);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 10;
            this.uiLabel2.Text = "Decription";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(930, 17);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 11;
            this.uiLabel3.Text = "Operation";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(713, 17);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 23);
            this.uiLabel4.TabIndex = 12;
            this.uiLabel4.Text = "Update Time";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(571, 17);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(100, 23);
            this.uiLabel5.TabIndex = 13;
            this.uiLabel5.Text = "Status";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // UC_TaskList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.Container);
            this.Controls.Add(this.urC_Crumbs1);
            this.Name = "UC_TaskList";
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
        private Sunny.UI.UIAvatar searchIcon;
        private Sunny.UI.UITextBox searchBox;
        private Sunny.UI.UIButton dfinishedCard;
        private Sunny.UI.UIButton repairingCard;
        private Sunny.UI.UIButton noStartCard;
        private Sunny.UI.UIButton allCard;
        private Others.UC_Pagination pagination;
        private Others.UC_Task_Item uC_Task_Item2;
        private Others.UC_Task_Item uC_Task_Item1;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
    }
}
