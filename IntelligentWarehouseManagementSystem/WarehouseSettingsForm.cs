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
    public partial class WarehouseSettingsForm : Form
    {
        public MyClass.Cargo cargo;
        public WarehouseSettingsForm()
        {
            InitializeComponent();
        }

        private void WarehouseSettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            MainForm.mainform.Show();
            this.Hide();
        }

      
        private bool ValidControlCargo()
        {
            if (cmbCargo.SelectedIndex < 0)
            {
                MessageBox.Show("请选择货仓通道号");
                return false;
            }

            if (txtMax.Text == "")
            {
                MessageBox.Show("请输入货仓的最大商品数");
                return false;
            }

            if (txtMin.Text == "")
            {
                MessageBox.Show("请输入货仓的最小商品数");
                return false;
            }

            if (Convert.ToInt32(txtMax.Text.Trim()) <= Convert.ToInt32(txtMin.Text.Trim()))
            {
                MessageBox.Show("最大商品数必须大于最小商品数");
                return false;
            }

            return true;

        }
        private void WarehouseSettingsForm_Load(object sender, EventArgs e)
        {
            cmbCargo.SelectedIndex = 0;
        }
        private void SetControlCargo(MyClass.Cargo cargo)
        {
            this.cmbCargo.Text = cargo.Tab_Name.ToString();
            this.txtMax.Text = cargo.Max.ToString();
            this.txtMin.Text = cargo.Min.ToString();
        }
        private void GetControlCargo(MyClass.Cargo cargo)
        {
            cargo.Tab_Name = Convert.ToInt32(this.cmbCargo.Text.Trim());
            cargo.Max = Convert.ToInt32(this.txtMax.Text.Trim());
            cargo.Min = Convert.ToInt32(this.txtMin.Text.Trim());
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (!ValidControlCargo())
            {
                return;
            }
            this.cargo = new MyClass.Cargo();
            GetControlCargo(this.cargo);

            bool result = this.cargo.Select();
            if (result)
            {
                MessageBox.Show("该货仓已经设置");
            }
            else
            {
                bool temp = this.cargo.Insert();
                if (temp)
                {
                    MessageBox.Show("设置成功");
                    SetControlCargo(this.cargo);
                }
                else
                {
                    MessageBox.Show("设置失败");
                }
            }
        }

        private void btnRevise_Click(object sender, EventArgs e)
        {
            if (!ValidControlCargo())
            {
                return;
            }
            this.cargo = new MyClass.Cargo();
            GetControlCargo(this.cargo);
            bool Temp = this.cargo.Update();

            if (Temp)
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }

        

    }
}
