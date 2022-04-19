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
            this.password_input = new Sunny.UI.UITextBox();
            this.LoginButton = new Sunny.UI.UIButton();
            this.name_input = new Sunny.UI.UITextBox();
            this.Back_Button = new Sunny.UI.UISymbolButton();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.phone = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.valid = new System.Windows.Forms.Label();
            this.phone_line = new System.Windows.Forms.Panel();
            this.email_line = new System.Windows.Forms.Panel();
            this.valid_line = new System.Windows.Forms.Panel();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // password_input
            // 
            this.password_input.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.password_input.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.password_input.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.password_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_input.Font = new System.Drawing.Font(".萍方-简", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.password_input.Location = new System.Drawing.Point(15, 265);
            this.password_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.password_input.MinimumSize = new System.Drawing.Size(1, 16);
            this.password_input.Name = "password_input";
            this.password_input.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.password_input.Radius = 10;
            this.password_input.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.password_input.ShowText = false;
            this.password_input.Size = new System.Drawing.Size(463, 50);
            this.password_input.Style = Sunny.UI.UIStyle.Custom;
            this.password_input.TabIndex = 37;
            this.password_input.Text = "Enter the PIN code";
            this.password_input.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.password_input.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // LoginButton
            // 
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.LoginButton.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(100)))), ((int)(((byte)(221)))));
            this.LoginButton.Font = new System.Drawing.Font(".萍方-简", 18F);
            this.LoginButton.Location = new System.Drawing.Point(14, 425);
            this.LoginButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Radius = 10;
            this.LoginButton.RectColor = System.Drawing.Color.Transparent;
            this.LoginButton.RectDisableColor = System.Drawing.Color.Transparent;
            this.LoginButton.RectHoverColor = System.Drawing.Color.Transparent;
            this.LoginButton.RectPressColor = System.Drawing.Color.Transparent;
            this.LoginButton.RectSelectedColor = System.Drawing.Color.Transparent;
            this.LoginButton.Size = new System.Drawing.Size(463, 50);
            this.LoginButton.Style = Sunny.UI.UIStyle.Custom;
            this.LoginButton.TabIndex = 40;
            this.LoginButton.Text = "Reset";
            this.LoginButton.TipsFont = null;
            this.LoginButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
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
            // uiTextBox1
            // 
            this.uiTextBox1.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.uiTextBox1.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.uiTextBox1.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.Font = new System.Drawing.Font(".萍方-简", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.uiTextBox1.Location = new System.Drawing.Point(14, 345);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.uiTextBox1.Radius = 10;
            this.uiTextBox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(463, 50);
            this.uiTextBox1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox1.TabIndex = 38;
            this.uiTextBox1.Text = "Enter the New password";
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
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
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.uiButton1.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(100)))), ((int)(((byte)(221)))));
            this.uiButton1.Font = new System.Drawing.Font(".萍方-简", 18F);
            this.uiButton1.Location = new System.Drawing.Point(405, 185);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Radius = 10;
            this.uiButton1.RectColor = System.Drawing.Color.Transparent;
            this.uiButton1.RectDisableColor = System.Drawing.Color.Transparent;
            this.uiButton1.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiButton1.RectPressColor = System.Drawing.Color.Transparent;
            this.uiButton1.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uiButton1.Size = new System.Drawing.Size(72, 50);
            this.uiButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton1.TabIndex = 52;
            this.uiButton1.Text = "Send";
            this.uiButton1.TipsFont = null;
            this.uiButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.valid_line);
            this.Controls.Add(this.email_line);
            this.Controls.Add(this.phone_line);
            this.Controls.Add(this.valid);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.name_input);
            this.Name = "Control";
            this.Size = new System.Drawing.Size(490, 530);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UITextBox password_input;
        private Sunny.UI.UIButton LoginButton;
        private Sunny.UI.UITextBox name_input;
        private Sunny.UI.UISymbolButton Back_Button;
        private Sunny.UI.UITextBox uiTextBox1;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label valid;
        private System.Windows.Forms.Panel phone_line;
        private System.Windows.Forms.Panel email_line;
        private System.Windows.Forms.Panel valid_line;
        private Sunny.UI.UIButton uiButton1;
    }
}
