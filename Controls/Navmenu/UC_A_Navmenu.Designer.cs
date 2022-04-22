namespace miniSys0._3.Controls
{
    partial class UC_A_Navmenu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Workbench");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("  Dashboard", 0, 1, new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Register");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Post");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Price");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("  Form", 2, 3, new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Service report");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Income analysis");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("  Data", 4, 5, new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("User info");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("User settings");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("  Profile", 6, 7, new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_A_Navmenu));
            this.NavMenu = new Sunny.UI.UINavMenu();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // NavMenu
            // 
            this.NavMenu.BackColor = System.Drawing.Color.White;
            this.NavMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NavMenu.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.NavMenu.FillColor = System.Drawing.Color.White;
            this.NavMenu.Font = new System.Drawing.Font(".萍方-简", 13F, System.Drawing.FontStyle.Bold);
            this.NavMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.NavMenu.FullRowSelect = true;
            this.NavMenu.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.NavMenu.ItemHeight = 50;
            this.NavMenu.Location = new System.Drawing.Point(0, 0);
            this.NavMenu.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.NavMenu.Name = "NavMenu";
            treeNode1.Name = "节点2";
            treeNode1.Text = "Workbench";
            treeNode2.BackColor = System.Drawing.Color.White;
            treeNode2.ImageIndex = 0;
            treeNode2.Name = "node1";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "  Dashboard";
            treeNode3.Name = "节点5";
            treeNode3.Text = "Register";
            treeNode4.Name = "节点7";
            treeNode4.Text = "Post";
            treeNode5.Name = "节点2";
            treeNode5.Text = "Price";
            treeNode6.ImageIndex = 2;
            treeNode6.Name = "node2";
            treeNode6.SelectedImageIndex = 3;
            treeNode6.Text = "  Form";
            treeNode7.Name = "节点1";
            treeNode7.Text = "Service report";
            treeNode8.Name = "节点2";
            treeNode8.Text = "Income analysis";
            treeNode9.ImageIndex = 4;
            treeNode9.Name = "节点0";
            treeNode9.SelectedImageIndex = 5;
            treeNode9.Text = "  Data";
            treeNode10.Name = "节点4";
            treeNode10.Text = "User info";
            treeNode11.Name = "节点5";
            treeNode11.Text = "User settings";
            treeNode12.ImageIndex = 6;
            treeNode12.Name = "节点3";
            treeNode12.SelectedImageIndex = 7;
            treeNode12.Text = "  Profile";
            this.NavMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode6,
            treeNode9,
            treeNode12});
            this.NavMenu.ScrollFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.NavMenu.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.NavMenu.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(93)))), ((int)(((byte)(255)))));
            this.NavMenu.SelectedHighColor = System.Drawing.Color.Transparent;
            this.NavMenu.ShowLines = false;
            this.NavMenu.Size = new System.Drawing.Size(187, 670);
            this.NavMenu.Style = Sunny.UI.UIStyle.Custom;
            this.NavMenu.TabIndex = 14;
            this.NavMenu.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NavMenu.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1dashboard.png");
            this.imageList1.Images.SetKeyName(1, "1dashboardBlue.png");
            this.imageList1.Images.SetKeyName(2, "1form.png");
            this.imageList1.Images.SetKeyName(3, "1formBlue.png");
            this.imageList1.Images.SetKeyName(4, "1Frame.png");
            this.imageList1.Images.SetKeyName(5, "1FrameBlue.png");
            this.imageList1.Images.SetKeyName(6, "1profile.png");
            this.imageList1.Images.SetKeyName(7, "1profileBlue.png");
            // 
            // UC_A_Navmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NavMenu);
            this.Name = "UC_A_Navmenu";
            this.Size = new System.Drawing.Size(187, 670);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UINavMenu NavMenu;
        private System.Windows.Forms.ImageList imageList1;
    }
}
