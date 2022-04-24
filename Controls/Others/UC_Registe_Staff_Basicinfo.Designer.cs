namespace miniSys0._3.Controls.Others
{
    partial class UC_Registe_Staff_Basicinfo
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nextStepBtn = new Sunny.UI.UIButton();
            this.selectPost = new Sunny.UI.UIComboBox();
            this.selectDepartment = new Sunny.UI.UIComboBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.nameTextBox = new Sunny.UI.UITextBox();
            this.IDnumberTextBox = new Sunny.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDnumber = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(372, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 27);
            this.label3.TabIndex = 93;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(311, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 27);
            this.label2.TabIndex = 92;
            this.label2.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(358, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 27);
            this.label4.TabIndex = 91;
            this.label4.Text = "*";
            // 
            // nextStepBtn
            // 
            this.nextStepBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextStepBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.nextStepBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.nextStepBtn.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.nextStepBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nextStepBtn.Location = new System.Drawing.Point(463, 389);
            this.nextStepBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.nextStepBtn.Name = "nextStepBtn";
            this.nextStepBtn.RectColor = System.Drawing.Color.White;
            this.nextStepBtn.RectHoverColor = System.Drawing.Color.White;
            this.nextStepBtn.RectPressColor = System.Drawing.Color.White;
            this.nextStepBtn.RectSelectedColor = System.Drawing.Color.White;
            this.nextStepBtn.Size = new System.Drawing.Size(100, 35);
            this.nextStepBtn.Style = Sunny.UI.UIStyle.Custom;
            this.nextStepBtn.TabIndex = 90;
            this.nextStepBtn.Text = "Next";
            this.nextStepBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nextStepBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.nextStepBtn.Click += new System.EventHandler(this.nextStepBtn_Click);
            // 
            // selectPost
            // 
            this.selectPost.DataSource = null;
            this.selectPost.Enabled = false;
            this.selectPost.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.selectPost.FilterMaxCount = 50;
            this.selectPost.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.selectPost.ItemSelectBackColor = System.Drawing.Color.Silver;
            this.selectPost.Location = new System.Drawing.Point(463, 310);
            this.selectPost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectPost.MinimumSize = new System.Drawing.Size(63, 0);
            this.selectPost.Name = "selectPost";
            this.selectPost.Padding = new System.Windows.Forms.Padding(8, 0, 30, 2);
            this.selectPost.RectColor = System.Drawing.Color.Gray;
            this.selectPost.Size = new System.Drawing.Size(343, 35);
            this.selectPost.Style = Sunny.UI.UIStyle.Custom;
            this.selectPost.TabIndex = 85;
            this.selectPost.Text = "Select user\'s post";
            this.selectPost.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectPost.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.selectPost.DropDown += new System.EventHandler(this.selectPost_DropDown);
            this.selectPost.DropDownClosed += new System.EventHandler(this.selectPost_DropDownClosed);
            // 
            // selectDepartment
            // 
            this.selectDepartment.DataSource = null;
            this.selectDepartment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.selectDepartment.FilterMaxCount = 50;
            this.selectDepartment.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.selectDepartment.Items.AddRange(new object[] {
            "Service department",
            "Technican department"});
            this.selectDepartment.ItemSelectBackColor = System.Drawing.Color.Silver;
            this.selectDepartment.Location = new System.Drawing.Point(463, 231);
            this.selectDepartment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectDepartment.MinimumSize = new System.Drawing.Size(63, 0);
            this.selectDepartment.Name = "selectDepartment";
            this.selectDepartment.Padding = new System.Windows.Forms.Padding(8, 0, 30, 2);
            this.selectDepartment.RectColor = System.Drawing.Color.Gray;
            this.selectDepartment.Size = new System.Drawing.Size(343, 35);
            this.selectDepartment.Style = Sunny.UI.UIStyle.Custom;
            this.selectDepartment.TabIndex = 86;
            this.selectDepartment.Text = "Select user\'s department";
            this.selectDepartment.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectDepartment.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.selectDepartment.SelectedIndexChanged += new System.EventHandler(this.selectDepartment_SelectedIndexChanged);
            this.selectDepartment.DropDown += new System.EventHandler(this.selectDepartment_DropDown);
            this.selectDepartment.DropDownClosed += new System.EventHandler(this.selectDepartment_DropDownClosed);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(332, 306);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 35);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 89;
            this.uiLabel3.Text = "Post";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(323, 228);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(109, 35);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 88;
            this.uiLabel2.Text = "Department";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(332, 72);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 35);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 87;
            this.uiLabel1.Text = "Name";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.nameTextBox.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.nameTextBox.Location = new System.Drawing.Point(463, 73);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.nameTextBox.RectColor = System.Drawing.Color.Gray;
            this.nameTextBox.RectDisableColor = System.Drawing.Color.White;
            this.nameTextBox.ShowText = false;
            this.nameTextBox.Size = new System.Drawing.Size(343, 35);
            this.nameTextBox.Style = Sunny.UI.UIStyle.Custom;
            this.nameTextBox.TabIndex = 94;
            this.nameTextBox.Text = "Enter the user\'s name";
            this.nameTextBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.nameTextBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.nameTextBox.Enter += new System.EventHandler(this.nameTextBox_Enter);
            // 
            // IDnumberTextBox
            // 
            this.IDnumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDnumberTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.IDnumberTextBox.Font = new System.Drawing.Font(".萍方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDnumberTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.IDnumberTextBox.Location = new System.Drawing.Point(463, 152);
            this.IDnumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IDnumberTextBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.IDnumberTextBox.Name = "IDnumberTextBox";
            this.IDnumberTextBox.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.IDnumberTextBox.RectColor = System.Drawing.Color.Gray;
            this.IDnumberTextBox.RectDisableColor = System.Drawing.Color.White;
            this.IDnumberTextBox.ShowText = false;
            this.IDnumberTextBox.Size = new System.Drawing.Size(343, 35);
            this.IDnumberTextBox.Style = Sunny.UI.UIStyle.Custom;
            this.IDnumberTextBox.TabIndex = 97;
            this.IDnumberTextBox.Text = "Enter the user\'s ID number";
            this.IDnumberTextBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.IDnumberTextBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.IDnumberTextBox.Enter += new System.EventHandler(this.IDnumberTextBox_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(323, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 27);
            this.label1.TabIndex = 96;
            this.label1.Text = "*";
            // 
            // IDnumber
            // 
            this.IDnumber.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDnumber.Location = new System.Drawing.Point(332, 150);
            this.IDnumber.Name = "IDnumber";
            this.IDnumber.Size = new System.Drawing.Size(100, 35);
            this.IDnumber.Style = Sunny.UI.UIStyle.Custom;
            this.IDnumber.TabIndex = 95;
            this.IDnumber.Text = "ID number";
            this.IDnumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IDnumber.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // UC_Registe_Staff_Basicinfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.IDnumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.IDnumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nextStepBtn);
            this.Controls.Add(this.selectPost);
            this.Controls.Add(this.selectDepartment);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Name = "UC_Registe_Staff_Basicinfo";
            this.Size = new System.Drawing.Size(1115, 492);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Sunny.UI.UIButton nextStepBtn;
        private Sunny.UI.UIComboBox selectPost;
        private Sunny.UI.UIComboBox selectDepartment;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox nameTextBox;
        private Sunny.UI.UITextBox IDnumberTextBox;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UILabel IDnumber;
    }
}
