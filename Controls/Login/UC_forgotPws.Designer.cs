namespace miniSys0._3.Controls
{
    partial class Control
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
            this.pin_code_input = new Sunny.UI.UITextBox();
            this.resetButton = new Sunny.UI.UIButton();
            this.name_input = new Sunny.UI.UITextBox();
            this.Back_Button = new Sunny.UI.UISymbolButton();
            this.new_pws_input = new Sunny.UI.UITextBox();
            this.phone = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.valid = new System.Windows.Forms.Label();
            this.phone_line = new System.Windows.Forms.Panel();
            this.email_line = new System.Windows.Forms.Panel();
            this.valid_line = new System.Windows.Forms.Panel();
            this.sendBtn = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // pin_code_input
            // 
            this.pin_code_input.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.pin_code_input.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.pin_code_input.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.pin_code_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pin_code_input.Font = new System.Drawing.Font(".萍方-简", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pin_code_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.pin_code_input.Location = new System.Drawing.Point(15, 265);
            this.pin_code_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pin_code_input.MinimumSize = new System.Drawing.Size(1, 16);
            this.pin_code_input.Name = "pin_code_input";
            this.pin_code_input.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.pin_code_input.Radius = 10;
            this.pin_code_input.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.pin_code_input.ShowText = false;
            this.pin_code_input.Size = new System.Drawing.Size(463, 50);
            this.pin_code_input.Style = Sunny.UI.UIStyle.Custom;
            this.pin_code_input.TabIndex = 37;
            this.pin_code_input.Text = "Enter the PIN code";
            this.pin_code_input.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.pin_code_input.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // resetButton
            // 
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.resetButton.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(100)))), ((int)(((byte)(221)))));
            this.resetButton.Font = new System.Drawing.Font(".萍方-简", 18F);
            this.resetButton.Location = new System.Drawing.Point(14, 425);
            this.resetButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.resetButton.Name = "resetButton";
            this.resetButton.Radius = 10;
            this.resetButton.RectColor = System.Drawing.Color.Transparent;
            this.resetButton.RectDisableColor = System.Drawing.Color.Transparent;
            this.resetButton.RectHoverColor = System.Drawing.Color.Transparent;
            this.resetButton.RectPressColor = System.Drawing.Color.Transparent;
            this.resetButton.RectSelectedColor = System.Drawing.Color.Transparent;
            this.resetButton.Size = new System.Drawing.Size(463, 50);
            this.resetButton.Style = Sunny.UI.UIStyle.Custom;
            this.resetButton.TabIndex = 40;
            this.resetButton.Text = "Reset";
            this.resetButton.TipsFont = null;
            this.resetButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // name_input
            // 
            this.name_input.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.name_input.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.name_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_input.Font = new System.Drawing.Font(".萍方-简", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.name_input.Location = new System.Drawing.Point(15, 185);
            this.name_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name_input.MinimumSize = new System.Drawing.Size(1, 16);
            this.name_input.Name = "name_input";
            this.name_input.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.name_input.Radius = 10;
            this.name_input.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.name_input.ShowText = false;
            this.name_input.Size = new System.Drawing.Size(387, 50);
            this.name_input.Style = Sunny.UI.UIStyle.Custom;
            this.name_input.TabIndex = 36;
            this.name_input.Text = "Enter your phone number";
            this.name_input.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.name_input.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Back_Button
            // 
            this.Back_Button.BackColor = System.Drawing.Color.White;
            this.Back_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_Button.FillColor = System.Drawing.Color.Transparent;
            this.Back_Button.FillHoverColor = System.Drawing.Color.Transparent;
            this.Back_Button.FillPressColor = System.Drawing.Color.Transparent;
            this.Back_Button.FillSelectedColor = System.Drawing.Color.Transparent;
            this.Back_Button.Font = new System.Drawing.Font(".萍方-简", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Back_Button.ForeColor = System.Drawing.Color.Black;
            this.Back_Button.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(100)))), ((int)(((byte)(221)))));
            this.Back_Button.Location = new System.Drawing.Point(-39, 32);
            this.Back_Button.MinimumSize = new System.Drawing.Size(1, 1);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.RectColor = System.Drawing.Color.Transparent;
            this.Back_Button.RectHoverColor = System.Drawing.Color.Transparent;
            this.Back_Button.RectPressColor = System.Drawing.Color.Transparent;
            this.Back_Button.RectSelectedColor = System.Drawing.Color.Transparent;
            this.Back_Button.Size = new System.Drawing.Size(191, 48);
            this.Back_Button.Style = Sunny.UI.UIStyle.Custom;
            this.Back_Button.Symbol = 52;
            this.Back_Button.SymbolColor = System.Drawing.Color.Black;
            this.Back_Button.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(100)))), ((int)(((byte)(221)))));
            this.Back_Button.SymbolOffset = new System.Drawing.Point(20, 0);
            this.Back_Button.SymbolPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(100)))), ((int)(((byte)(221)))));
            this.Back_Button.SymbolSize = 60;
            this.Back_Button.TabIndex = 46;
            this.Back_Button.Text = "Back";
            this.Back_Button.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Back_Button.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Back_Button.Click += new System.EventHandler(this.Back_Click);
            // 
            // new_pws_input
            // 
            this.new_pws_input.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.new_pws_input.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.new_pws_input.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.new_pws_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.new_pws_input.Font = new System.Drawing.Font(".萍方-简", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.new_pws_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.new_pws_input.Location = new System.Drawing.Point(14, 345);
            this.new_pws_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.new_pws_input.MinimumSize = new System.Drawing.Size(1, 16);
            this.new_pws_input.Name = "new_pws_input";
            this.new_pws_input.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.new_pws_input.Radius = 10;
            this.new_pws_input.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.new_pws_input.ShowText = false;
            this.new_pws_input.Size = new System.Drawing.Size(463, 50);
            this.new_pws_input.Style = Sunny.UI.UIStyle.Custom;
            this.new_pws_input.TabIndex = 38;
            this.new_pws_input.Text = "Enter the New password";
            this.new_pws_input.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.new_pws_input.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.phone.Font = new System.Drawing.Font(".萍方-简", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.phone.Location = new System.Drawing.Point(13, 115);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(157, 28);
            this.phone.TabIndex = 47;
            this.phone.Text = "Phone Number";
            this.phone.Click += new System.EventHandler(this.phone_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Cursor = System.Windows.Forms.Cursors.Hand;
            this.email.Font = new System.Drawing.Font(".萍方-简", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.email.Location = new System.Drawing.Point(192, 115);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(153, 28);
            this.email.TabIndex = 48;
            this.email.Text = "Email Address";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // valid
            // 
            this.valid.AutoSize = true;
            this.valid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.valid.Font = new System.Drawing.Font(".萍方-简", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.valid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.valid.Location = new System.Drawing.Point(367, 115);
            this.valid.Name = "valid";
            this.valid.Size = new System.Drawing.Size(110, 28);
            this.valid.TabIndex = 49;
            this.valid.Text = "Validation";
            this.valid.Click += new System.EventHandler(this.valid_Click);
            // 
            // phone_line
            // 
            this.phone_line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.phone_line.Location = new System.Drawing.Point(18, 149);
            this.phone_line.Name = "phone_line";
            this.phone_line.Size = new System.Drawing.Size(147, 3);
            this.phone_line.TabIndex = 50;
            // 
            // email_line
            // 
            this.email_line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.email_line.Location = new System.Drawing.Point(197, 149);
            this.email_line.Name = "email_line";
            this.email_line.Size = new System.Drawing.Size(143, 3);
            this.email_line.TabIndex = 51;
            // 
            // valid_line
            // 
            this.valid_line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.valid_line.Location = new System.Drawing.Point(373, 149);
            this.valid_line.Name = "valid_line";
            this.valid_line.Size = new System.Drawing.Size(100, 3);
            this.valid_line.TabIndex = 51;
            // 
            // sendBtn
            // 
            this.sendBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.sendBtn.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(100)))), ((int)(((byte)(221)))));
            this.sendBtn.Font = new System.Drawing.Font(".萍方-简", 18F);
            this.sendBtn.Location = new System.Drawing.Point(405, 185);
            this.sendBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Radius = 10;
            this.sendBtn.RectColor = System.Drawing.Color.Transparent;
            this.sendBtn.RectDisableColor = System.Drawing.Color.Transparent;
            this.sendBtn.RectHoverColor = System.Drawing.Color.Transparent;
            this.sendBtn.RectPressColor = System.Drawing.Color.Transparent;
            this.sendBtn.RectSelectedColor = System.Drawing.Color.Transparent;
            this.sendBtn.Size = new System.Drawing.Size(72, 50);
            this.sendBtn.Style = Sunny.UI.UIStyle.Custom;
            this.sendBtn.TabIndex = 52;
            this.sendBtn.Text = "Send";
            this.sendBtn.TipsFont = null;
            this.sendBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.valid_line);
            this.Controls.Add(this.email_line);
            this.Controls.Add(this.phone_line);
            this.Controls.Add(this.valid);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.new_pws_input);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.pin_code_input);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.name_input);
            this.Name = "Control";
            this.Size = new System.Drawing.Size(490, 530);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UITextBox pin_code_input;
        private Sunny.UI.UIButton resetButton;
        private Sunny.UI.UITextBox name_input;
        private Sunny.UI.UISymbolButton Back_Button;
        private Sunny.UI.UITextBox new_pws_input;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label valid;
        private System.Windows.Forms.Panel phone_line;
        private System.Windows.Forms.Panel email_line;
        private System.Windows.Forms.Panel valid_line;
        private Sunny.UI.UIButton sendBtn;
    }
}
