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
    public partial class ProductMonitoringForm : Form
    {
        public ProductMonitoringForm()
        {
            InitializeComponent();
        }

        private void ProductMonitoringForm_Load(object sender, EventArgs e)
        {
            List<MyClass.Cargo> list = MyClass.Cargo.GetObjectList();
            foreach (MyClass.Cargo cargo in list)
            {
                UCWarehouse uc = new UCWarehouse(cargo);
                this.flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void ProductMonitoringForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainForm.mainform.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
