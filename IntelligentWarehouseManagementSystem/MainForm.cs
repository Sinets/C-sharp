using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntelligentWarehouseManagementSystem
{
    public partial class MainForm : Form
    {
        public static MainForm mainform = null;
        public MainForm()
        {
            InitializeComponent();
            mainform = this;
        }

        private void 网络配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 货仓设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new WarehouseSettingsForm().Show();
            
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void 商品登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MerchandiseRegistrationForm().Show();
        }

        private void 商品入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MerchandiseWarehousingForm().Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void 商品监控ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ProductMonitoringForm().Show();
        }

        private void 温湿度监控ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TemperatureAndHumidityMonitoringForm().Show();
        }

        private void 商品出库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MerchandiseOutOfTheLibraryForm().Show();
        }

        private void 仓库状态ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
