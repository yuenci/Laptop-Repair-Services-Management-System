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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiUserControl2 = new Sunny.UI.UIUserControl();
            this.serviceType = new Sunny.UI.UIComboBox();
            this.order = new Sunny.UI.UIComboBox();
            this.uC_ReportTable_card1 = new miniSys0._3.Controls.Others.UC_ReportTable_card();
            this.uiUserControl1.SuspendLayout();
            this.uiUserControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTIme
            // 
            this.dateTIme.DataSource = null;
            this.dateTIme.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
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
            // 
            // uiUserControl1
            // 
            this.uiUserControl1.BackColor = System.Drawing.Color.White;
            this.uiUserControl1.Controls.Add(this.uiLabel4);
            this.uiUserControl1.Controls.Add(this.uiLabel5);
            this.uiUserControl1.Controls.Add(this.uiLabel6);
            this.uiUserControl1.Controls.Add(this.uiLabel3);
            this.uiUserControl1.Controls.Add(this.uiLabel2);
            this.uiUserControl1.Controls.Add(this.uiLabel1);
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
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.uiLabel1.Location = new System.Drawing.Point(429, 15);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(197, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "Total service quantity";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.uiLabel2.Location = new System.Drawing.Point(23, 15);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(318, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "Average monthly service quantity";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.uiLabel3.Location = new System.Drawing.Point(714, 15);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(297, 23);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 2;
            this.uiLabel3.Text = "Maximum monthly service quantity";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font(".萍方-简", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.ForeColor = System.Drawing.Color.Black;
            this.uiLabel4.Location = new System.Drawing.Point(714, 53);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(297, 43);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 5;
            this.uiLabel4.Text = "100";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font(".萍方-简", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.ForeColor = System.Drawing.Color.Black;
            this.uiLabel5.Location = new System.Drawing.Point(23, 53);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(318, 43);
            this.uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel5.TabIndex = 4;
            this.uiLabel5.Text = "100";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel6
            // 
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font(".萍方-简", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.ForeColor = System.Drawing.Color.Black;
            this.uiLabel6.Location = new System.Drawing.Point(429, 53);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(197, 43);
            this.uiLabel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel6.TabIndex = 3;
            this.uiLabel6.Text = "100";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiUserControl2
            // 
            this.uiUserControl2.BackColor = System.Drawing.Color.White;
            this.uiUserControl2.Controls.Add(this.uC_ReportTable_card1);
            this.uiUserControl2.Controls.Add(this.order);
            this.uiUserControl2.Controls.Add(this.serviceType);
            this.uiUserControl2.Controls.Add(this.dateTIme);
            this.uiUserControl2.FillColor = System.Drawing.Color.White;
            this.uiUserControl2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiUserControl2.Location = new System.Drawing.Point(30, 175);
            this.uiUserControl2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiUserControl2.Name = "uiUserControl2";
            this.uiUserControl2.RectColor = System.Drawing.Color.Gainsboro;
            this.uiUserControl2.Size = new System.Drawing.Size(1055, 476);
            this.uiUserControl2.Style = Sunny.UI.UIStyle.Custom;
            this.uiUserControl2.TabIndex = 6;
            this.uiUserControl2.Text = "uiUserControl2";
            this.uiUserControl2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiUserControl2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // serviceType
            // 
            this.serviceType.DataSource = null;
            this.serviceType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
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
            this.serviceType.Location = new System.Drawing.Point(505, 24);
            this.serviceType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.serviceType.MinimumSize = new System.Drawing.Size(63, 0);
            this.serviceType.Name = "serviceType";
            this.serviceType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.serviceType.Size = new System.Drawing.Size(172, 29);
            this.serviceType.Style = Sunny.UI.UIStyle.Custom;
            this.serviceType.TabIndex = 1;
            this.serviceType.Text = "All";
            this.serviceType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.serviceType.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
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
            // 
            // uC_ReportTable_card1
            // 
            this.uC_ReportTable_card1.BackColor = System.Drawing.Color.Gainsboro;
            this.uC_ReportTable_card1.Location = new System.Drawing.Point(40, 70);
            this.uC_ReportTable_card1.Name = "uC_ReportTable_card1";
            this.uC_ReportTable_card1.Size = new System.Drawing.Size(973, 50);
            this.uC_ReportTable_card1.TabIndex = 2;
            // 
            // UC_Report_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiUserControl2);
            this.Controls.Add(this.uiUserControl1);
            this.Name = "UC_Report_table";
            this.Size = new System.Drawing.Size(1125, 675);
            this.uiUserControl1.ResumeLayout(false);
            this.uiUserControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIComboBox dateTIme;
        private Sunny.UI.UIUserControl uiUserControl1;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIUserControl uiUserControl2;
        private Sunny.UI.UIComboBox order;
        private Sunny.UI.UIComboBox serviceType;
        private UC_ReportTable_card uC_ReportTable_card1;
    }
}
