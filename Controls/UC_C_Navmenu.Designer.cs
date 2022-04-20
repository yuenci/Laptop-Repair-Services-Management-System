namespace miniSys0._3.Controls
{
    partial class UC_C_Navmenu
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Workbench");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("  Dashboard", 0, 1, new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Order details");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("  Order", 2, 3, new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("User info");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("User settings");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("  Profile", 4, 5, new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            this.receptionistNavMenu = new Sunny.UI.UINavMenu();
            this.SuspendLayout();
            // 
            // receptionistNavMenu
            // 
            this.receptionistNavMenu.BackColor = System.Drawing.Color.White;
            this.receptionistNavMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.receptionistNavMenu.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.receptionistNavMenu.FillColor = System.Drawing.Color.White;
            this.receptionistNavMenu.Font = new System.Drawing.Font(".萍方-简", 13F, System.Drawing.FontStyle.Bold);
            this.receptionistNavMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.receptionistNavMenu.FullRowSelect = true;
            this.receptionistNavMenu.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.receptionistNavMenu.ItemHeight = 50;
            this.receptionistNavMenu.Location = new System.Drawing.Point(0, 0);
            this.receptionistNavMenu.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.receptionistNavMenu.Name = "receptionistNavMenu";
            treeNode1.Name = "节点2";
            treeNode1.Text = "Workbench";
            treeNode2.BackColor = System.Drawing.Color.White;
            treeNode2.ImageIndex = 0;
            treeNode2.Name = "node1";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "  Dashboard";
            treeNode3.Name = "节点7";
            treeNode3.Text = "Order details";
            treeNode4.ImageIndex = 2;
            treeNode4.Name = "node2";
            treeNode4.SelectedImageIndex = 3;
            treeNode4.Text = "  Order";
            treeNode5.Name = "节点9";
            treeNode5.Text = "User info";
            treeNode6.Name = "节点10";
            treeNode6.Text = "User settings";
            treeNode7.ImageIndex = 4;
            treeNode7.Name = "node3";
            treeNode7.SelectedImageIndex = 5;
            treeNode7.Text = "  Profile";
            this.receptionistNavMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode7});
            this.receptionistNavMenu.ScrollFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.receptionistNavMenu.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.receptionistNavMenu.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.receptionistNavMenu.SelectedHighColor = System.Drawing.Color.Transparent;
            this.receptionistNavMenu.ShowLines = false;
            this.receptionistNavMenu.Size = new System.Drawing.Size(187, 670);
            this.receptionistNavMenu.Style = Sunny.UI.UIStyle.Custom;
            this.receptionistNavMenu.TabIndex = 13;
            this.receptionistNavMenu.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.receptionistNavMenu.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // UC_C_Navmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.receptionistNavMenu);
            this.Name = "UC_C_Navmenu";
            this.Size = new System.Drawing.Size(187, 670);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UINavMenu receptionistNavMenu;
    }
}
