namespace miniSys0._3.Controls.Others
{
    partial class UC_Report_table
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
            this.dateTIme = new Sunny.UI.UIComboBox();
            this.uiUserControl1 = new Sunny.UI.UIUserControl();
            this.maxLabel = new Sunny.UI.UILabel();
            this.aveLabel = new Sunny.UI.UILabel();
            this.totalLabel = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.reportContainer = new Sunny.UI.UIUserControl();
            this.caedsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.order = new Sunny.UI.UIComboBox();
            this.serviceType = new Sunny.UI.UIComboBox();
            this.uiUserControl1.SuspendLayout();
            this.reportContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTIme
            // 
            this.dateTIme.DataSource = null;
            this.dateTIme.FillColor = System.Drawing.Color.White;
            this.dateTIme.FilterMaxCount = 50;
            this.dateTIme.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTIme.Location = new System.Drawing.Point(708, 24);
            this.dateTIme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTIme.MinimumSize = new System.Drawing.Size(63, 0);
            this.dateTIme.Name = "dateTIme";
            this.dateTIme.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dateTIme.Size = new System.Drawing.Size(103, 29);
            this.dateTIme.Style = Sunny.UI.UIStyle.Custom;
            this.dateTIme.TabIndex = 0;
            this.dateTIme.Text = "2022";
            this.dateTIme.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateTIme.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.dateTIme.DropDownClosed += new System.EventHandler(this.dateTIme_DropDownClosed);
            // 
            // uiUserControl1
            // 
            this.uiUserControl1.BackColor = System.Drawing.Color.White;
            this.uiUserControl1.Controls.Add(this.maxLabel);
            this.uiUserControl1.Controls.Add(this.aveLabel);
            this.uiUserControl1.Controls.Add(this.totalLabel);
            this.uiUserControl1.Controls.Add(this.uiLabel3);
            this.uiUserControl1.Controls.Add(this.uiLabel1);
            this.uiUserControl1.Controls.Add(this.uiLabel2);
            this.uiUserControl1.FillColor = System.Drawing.Color.White;
            this.uiUserControl1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiUserControl1.Location = new System.Drawing.Point(30, 31);
            this.uiUserControl1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiUserControl1.Name = "uiUserControl1";
            this.uiUserControl1.RectColor = System.Drawing.Color.Gainsboro;
            this.uiUserControl1.Size = new System.Drawing.Size(1055, 107);
            this.uiUserControl1.Style = Sunny.UI.UIStyle.Custom;
            this.uiUserControl1.TabIndex = 1;
            this.uiUserControl1.Text = "uiUserControl1";
            this.uiUserControl1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiUserControl1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // maxLabel
            // 
            this.maxLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxLabel.Font = new System.Drawing.Font(".萍方-简", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maxLabel.Location = new System.Drawing.Point(714, 53);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(297, 43);
            this.maxLabel.Style = Sunny.UI.UIStyle.Custom;
            this.maxLabel.TabIndex = 5;
            this.maxLabel.Text = "100";
            this.maxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.maxLabel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // aveLabel
            // 
            this.aveLabel.BackColor = System.Drawing.Color.Transparent;
            this.aveLabel.Font = new System.Drawing.Font(".萍方-简", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.aveLabel.Location = new System.Drawing.Point(23, 53);
            this.aveLabel.Name = "aveLabel";
            this.aveLabel.Size = new System.Drawing.Size(318, 43);
            this.aveLabel.Style = Sunny.UI.UIStyle.Custom;
            this.aveLabel.TabIndex = 4;
            this.aveLabel.Text = "100";
            this.aveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aveLabel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.Font = new System.Drawing.Font(".萍方-简", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.totalLabel.Location = new System.Drawing.Point(429, 53);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(197, 43);
            this.totalLabel.Style = Sunny.UI.UIStyle.Custom;
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "100";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalLabel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(714, 15);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(297, 23);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 2;
            this.uiLabel3.Text = "Maximum monthly service quantity";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(23, 15);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(318, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "Average monthly service quantity";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(429, 15);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(197, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 0;
            this.uiLabel2.Text = "Total service quantity";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // reportContainer
            // 
            this.reportContainer.BackColor = System.Drawing.Color.White;
            this.reportContainer.Controls.Add(this.caedsPanel);
            this.reportContainer.Controls.Add(this.order);
            this.reportContainer.Controls.Add(this.serviceType);
            this.reportContainer.Controls.Add(this.dateTIme);
            this.reportContainer.FillColor = System.Drawing.Color.White;
            this.reportContainer.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reportContainer.Location = new System.Drawing.Point(30, 175);
            this.reportContainer.MinimumSize = new System.Drawing.Size(1, 1);
            this.reportContainer.Name = "reportContainer";
            this.reportContainer.RectColor = System.Drawing.Color.Gainsboro;
            this.reportContainer.Size = new System.Drawing.Size(1055, 476);
            this.reportContainer.Style = Sunny.UI.UIStyle.Custom;
            this.reportContainer.TabIndex = 6;
            this.reportContainer.Text = "uiUserControl2";
            this.reportContainer.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.reportContainer.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // caedsPanel
            // 
            this.caedsPanel.AutoScroll = true;
            this.caedsPanel.BackColor = System.Drawing.Color.Transparent;
            this.caedsPanel.Location = new System.Drawing.Point(29, 61);
            this.caedsPanel.Name = "caedsPanel";
            this.caedsPanel.Size = new System.Drawing.Size(1006, 412);
            this.caedsPanel.TabIndex = 2;
            // 
            // order
            // 
            this.order.DataSource = null;
            this.order.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.order.FillColor = System.Drawing.Color.White;
            this.order.FilterMaxCount = 50;
            this.order.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.order.Items.AddRange(new object[] {
            "Month Ascending",
            "Month Descending",
            "Quantity Ascending",
            "Quantity Descending"});
            this.order.Location = new System.Drawing.Point(833, 24);
            this.order.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.order.MinimumSize = new System.Drawing.Size(63, 0);
            this.order.Name = "order";
            this.order.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.order.Size = new System.Drawing.Size(184, 29);
            this.order.Style = Sunny.UI.UIStyle.Custom;
            this.order.TabIndex = 1;
            this.order.Text = "Month Ascending";
            this.order.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.order.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.order.DropDownClosed += new System.EventHandler(this.order_DropDownClosed);
            // 
            // serviceType
            // 
            this.serviceType.DataSource = null;
            this.serviceType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.serviceType.DropDownWidth = 300;
            this.serviceType.FillColor = System.Drawing.Color.White;
            this.serviceType.FilterMaxCount = 50;
            this.serviceType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.serviceType.Items.AddRange(new object[] {
            "All",
            "Remove virus, malware or spyware",
            "Troubleshot and fix computer running slow",
            "Laptop screen replacement",
            "Laptop keyboard replacement",
            "Laptop battery replacement",
            "Operating System Format and Installation",
            "Data backup and recovery",
            "Internet connectivity issues"});
            this.serviceType.Location = new System.Drawing.Point(334, 24);
            this.serviceType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.serviceType.MinimumSize = new System.Drawing.Size(63, 0);
            this.serviceType.Name = "serviceType";
            this.serviceType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.serviceType.Size = new System.Drawing.Size(343, 29);
            this.serviceType.Style = Sunny.UI.UIStyle.Custom;
            this.serviceType.TabIndex = 1;
            this.serviceType.Text = "All";
            this.serviceType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.serviceType.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.serviceType.DropDownClosed += new System.EventHandler(this.serviceType_DropDownClosed);
            // 
            // UC_Report_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportContainer);
            this.Controls.Add(this.uiUserControl1);
            this.Name = "UC_Report_table";
            this.Size = new System.Drawing.Size(1125, 675);
            this.uiUserControl1.ResumeLayout(false);
            this.reportContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIComboBox dateTIme;
        private Sunny.UI.UIUserControl uiUserControl1;
        private Sunny.UI.UILabel maxLabel;
        private Sunny.UI.UILabel aveLabel;
        private Sunny.UI.UILabel totalLabel;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIUserControl reportContainer;
        private Sunny.UI.UIComboBox order;
        private Sunny.UI.UIComboBox serviceType;
        private System.Windows.Forms.FlowLayoutPanel caedsPanel;
    }
}
