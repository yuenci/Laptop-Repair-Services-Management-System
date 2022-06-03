namespace miniSys0._3.Controls.Others
{
    partial class UC_ReciptSubmit
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.brand = new Sunny.UI.UITextBox();
            this.method = new Sunny.UI.UIComboBox();
            this.type = new Sunny.UI.UIComboBox();
            this.model = new Sunny.UI.UITextBox();
            this.name = new Sunny.UI.UITextBox();
            this.resetButton = new Sunny.UI.UIButton();
            this.submitButton = new Sunny.UI.UIButton();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.switch1 = new Sunny.UI.UISwitch();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.errorBar = new Sunny.UI.UISymbolLabel();
            this.successIcon = new Sunny.UI.UIAvatar();
            this.cardID = new Sunny.UI.UITextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(683, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "--";
            // 
            // brand
            // 
            this.brand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.brand.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.brand.Location = new System.Drawing.Point(415, 295);
            this.brand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.brand.MinimumSize = new System.Drawing.Size(1, 16);
            this.brand.Name = "brand";
            this.brand.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.brand.ShowText = false;
            this.brand.Size = new System.Drawing.Size(245, 40);
            this.brand.Style = Sunny.UI.UIStyle.Custom;
            this.brand.TabIndex = 23;
            this.brand.Text = "Customer\'s computer Brand";
            this.brand.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.brand.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // method
            // 
            this.method.DataSource = null;
            this.method.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.method.FillColor = System.Drawing.Color.White;
            this.method.FilterMaxCount = 50;
            this.method.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.method.Items.AddRange(new object[] {
            "Credit Card",
            "Paypal",
            "Cash",
            "Check"});
            this.method.Location = new System.Drawing.Point(415, 370);
            this.method.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.method.MinimumSize = new System.Drawing.Size(63, 0);
            this.method.Name = "method";
            this.method.Padding = new System.Windows.Forms.Padding(8, 0, 30, 2);
            this.method.Size = new System.Drawing.Size(555, 40);
            this.method.Style = Sunny.UI.UIStyle.Custom;
            this.method.TabIndex = 25;
            this.method.Text = "Select a Payment Method";
            this.method.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.method.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.method.DropDownClosed += new System.EventHandler(this.method_DropDownClosed);
            // 
            // type
            // 
            this.type.DataSource = null;
            this.type.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.type.FillColor = System.Drawing.Color.White;
            this.type.FilterMaxCount = 50;
            this.type.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.type.Items.AddRange(new object[] {
            "Remove virus, malware or spyware",
            "Troubleshot and fix computer running slow",
            "Laptop screen replacement",
            "Laptop keyboard replacement",
            "Laptop battery replacement",
            "Operating System Format and Installation",
            "Data backup and recovery",
            "Internet connectivity issues"});
            this.type.Location = new System.Drawing.Point(415, 156);
            this.type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.type.MinimumSize = new System.Drawing.Size(63, 0);
            this.type.Name = "type";
            this.type.Padding = new System.Windows.Forms.Padding(8, 0, 30, 2);
            this.type.Size = new System.Drawing.Size(553, 40);
            this.type.Style = Sunny.UI.UIStyle.Custom;
            this.type.TabIndex = 21;
            this.type.Text = "Select a service type";
            this.type.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.type.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // model
            // 
            this.model.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.model.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.model.Location = new System.Drawing.Point(725, 295);
            this.model.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.model.MinimumSize = new System.Drawing.Size(1, 16);
            this.model.Name = "model";
            this.model.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.model.ShowText = false;
            this.model.Size = new System.Drawing.Size(245, 40);
            this.model.Style = Sunny.UI.UIStyle.Custom;
            this.model.TabIndex = 24;
            this.model.Text = "Customer\'s computer model";
            this.model.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.model.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // name
            // 
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.Location = new System.Drawing.Point(415, 81);
            this.name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name.MinimumSize = new System.Drawing.Size(1, 16);
            this.name.Name = "name";
            this.name.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.name.ShowText = false;
            this.name.Size = new System.Drawing.Size(553, 40);
            this.name.Style = Sunny.UI.UIStyle.Custom;
            this.name.TabIndex = 20;
            this.name.Text = "Enter customer\'s name";
            this.name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.name.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.name.Leave += new System.EventHandler(this.name_Leave);
            this.name.Enter += new System.EventHandler(this.name_Enter);
            // 
            // resetButton
            // 
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resetButton.Location = new System.Drawing.Point(643, 513);
            this.resetButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(100, 35);
            this.resetButton.Style = Sunny.UI.UIStyle.Custom;
            this.resetButton.TabIndex = 27;
            this.resetButton.Text = "Reset";
            this.resetButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resetButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitButton.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.submitButton.Location = new System.Drawing.Point(415, 513);
            this.submitButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 35);
            this.submitButton.Style = Sunny.UI.UIStyle.Custom;
            this.submitButton.TabIndex = 26;
            this.submitButton.Text = "Submit";
            this.submitButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.submitButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(157, 377);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(162, 23);
            this.uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel5.TabIndex = 18;
            this.uiLabel5.Text = "Payment Method:";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(167, 303);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(152, 23);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 17;
            this.uiLabel4.Text = "Computer model:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // switch1
            // 
            this.switch1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.switch1.ActiveText = "Yes";
            this.switch1.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.switch1.InActiveText = "No";
            this.switch1.Location = new System.Drawing.Point(415, 231);
            this.switch1.MinimumSize = new System.Drawing.Size(1, 1);
            this.switch1.Name = "switch1";
            this.switch1.Size = new System.Drawing.Size(75, 29);
            this.switch1.Style = Sunny.UI.UIStyle.Custom;
            this.switch1.TabIndex = 22;
            this.switch1.Text = "uiSwitch1";
            this.switch1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(145, 232);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(174, 23);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 15;
            this.uiLabel3.Text = "Urgent:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(145, 162);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(174, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 14;
            this.uiLabel2.Text = "Service type:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(145, 89);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(174, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 13;
            this.uiLabel1.Text = "Customer name:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // errorBar
            // 
            this.errorBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.errorBar.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.errorBar.Location = new System.Drawing.Point(415, 15);
            this.errorBar.MinimumSize = new System.Drawing.Size(1, 1);
            this.errorBar.Name = "errorBar";
            this.errorBar.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.errorBar.Size = new System.Drawing.Size(553, 35);
            this.errorBar.Style = Sunny.UI.UIStyle.Custom;
            this.errorBar.Symbol = 61527;
            this.errorBar.SymbolColor = System.Drawing.Color.Red;
            this.errorBar.TabIndex = 27;
            this.errorBar.Text = "Name does not exist, please register first.";
            this.errorBar.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // successIcon
            // 
            this.successIcon.BackColor = System.Drawing.Color.Transparent;
            this.successIcon.FillColor = System.Drawing.Color.Transparent;
            this.successIcon.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.successIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(42)))));
            this.successIcon.Location = new System.Drawing.Point(971, 75);
            this.successIcon.MinimumSize = new System.Drawing.Size(1, 1);
            this.successIcon.Name = "successIcon";
            this.successIcon.Size = new System.Drawing.Size(50, 50);
            this.successIcon.Style = Sunny.UI.UIStyle.Custom;
            this.successIcon.Symbol = 61528;
            this.successIcon.SymbolSize = 30;
            this.successIcon.TabIndex = 28;
            this.successIcon.Text = "uiAvatar1";
            this.successIcon.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cardID
            // 
            this.cardID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cardID.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cardID.Location = new System.Drawing.Point(415, 435);
            this.cardID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cardID.MinimumSize = new System.Drawing.Size(1, 16);
            this.cardID.Name = "cardID";
            this.cardID.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.cardID.ShowText = false;
            this.cardID.Size = new System.Drawing.Size(553, 40);
            this.cardID.TabIndex = 29;
            this.cardID.Text = "Enter bank card / Account  ID";
            this.cardID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cardID.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.cardID.Enter += new System.EventHandler(this.cardID_Enter);
            // 
            // UC_ReciptSubmit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cardID);
            this.Controls.Add(this.successIcon);
            this.Controls.Add(this.errorBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.method);
            this.Controls.Add(this.type);
            this.Controls.Add(this.model);
            this.Controls.Add(this.name);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.switch1);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Name = "UC_ReciptSubmit";
            this.Size = new System.Drawing.Size(1115, 578);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Sunny.UI.UITextBox brand;
        private Sunny.UI.UIComboBox method;
        private Sunny.UI.UIComboBox type;
        private Sunny.UI.UITextBox model;
        private Sunny.UI.UITextBox name;
        private Sunny.UI.UIButton resetButton;
        private Sunny.UI.UIButton submitButton;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UISwitch switch1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UISymbolLabel errorBar;
        public Sunny.UI.UIAvatar successIcon;
        private Sunny.UI.UITextBox cardID;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
