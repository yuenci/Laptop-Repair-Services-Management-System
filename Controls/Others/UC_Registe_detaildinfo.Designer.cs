namespace miniSys0._3.Controls.Others
{
    partial class UC_Registe_detaildinfo
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
            this.email = new Sunny.UI.UITextBox();
            this.phone = new Sunny.UI.UITextBox();
            this.emailLabel = new Sunny.UI.UILabel();
            this.label4 = new System.Windows.Forms.Label();
            this.nextStepBtn = new Sunny.UI.UIButton();
            this.squestion = new Sunny.UI.UIComboBox();
            this.squestionLabel = new Sunny.UI.UILabel();
            this.countryLabel = new Sunny.UI.UILabel();
            this.phoneLabel = new Sunny.UI.UILabel();
            this.genderLabel = new Sunny.UI.UILabel();
            this.answerLabel = new Sunny.UI.UILabel();
            this.addressLabel = new Sunny.UI.UILabel();
            this.birthdayLabel = new Sunny.UI.UILabel();
            this.birthDatePicker = new Sunny.UI.UIDatePicker();
            this.profile = new Sunny.UI.UIRichTextBox();
            this.profileLabel = new Sunny.UI.UILabel();
            this.gender = new Sunny.UI.UIComboBox();
            this.country = new Sunny.UI.UITextBox();
            this.address = new Sunny.UI.UITextBox();
            this.sanswer = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.email.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.email.Location = new System.Drawing.Point(192, 90);
            this.email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.email.MinimumSize = new System.Drawing.Size(1, 16);
            this.email.Name = "email";
            this.email.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.email.RectColor = System.Drawing.Color.Gray;
            this.email.RectDisableColor = System.Drawing.Color.White;
            this.email.ShowText = false;
            this.email.Size = new System.Drawing.Size(343, 35);
            this.email.Style = Sunny.UI.UIStyle.Custom;
            this.email.TabIndex = 110;
            this.email.Text = "Enter user\'s email";
            this.email.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.email.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // phone
            // 
            this.phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.phone.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.phone.Location = new System.Drawing.Point(192, 17);
            this.phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phone.MinimumSize = new System.Drawing.Size(1, 16);
            this.phone.Name = "phone";
            this.phone.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.phone.RectColor = System.Drawing.Color.Gray;
            this.phone.RectDisableColor = System.Drawing.Color.White;
            this.phone.ShowText = false;
            this.phone.Size = new System.Drawing.Size(343, 35);
            this.phone.Style = Sunny.UI.UIStyle.Custom;
            this.phone.TabIndex = 107;
            this.phone.Text = "Enter user\'s phone";
            this.phone.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.phone.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // emailLabel
            // 
            this.emailLabel.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.emailLabel.Location = new System.Drawing.Point(68, 90);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(100, 35);
            this.emailLabel.Style = Sunny.UI.UIStyle.Custom;
            this.emailLabel.TabIndex = 108;
            this.emailLabel.Text = "Email";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.emailLabel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(25, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 27);
            this.label4.TabIndex = 104;
            this.label4.Text = "*";
            // 
            // nextStepBtn
            // 
            this.nextStepBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextStepBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.nextStepBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.nextStepBtn.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.nextStepBtn.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nextStepBtn.Location = new System.Drawing.Point(435, 416);
            this.nextStepBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.nextStepBtn.Name = "nextStepBtn";
            this.nextStepBtn.RectColor = System.Drawing.Color.White;
            this.nextStepBtn.RectHoverColor = System.Drawing.Color.White;
            this.nextStepBtn.RectPressColor = System.Drawing.Color.White;
            this.nextStepBtn.RectSelectedColor = System.Drawing.Color.White;
            this.nextStepBtn.Size = new System.Drawing.Size(100, 35);
            this.nextStepBtn.Style = Sunny.UI.UIStyle.Custom;
            this.nextStepBtn.TabIndex = 103;
            this.nextStepBtn.Text = "Next";
            this.nextStepBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nextStepBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.nextStepBtn.Click += new System.EventHandler(this.nextStepBtn_Click);
            // 
            // squestion
            // 
            this.squestion.DataSource = null;
            this.squestion.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.squestion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.squestion.FilterMaxCount = 50;
            this.squestion.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.squestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.squestion.Items.AddRange(new object[] {
            "What is your favorie food?",
            "What is your first teacher\'s name?",
            "What is your father\'s middle name?",
            "What is your city of birth?",
            "What is your library card number?",
            "What is your frequent flyer number",
            "What is your first phone number?"});
            this.squestion.ItemSelectBackColor = System.Drawing.Color.Silver;
            this.squestion.Location = new System.Drawing.Point(192, 236);
            this.squestion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.squestion.MinimumSize = new System.Drawing.Size(63, 0);
            this.squestion.Name = "squestion";
            this.squestion.Padding = new System.Windows.Forms.Padding(8, 0, 30, 2);
            this.squestion.RectColor = System.Drawing.Color.Gray;
            this.squestion.Size = new System.Drawing.Size(343, 35);
            this.squestion.Style = Sunny.UI.UIStyle.Custom;
            this.squestion.TabIndex = 98;
            this.squestion.Text = "Select a security question";
            this.squestion.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.squestion.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // squestionLabel
            // 
            this.squestionLabel.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.squestionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.squestionLabel.Location = new System.Drawing.Point(0, 236);
            this.squestionLabel.Name = "squestionLabel";
            this.squestionLabel.Size = new System.Drawing.Size(168, 35);
            this.squestionLabel.Style = Sunny.UI.UIStyle.Custom;
            this.squestionLabel.TabIndex = 102;
            this.squestionLabel.Text = "Security question";
            this.squestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.squestionLabel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // countryLabel
            // 
            this.countryLabel.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.countryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.countryLabel.Location = new System.Drawing.Point(59, 163);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(109, 35);
            this.countryLabel.Style = Sunny.UI.UIStyle.Custom;
            this.countryLabel.TabIndex = 101;
            this.countryLabel.Text = "Country";
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.countryLabel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // phoneLabel
            // 
            this.phoneLabel.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.phoneLabel.Location = new System.Drawing.Point(26, 17);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(142, 35);
            this.phoneLabel.Style = Sunny.UI.UIStyle.Custom;
            this.phoneLabel.TabIndex = 100;
            this.phoneLabel.Text = "Phone number";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.phoneLabel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // genderLabel
            // 
            this.genderLabel.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.genderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.genderLabel.Location = new System.Drawing.Point(592, 90);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(100, 35);
            this.genderLabel.Style = Sunny.UI.UIStyle.Custom;
            this.genderLabel.TabIndex = 120;
            this.genderLabel.Text = "Gender";
            this.genderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.genderLabel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // answerLabel
            // 
            this.answerLabel.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.answerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.answerLabel.Location = new System.Drawing.Point(559, 236);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(133, 35);
            this.answerLabel.Style = Sunny.UI.UIStyle.Custom;
            this.answerLabel.TabIndex = 115;
            this.answerLabel.Text = "Answer";
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.answerLabel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // addressLabel
            // 
            this.addressLabel.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.addressLabel.Location = new System.Drawing.Point(583, 163);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(109, 35);
            this.addressLabel.Style = Sunny.UI.UIStyle.Custom;
            this.addressLabel.TabIndex = 114;
            this.addressLabel.Text = "Address";
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addressLabel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.birthdayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.birthdayLabel.Location = new System.Drawing.Point(592, 17);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(100, 35);
            this.birthdayLabel.Style = Sunny.UI.UIStyle.Custom;
            this.birthdayLabel.TabIndex = 113;
            this.birthdayLabel.Text = "Birthday";
            this.birthdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.birthdayLabel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.birthDatePicker.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.birthDatePicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.birthDatePicker.Location = new System.Drawing.Point(722, 17);
            this.birthDatePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.birthDatePicker.MaxLength = 10;
            this.birthDatePicker.MinimumSize = new System.Drawing.Size(63, 0);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Padding = new System.Windows.Forms.Padding(8, 0, 30, 2);
            this.birthDatePicker.RectColor = System.Drawing.Color.Gray;
            this.birthDatePicker.Size = new System.Drawing.Size(343, 35);
            this.birthDatePicker.Style = Sunny.UI.UIStyle.Custom;
            this.birthDatePicker.SymbolDropDown = 61555;
            this.birthDatePicker.SymbolNormal = 61555;
            this.birthDatePicker.TabIndex = 123;
            this.birthDatePicker.Text = "2022-04-24";
            this.birthDatePicker.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.birthDatePicker.Value = new System.DateTime(2022, 4, 24, 14, 54, 18, 878);
            this.birthDatePicker.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // profile
            // 
            this.profile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.profile.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.profile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.profile.Location = new System.Drawing.Point(192, 309);
            this.profile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.profile.MinimumSize = new System.Drawing.Size(1, 1);
            this.profile.Name = "profile";
            this.profile.Padding = new System.Windows.Forms.Padding(8, 2, 2, 2);
            this.profile.RectColor = System.Drawing.Color.Gray;
            this.profile.ShowText = false;
            this.profile.Size = new System.Drawing.Size(873, 82);
            this.profile.Style = Sunny.UI.UIStyle.Custom;
            this.profile.TabIndex = 124;
            this.profile.Text = "Enter user\'s personal introduction with a maximum of 300 characters.";
            this.profile.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.profile.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // profileLabel
            // 
            this.profileLabel.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.profileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.profileLabel.Location = new System.Drawing.Point(0, 312);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(168, 35);
            this.profileLabel.Style = Sunny.UI.UIStyle.Custom;
            this.profileLabel.TabIndex = 125;
            this.profileLabel.Text = "Profile";
            this.profileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.profileLabel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // gender
            // 
            this.gender.DataSource = null;
            this.gender.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.gender.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.gender.FilterMaxCount = 50;
            this.gender.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.gender.Items.AddRange(new object[] {
            "Malel",
            "Female"});
            this.gender.ItemSelectBackColor = System.Drawing.Color.Silver;
            this.gender.Location = new System.Drawing.Point(722, 90);
            this.gender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gender.MinimumSize = new System.Drawing.Size(63, 0);
            this.gender.Name = "gender";
            this.gender.Padding = new System.Windows.Forms.Padding(8, 0, 30, 2);
            this.gender.RectColor = System.Drawing.Color.Gray;
            this.gender.Size = new System.Drawing.Size(343, 35);
            this.gender.Style = Sunny.UI.UIStyle.Custom;
            this.gender.TabIndex = 113;
            this.gender.Text = "Select user\'s gender";
            this.gender.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.gender.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // country
            // 
            this.country.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.country.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.country.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.country.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.country.Location = new System.Drawing.Point(192, 163);
            this.country.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.country.MinimumSize = new System.Drawing.Size(1, 16);
            this.country.Name = "country";
            this.country.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.country.RectColor = System.Drawing.Color.Gray;
            this.country.RectDisableColor = System.Drawing.Color.White;
            this.country.ShowText = false;
            this.country.Size = new System.Drawing.Size(343, 35);
            this.country.Style = Sunny.UI.UIStyle.Custom;
            this.country.TabIndex = 111;
            this.country.Text = "Enter user\'s country";
            this.country.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.country.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // address
            // 
            this.address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.address.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.address.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.address.Location = new System.Drawing.Point(722, 163);
            this.address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.address.MinimumSize = new System.Drawing.Size(1, 16);
            this.address.Name = "address";
            this.address.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.address.RectColor = System.Drawing.Color.Gray;
            this.address.RectDisableColor = System.Drawing.Color.White;
            this.address.ShowText = false;
            this.address.Size = new System.Drawing.Size(343, 35);
            this.address.Style = Sunny.UI.UIStyle.Custom;
            this.address.TabIndex = 112;
            this.address.Text = "Enter user\'s address";
            this.address.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.address.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // sanswer
            // 
            this.sanswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sanswer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.sanswer.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sanswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.sanswer.Location = new System.Drawing.Point(722, 236);
            this.sanswer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sanswer.MinimumSize = new System.Drawing.Size(1, 16);
            this.sanswer.Name = "sanswer";
            this.sanswer.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.sanswer.RectColor = System.Drawing.Color.Gray;
            this.sanswer.RectDisableColor = System.Drawing.Color.White;
            this.sanswer.ShowText = false;
            this.sanswer.Size = new System.Drawing.Size(343, 35);
            this.sanswer.Style = Sunny.UI.UIStyle.Custom;
            this.sanswer.TabIndex = 113;
            this.sanswer.Text = "Enter a answer";
            this.sanswer.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.sanswer.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // UC_Registe_detaildinfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.sanswer);
            this.Controls.Add(this.address);
            this.Controls.Add(this.country);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.profileLabel);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.birthDatePicker);
            this.Controls.Add(this.email);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nextStepBtn);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.squestion);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.squestionLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.phoneLabel);
            this.Name = "UC_Registe_detaildinfo";
            this.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.Size = new System.Drawing.Size(1115, 492);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Sunny.UI.UITextBox email;
        public Sunny.UI.UITextBox phone;
        private Sunny.UI.UILabel emailLabel;
        private System.Windows.Forms.Label label4;
        private Sunny.UI.UIButton nextStepBtn;
        public Sunny.UI.UIComboBox squestion;
        private Sunny.UI.UILabel squestionLabel;
        private Sunny.UI.UILabel countryLabel;
        private Sunny.UI.UILabel phoneLabel;
        private Sunny.UI.UILabel genderLabel;
        private Sunny.UI.UILabel answerLabel;
        private Sunny.UI.UILabel addressLabel;
        private Sunny.UI.UILabel birthdayLabel;
        public Sunny.UI.UIDatePicker birthDatePicker;
        public Sunny.UI.UIRichTextBox profile;
        private Sunny.UI.UILabel profileLabel;
        public Sunny.UI.UIComboBox gender;
        public Sunny.UI.UITextBox country;
        public Sunny.UI.UITextBox address;
        public Sunny.UI.UITextBox sanswer;
    }
}
