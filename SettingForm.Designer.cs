namespace miniSys0._3
{
    partial class SettingForm
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
            this.general = new Sunny.UI.UILabel();
            this.message = new Sunny.UI.UILabel();
            this.export = new Sunny.UI.UILabel();
            this.privacy = new Sunny.UI.UILabel();
            this.line = new Sunny.UI.UILine();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // general
            // 
            this.general.Cursor = System.Windows.Forms.Cursors.Hand;
            this.general.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.general.Location = new System.Drawing.Point(22, 10);
            this.general.Name = "general";
            this.general.Size = new System.Drawing.Size(80, 30);
            this.general.Style = Sunny.UI.UIStyle.Custom;
            this.general.TabIndex = 0;
            this.general.Text = "General ";
            this.general.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.general.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.general.Click += new System.EventHandler(this.general_Click);
            // 
            // message
            // 
            this.message.Cursor = System.Windows.Forms.Cursors.Hand;
            this.message.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.message.Location = new System.Drawing.Point(110, 10);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(80, 30);
            this.message.Style = Sunny.UI.UIStyle.Custom;
            this.message.TabIndex = 1;
            this.message.Text = "Message";
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.message.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.message.Click += new System.EventHandler(this.message_Click);
            // 
            // export
            // 
            this.export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.export.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.export.Location = new System.Drawing.Point(286, 10);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(80, 30);
            this.export.Style = Sunny.UI.UIStyle.Custom;
            this.export.TabIndex = 3;
            this.export.Text = "Export";
            this.export.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.export.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // privacy
            // 
            this.privacy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.privacy.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.privacy.Location = new System.Drawing.Point(198, 10);
            this.privacy.Name = "privacy";
            this.privacy.Size = new System.Drawing.Size(80, 30);
            this.privacy.Style = Sunny.UI.UIStyle.Custom;
            this.privacy.TabIndex = 2;
            this.privacy.Text = "Privacy";
            this.privacy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.privacy.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.privacy.Click += new System.EventHandler(this.privacy_Click);
            // 
            // line
            // 
            this.line.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.line.Location = new System.Drawing.Point(0, 42);
            this.line.MinimumSize = new System.Drawing.Size(1, 1);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(380, 15);
            this.line.Style = Sunny.UI.UIStyle.Custom;
            this.line.TabIndex = 4;
            this.line.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 240);
            this.panel1.TabIndex = 5;
            // 
            // SettingForm
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 300);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.line);
            this.Controls.Add(this.export);
            this.Controls.Add(this.privacy);
            this.Controls.Add(this.message);
            this.Controls.Add(this.general);
            this.Name = "SettingForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.RectColor = System.Drawing.Color.Gainsboro;
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.ShowTitle = false;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "SettingForm";
            this.TopMost = true;
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel general;
        private Sunny.UI.UILabel message;
        private Sunny.UI.UILabel export;
        private Sunny.UI.UILabel privacy;
        private Sunny.UI.UILine line;
        private System.Windows.Forms.Panel panel1;
    }
}