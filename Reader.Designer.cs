namespace miniSys0._3
{
    partial class Reader
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
            this.panelBrower = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelBrower
            // 
            this.panelBrower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBrower.Location = new System.Drawing.Point(0, 35);
            this.panelBrower.Name = "panelBrower";
            this.panelBrower.Size = new System.Drawing.Size(800, 415);
            this.panelBrower.TabIndex = 0;
            // 
            // Reader
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBrower);
            this.MaximizeBox = false;
            this.Name = "Reader";
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "Reader";
            this.TopMost = true;
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBrower;
    }
}