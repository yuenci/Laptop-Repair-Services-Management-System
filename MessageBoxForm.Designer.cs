namespace miniSys0._3
{
    partial class MessageBoxForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiLine2 = new Sunny.UI.UILine();
            this.mark = new Sunny.UI.UILabel();
            this.delect = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(450, 320);
            this.panel.TabIndex = 1;
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine1.LineColor = System.Drawing.Color.Gainsboro;
            this.uiLine1.Location = new System.Drawing.Point(0, 320);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(450, 5);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 2;
            this.uiLine1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLine2
            // 
            this.uiLine2.BackColor = System.Drawing.Color.Transparent;
            this.uiLine2.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            this.uiLine2.FillColor = System.Drawing.Color.Transparent;
            this.uiLine2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine2.LineColor = System.Drawing.Color.Gainsboro;
            this.uiLine2.Location = new System.Drawing.Point(210, 323);
            this.uiLine2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(30, 43);
            this.uiLine2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine2.TabIndex = 3;
            this.uiLine2.Text = "uiLine2";
            this.uiLine2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // mark
            // 
            this.mark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mark.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mark.Location = new System.Drawing.Point(61, 335);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(100, 23);
            this.mark.Style = Sunny.UI.UIStyle.Custom;
            this.mark.TabIndex = 4;
            this.mark.Text = "Mark All";
            this.mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mark.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.mark.Click += new System.EventHandler(this.mark_Click);
            // 
            // delect
            // 
            this.delect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delect.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delect.Location = new System.Drawing.Point(285, 335);
            this.delect.Name = "delect";
            this.delect.Size = new System.Drawing.Size(100, 23);
            this.delect.Style = Sunny.UI.UIStyle.Custom;
            this.delect.TabIndex = 5;
            this.delect.Text = "Delect All";
            this.delect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delect.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.delect.Click += new System.EventHandler(this.delect_Click);
            // 
            // MessageBoxForm
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 367);
            this.Controls.Add(this.delect);
            this.Controls.Add(this.mark);
            this.Controls.Add(this.uiLine2);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.panel);
            this.Name = "MessageBoxForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowRadius = false;
            this.ShowRect = false;
            this.ShowShadow = true;
            this.ShowTitle = false;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "MessageBox";
            this.TopMost = true;
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UILabel mark;
        private Sunny.UI.UILabel delect;
    }
}