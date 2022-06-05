namespace miniSys0._3
{
    partial class TestForm
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.csharpRepairerIncDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.csharpRepairerIncDataSet = new miniSys0._3.CsharpRepairerIncDataSet();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptionistIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urgentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersTableAdapter = new miniSys0._3.CsharpRepairerIncDataSetTableAdapters.OrdersTableAdapter();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiPagination1 = new Sunny.UI.UIPagination();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uC_Pagination1 = new miniSys0._3.Controls.Others.UC_Pagination();
            this.uC_Task_Card1 = new miniSys0._3.Controls.Others.UC_Task_Card();
            this.urC_Crumbs1 = new miniSys0._3.Controls.Others.UrC_Crumbs();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csharpRepairerIncDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csharpRepairerIncDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(27, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Query";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(22, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "AddOne";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(27, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "QueryMany";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(22, 271);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 48);
            this.button4.TabIndex = 3;
            this.button4.Text = "AddOneToLast";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(39, 325);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(126, 35);
            this.uiButton1.TabIndex = 4;
            this.uiButton1.Text = "CreatePassword";
            this.uiButton1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.csharpRepairerIncDataSetBindingSource;
            // 
            // csharpRepairerIncDataSetBindingSource
            // 
            this.csharpRepairerIncDataSetBindingSource.DataSource = this.csharpRepairerIncDataSet;
            this.csharpRepairerIncDataSetBindingSource.Position = 0;
            // 
            // csharpRepairerIncDataSet
            // 
            this.csharpRepairerIncDataSet.DataSetName = "CsharpRepairerIncDataSet";
            this.csharpRepairerIncDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1008, 25);
            this.fillByToolStrip.TabIndex = 6;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(41, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.servicetypeDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.receptionistIDDataGridViewTextBoxColumn,
            this.urgentDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.paymentMethodDataGridViewTextBoxColumn,
            this.starDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(236, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(335, 295);
            this.dataGridView1.TabIndex = 7;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // servicetypeDataGridViewTextBoxColumn
            // 
            this.servicetypeDataGridViewTextBoxColumn.DataPropertyName = "Service_type";
            this.servicetypeDataGridViewTextBoxColumn.HeaderText = "Service_type";
            this.servicetypeDataGridViewTextBoxColumn.Name = "servicetypeDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // receptionistIDDataGridViewTextBoxColumn
            // 
            this.receptionistIDDataGridViewTextBoxColumn.DataPropertyName = "ReceptionistID";
            this.receptionistIDDataGridViewTextBoxColumn.HeaderText = "ReceptionistID";
            this.receptionistIDDataGridViewTextBoxColumn.Name = "receptionistIDDataGridViewTextBoxColumn";
            // 
            // urgentDataGridViewTextBoxColumn
            // 
            this.urgentDataGridViewTextBoxColumn.DataPropertyName = "Urgent";
            this.urgentDataGridViewTextBoxColumn.HeaderText = "Urgent";
            this.urgentDataGridViewTextBoxColumn.Name = "urgentDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // paymentMethodDataGridViewTextBoxColumn
            // 
            this.paymentMethodDataGridViewTextBoxColumn.DataPropertyName = "Payment_Method";
            this.paymentMethodDataGridViewTextBoxColumn.HeaderText = "Payment_Method";
            this.paymentMethodDataGridViewTextBoxColumn.Name = "paymentMethodDataGridViewTextBoxColumn";
            // 
            // starDataGridViewTextBoxColumn
            // 
            this.starDataGridViewTextBoxColumn.DataPropertyName = "Star";
            this.starDataGridViewTextBoxColumn.HeaderText = "Star";
            this.starDataGridViewTextBoxColumn.Name = "starDataGridViewTextBoxColumn";
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(345, 325);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(100, 35);
            this.uiButton2.TabIndex = 8;
            this.uiButton2.Text = "Execute";
            this.uiButton2.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiPagination1
            // 
            this.uiPagination1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPagination1.Location = new System.Drawing.Point(13, 377);
            this.uiPagination1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPagination1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPagination1.Name = "uiPagination1";
            this.uiPagination1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPagination1.ShowText = false;
            this.uiPagination1.Size = new System.Drawing.Size(631, 35);
            this.uiPagination1.TabIndex = 9;
            this.uiPagination1.Text = "uiPagination1";
            this.uiPagination1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPagination1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uC_Pagination1);
            this.panel1.Location = new System.Drawing.Point(22, 445);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 118);
            this.panel1.TabIndex = 10;
            // 
            // uC_Pagination1
            // 
            this.uC_Pagination1.BackColor = System.Drawing.Color.White;
            this.uC_Pagination1.Location = new System.Drawing.Point(-37, 42);
            this.uC_Pagination1.Name = "uC_Pagination1";
            this.uC_Pagination1.Size = new System.Drawing.Size(1000, 40);
            this.uC_Pagination1.TabIndex = 0;
            // 
            // uC_Task_Card1
            // 
            this.uC_Task_Card1.BackColor = System.Drawing.Color.White;
            this.uC_Task_Card1.Location = new System.Drawing.Point(211, 66);
            this.uC_Task_Card1.Name = "uC_Task_Card1";
            this.uC_Task_Card1.Size = new System.Drawing.Size(305, 145);
            this.uC_Task_Card1.TabIndex = 11;
            // 
            // urC_Crumbs1
            // 
            this.urC_Crumbs1.BackColor = System.Drawing.SystemColors.Control;
            this.urC_Crumbs1.Location = new System.Drawing.Point(271, 243);
            this.urC_Crumbs1.Name = "urC_Crumbs1";
            this.urC_Crumbs1.Size = new System.Drawing.Size(300, 35);
            this.urC_Crumbs1.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(664, 364);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(769, 364);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(722, 46);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 60);
            this.button7.TabIndex = 15;
            this.button7.Text = "ArticalData";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(733, 222);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(99, 35);
            this.button8.TabIndex = 16;
            this.button8.Text = "searchtest";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(683, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 21);
            this.textBox1.TabIndex = 17;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 599);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.urC_Crumbs1);
            this.Controls.Add(this.uC_Task_Card1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiPagination1);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csharpRepairerIncDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csharpRepairerIncDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Sunny.UI.UIButton uiButton1;
        private System.Windows.Forms.BindingSource csharpRepairerIncDataSetBindingSource;
        private CsharpRepairerIncDataSet csharpRepairerIncDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private CsharpRepairerIncDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicetypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptionistIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urgentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starDataGridViewTextBoxColumn;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIPagination uiPagination1;
        private System.Windows.Forms.Panel panel1;
        private Controls.Others.UC_Pagination uC_Pagination1;
        private Controls.Others.UC_Task_Card uC_Task_Card1;
        private Controls.Others.UrC_Crumbs urC_Crumbs1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox1;
    }
}