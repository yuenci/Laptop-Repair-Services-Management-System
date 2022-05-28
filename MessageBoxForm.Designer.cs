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
            this.SuspendLayout();
            // 
            // MessageBoxForm
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(455, 367);
            this.Name = "MessageBoxForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowRect = false;
            this.ShowTitle = false;
            this.Text = "MessageBox";
            this.TopMost = true;
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.ResumeLayout(false);

        }

        #endregion
    }
}