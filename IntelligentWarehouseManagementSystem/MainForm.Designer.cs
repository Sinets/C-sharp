namespace IntelligentWarehouseManagementSystem
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.仓库状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品监控ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.温湿度监控ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仓库操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品出库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.网络配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.货仓设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.仓库状态ToolStripMenuItem,
            this.仓库操作ToolStripMenuItem,
            this.网络配置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(508, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 仓库状态ToolStripMenuItem
            // 
            this.仓库状态ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.商品监控ToolStripMenuItem,
            this.温湿度监控ToolStripMenuItem});
            this.仓库状态ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("仓库状态ToolStripMenuItem.Image")));
            this.仓库状态ToolStripMenuItem.Name = "仓库状态ToolStripMenuItem";
            this.仓库状态ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.仓库状态ToolStripMenuItem.Text = "仓库状态";
            this.仓库状态ToolStripMenuItem.Click += new System.EventHandler(this.仓库状态ToolStripMenuItem_Click);
            // 
            // 商品监控ToolStripMenuItem
            // 
            this.商品监控ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("商品监控ToolStripMenuItem.Image")));
            this.商品监控ToolStripMenuItem.Name = "商品监控ToolStripMenuItem";
            this.商品监控ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.商品监控ToolStripMenuItem.Text = "商品监控";
            this.商品监控ToolStripMenuItem.Click += new System.EventHandler(this.商品监控ToolStripMenuItem_Click);
            // 
            // 温湿度监控ToolStripMenuItem
            // 
            this.温湿度监控ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("温湿度监控ToolStripMenuItem.Image")));
            this.温湿度监控ToolStripMenuItem.Name = "温湿度监控ToolStripMenuItem";
            this.温湿度监控ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.温湿度监控ToolStripMenuItem.Text = "温湿度监控";
            this.温湿度监控ToolStripMenuItem.Click += new System.EventHandler(this.温湿度监控ToolStripMenuItem_Click);
            // 
            // 仓库操作ToolStripMenuItem
            // 
            this.仓库操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.商品登记ToolStripMenuItem,
            this.商品入库ToolStripMenuItem,
            this.商品出库ToolStripMenuItem});
            this.仓库操作ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("仓库操作ToolStripMenuItem.Image")));
            this.仓库操作ToolStripMenuItem.Name = "仓库操作ToolStripMenuItem";
            this.仓库操作ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.仓库操作ToolStripMenuItem.Text = "仓库操作";
            // 
            // 商品登记ToolStripMenuItem
            // 
            this.商品登记ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("商品登记ToolStripMenuItem.Image")));
            this.商品登记ToolStripMenuItem.Name = "商品登记ToolStripMenuItem";
            this.商品登记ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.商品登记ToolStripMenuItem.Text = "商品登记";
            this.商品登记ToolStripMenuItem.Click += new System.EventHandler(this.商品登记ToolStripMenuItem_Click);
            // 
            // 商品入库ToolStripMenuItem
            // 
            this.商品入库ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("商品入库ToolStripMenuItem.Image")));
            this.商品入库ToolStripMenuItem.Name = "商品入库ToolStripMenuItem";
            this.商品入库ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.商品入库ToolStripMenuItem.Text = "商品入库";
            this.商品入库ToolStripMenuItem.Click += new System.EventHandler(this.商品入库ToolStripMenuItem_Click);
            // 
            // 商品出库ToolStripMenuItem
            // 
            this.商品出库ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("商品出库ToolStripMenuItem.Image")));
            this.商品出库ToolStripMenuItem.Name = "商品出库ToolStripMenuItem";
            this.商品出库ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.商品出库ToolStripMenuItem.Text = "商品出库";
            this.商品出库ToolStripMenuItem.Click += new System.EventHandler(this.商品出库ToolStripMenuItem_Click);
            // 
            // 网络配置ToolStripMenuItem
            // 
            this.网络配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.货仓设置ToolStripMenuItem});
            this.网络配置ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("网络配置ToolStripMenuItem.Image")));
            this.网络配置ToolStripMenuItem.Name = "网络配置ToolStripMenuItem";
            this.网络配置ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.网络配置ToolStripMenuItem.Text = "仓库设置";
            this.网络配置ToolStripMenuItem.Click += new System.EventHandler(this.网络配置ToolStripMenuItem_Click);
            // 
            // 货仓设置ToolStripMenuItem
            // 
            this.货仓设置ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("货仓设置ToolStripMenuItem.Image")));
            this.货仓设置ToolStripMenuItem.Name = "货仓设置ToolStripMenuItem";
            this.货仓设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.货仓设置ToolStripMenuItem.Text = "货仓设置";
            this.货仓设置ToolStripMenuItem.Click += new System.EventHandler(this.货仓设置ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(196, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文仿宋", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(209, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "黑米科技";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(154, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "做最好的米，让别的米抄去吧";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 357);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "智能仓储管理系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 仓库状态ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 仓库操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 网络配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品监控ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 温湿度监控ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品登记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品入库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品出库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 货仓设置ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

