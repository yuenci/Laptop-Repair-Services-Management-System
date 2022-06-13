namespace miniSys0._3.Controls.Others
{
    partial class Price_Card
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
            this.serviceType = new Sunny.UI.UILabel();
            this.normalFee = new Sunny.UI.UITextBox();
            this.urgentFee = new Sunny.UI.UITextBox();
            this.editIcon = new Sunny.UI.UIAvatar();
            this.normal = new Sunny.UI.UILabel();
            this.urgent = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // serviceType
            // 
            this.serviceType.Font = new System.Drawing.Font(".PingFang SC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.serviceType.Location = new System.Drawing.Point(13, 0);
            this.serviceType.Name = "serviceType";
            this.serviceType.Size = new System.Drawing.Size(523, 42);
            this.serviceType.TabIndex = 0;
            this.serviceType.Text = "Troubleshot and fix computer running slow";
            this.serviceType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.serviceType.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // normalFee
            // 
            this.normalFee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.normalFee.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.normalFee.Location = new System.Drawing.Point(100, 47);
            this.normalFee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.normalFee.MinimumSize = new System.Drawing.Size(1, 16);
            this.normalFee.Name = "normalFee";
            this.normalFee.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.normalFee.ShowText = false;
            this.normalFee.Size = new System.Drawing.Size(150, 29);
            this.normalFee.TabIndex = 1;
            this.normalFee.Text = "00";
            this.normalFee.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.normalFee.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // urgentFee
            // 
            this.urgentFee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.urgentFee.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.urgentFee.Location = new System.Drawing.Point(343, 47);
            this.urgentFee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.urgentFee.MinimumSize = new System.Drawing.Size(1, 16);
            this.urgentFee.Name = "urgentFee";
            this.urgentFee.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.urgentFee.ShowText = false;
            this.urgentFee.Size = new System.Drawing.Size(150, 29);
            this.urgentFee.TabIndex = 3;
            this.urgentFee.Text = "00";
            this.urgentFee.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.urgentFee.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // editIcon
            // 
            this.editIcon.AvatarSize = 30;
            this.editIcon.BackColor = System.Drawing.Color.Transparent;
            this.editIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editIcon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.editIcon.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.editIcon.ForeColor = System.Drawing.Color.White;
            this.editIcon.Location = new System.Drawing.Point(506, 46);
            this.editIcon.MinimumSize = new System.Drawing.Size(1, 1);
            this.editIcon.Name = "editIcon";
            this.editIcon.Shape = Sunny.UI.UIShape.Square;
            this.editIcon.Size = new System.Drawing.Size(30, 30);
            this.editIcon.Style = Sunny.UI.UIStyle.Custom;
            this.editIcon.Symbol = 61508;
            this.editIcon.SymbolSize = 25;
            this.editIcon.TabIndex = 17;
            this.editIcon.Text = "edit";
            this.editIcon.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.editIcon.Click += new System.EventHandler(this.editIcon_Click);
            // 
            // normal
            // 
            this.normal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.normal.Location = new System.Drawing.Point(13, 47);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(74, 29);
            this.normal.TabIndex = 18;
            this.normal.Text = "Normal:";
            this.normal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.normal.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // urgent
            // 
            this.urgent.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.urgent.Location = new System.Drawing.Point(263, 46);
            this.urgent.Name = "urgent";
            this.urgent.Size = new System.Drawing.Size(67, 30);
            this.urgent.TabIndex = 19;
            this.urgent.Text = "Urgent:";
            this.urgent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.urgent.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Price_Card
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.urgent);
            this.Controls.Add(this.normal);
            this.Controls.Add(this.editIcon);
            this.Controls.Add(this.urgentFee);
            this.Controls.Add(this.normalFee);
            this.Controls.Add(this.serviceType);
            this.Name = "Price_Card";
            this.Size = new System.Drawing.Size(549, 89);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel serviceType;
        private Sunny.UI.UITextBox normalFee;
        private Sunny.UI.UITextBox urgentFee;
        private Sunny.UI.UIAvatar editIcon;
        private Sunny.UI.UILabel normal;
        private Sunny.UI.UILabel urgent;
    }
}
