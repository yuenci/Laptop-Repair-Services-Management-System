namespace miniSys0._3
{
    partial class AddDescription
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
            this.textBox = new Sunny.UI.UIRichTextBox();
            this.uiLine2 = new Sunny.UI.UILine();
            this.ok = new Sunny.UI.UIButton();
            this.cancel = new Sunny.UI.UIButton();
            this.uiSymbolLabel = new Sunny.UI.UISymbolLabel();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.FillColor = System.Drawing.Color.White;
            this.textBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox.Location = new System.Drawing.Point(4, 67);
            this.textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.textBox.Name = "textBox";
            this.textBox.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.textBox.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.textBox.ShowText = false;
            this.textBox.Size = new System.Drawing.Size(592, 225);
            this.textBox.Style = Sunny.UI.UIStyle.Custom;
            this.textBox.TabIndex = 1;
            this.textBox.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.textBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.textBox.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // uiLine2
            // 
            this.uiLine2.BackColor = System.Drawing.Color.Transparent;
            this.uiLine2.FillColor = System.Drawing.Color.Transparent;
            this.uiLine2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine2.LineColor = System.Drawing.Color.Gainsboro;
            this.uiLine2.Location = new System.Drawing.Point(-1, 300);
            this.uiLine2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.RectSize = 2;
            this.uiLine2.Size = new System.Drawing.Size(600, 29);
            this.uiLine2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine2.TabIndex = 2;
            this.uiLine2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ok
            // 
            this.ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.ok.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ok.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ok.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Bold);
            this.ok.Location = new System.Drawing.Point(484, 335);
            this.ok.MinimumSize = new System.Drawing.Size(1, 1);
            this.ok.Name = "ok";
            this.ok.RectColor = System.Drawing.Color.Transparent;
            this.ok.RectHoverColor = System.Drawing.Color.Transparent;
            this.ok.RectPressColor = System.Drawing.Color.Transparent;
            this.ok.RectSelectedColor = System.Drawing.Color.Transparent;
            this.ok.Size = new System.Drawing.Size(100, 35);
            this.ok.Style = Sunny.UI.UIStyle.Custom;
            this.ok.TabIndex = 3;
            this.ok.Text = "OK";
            this.ok.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ok.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.cancel.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.cancel.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.cancel.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.cancel.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Bold);
            this.cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.cancel.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.cancel.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.cancel.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.cancel.Location = new System.Drawing.Point(360, 335);
            this.cancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.cancel.Name = "cancel";
            this.cancel.RectColor = System.Drawing.Color.Transparent;
            this.cancel.RectHoverColor = System.Drawing.Color.Transparent;
            this.cancel.RectPressColor = System.Drawing.Color.Transparent;
            this.cancel.RectSelectedColor = System.Drawing.Color.Transparent;
            this.cancel.Size = new System.Drawing.Size(100, 35);
            this.cancel.Style = Sunny.UI.UIStyle.Custom;
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Cancel";
            this.cancel.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // uiSymbolLabel
            // 
            this.uiSymbolLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
            this.uiSymbolLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolLabel.Location = new System.Drawing.Point(4, 335);
            this.uiSymbolLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel.Name = "uiSymbolLabel";
            this.uiSymbolLabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel.Size = new System.Drawing.Size(328, 35);
            this.uiSymbolLabel.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel.Symbol = 61528;
            this.uiSymbolLabel.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(42)))));
            this.uiSymbolLabel.TabIndex = 11;
            this.uiSymbolLabel.Text = "Add description successfully";
            this.uiSymbolLabel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // AddDescription
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 391);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.ControlBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.Controls.Add(this.uiSymbolLabel);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.uiLine2);
            this.Controls.Add(this.textBox);
            this.Font = new System.Drawing.Font(".萍方-简", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDescription";
            this.RectColor = System.Drawing.Color.Gainsboro;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "Add Description";
            this.TitleColor = System.Drawing.Color.White;
            this.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIRichTextBox textBox;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UIButton ok;
        private Sunny.UI.UIButton cancel;
        private Sunny.UI.UISymbolLabel uiSymbolLabel;
    }
}