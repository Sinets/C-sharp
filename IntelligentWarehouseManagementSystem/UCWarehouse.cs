using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntelligentWarehouseManagementSystem
{
    public partial class UCWarehouse : UserControl
    {
        MyClass.Cargo cargo;
        public UCWarehouse()
        {
            InitializeComponent();
        }
        public UCWarehouse(MyClass.Cargo cargo)
        {
            InitializeComponent();
            this.cargo = cargo;

            this.groupBox1.Text ="货仓："+ this.cargo.Tab_Name.ToString();
        

            List<MyClass.Register> list = MyClass.Register.GetObjectList(this.cargo);

            this.label1.Text = list.Count.ToString();

            foreach (MyClass.Register reg in list)
            {
                ListViewItem item = new ListViewItem();
                item.Text = reg.TagID;
                item.Tag = reg;
                item.SubItems.Add(reg.Name);

                this.listView1.Items.Add(item);
            }
        }
        public void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count > 0)
            {
                MyClass.Register reg = this.listView1.SelectedItems[0].Tag as MyClass.Register;
                this.label2.Text = reg.Name;
            }
        }
    }
}
