using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace IntelligentWarehouseManagementSystem
{
    public partial class MerchandiseRegistrationForm : Form
    {
        public MyClass.Register regs = new MyClass.Register();
        //public MyClass.Cargo cargo;

        private Thread Thread_15693;
        public MerchandiseRegistrationForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            MainForm.mainform.Show();
            this.Hide();
        }
        private void SetControlRegister(MyClass.Register regi)
        {
            this.txtName.Text = regi.Name;
            this.cmbAntenna.Text = regi.Tab_Name.ToString();
            this.txtPrice.Text = regi.Price.ToString();
            this.txtLife.Text = regi.Life.ToString();
            this.dtpProduce.Text = regi.Produce.ToString();
        }

        private void GetControlRegister(MyClass.Register regs)
        {
            regs.TagID = this.cmbCardID.Text.Trim();
            regs.Tab_Name = Convert.ToInt32(this.cmbAntenna.Text.Trim());
            regs.Name = this.txtName.Text.Trim();

            regs.Price = Convert.ToInt32(this.txtPrice.Text.Trim());
            regs.Life = Convert.ToInt32(this.txtLife.Text.Trim());

            regs.Status = 0;    //0 表示商品登记
            regs.Produce = Convert.ToDateTime(this.dtpProduce.Text.Trim());
        }
        private bool ValidControlRegister()
        {
            if (string.IsNullOrEmpty(this.cmbCardID.Text.Trim()))
            {
                MessageBox.Show("请读取卡号！");
                return false;
            }

            if (string.IsNullOrEmpty(this.cmbAntenna.Text.Trim()))
            {
                MessageBox.Show("请选择通道号！");
                return false;
            }
            if (string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                MessageBox.Show("请输入商品名称！");
                return false;
            }
            if (string.IsNullOrEmpty(this.txtPrice.Text.Trim()))
            {
                MessageBox.Show("请输入商品价格!");
                return false;
            }
            if (string.IsNullOrEmpty(this.txtLife.Text.Trim()))
            {
                MessageBox.Show("请输入商品保质期！");
                return false;
            }


            return true;
        }
        private void MerchandiseRegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Thread_15693 != null && this.Thread_15693.IsAlive)
            {
                Thread_15693.Suspend();
                //Thread_15693.DisableComObjectEagerCleanup();
            }
            MainForm.mainform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            //实例化全局变量regs对象
            //this.regs = new MyClass.Register();

            if (ValidControlRegister())
            {
                GetControlRegister(this.regs);

                bool result = MyClass.Register.Select(cmbCardID.Text.Trim());
                if (result)
                {
                    MessageBox.Show("此卡已登记");

                }
                else
                {
                    bool Temp = this.regs.Insert();
                    if (Temp)
                    {
                        MessageBox.Show("登记成功");
                        this.regs = new MyClass.Register();
                        // this.cargo.Tab_Name = this.regs.Tab_Name;
                        //
                    }
                    else
                    {
                        MessageBox.Show("登记失败");
                    }
                }

            }
        }
        private void ReadCard()
        {
            //this.regs = new MyClass.Register();
            while (true)
            {
                try
                {
                    int tagCount = 0;
                    string[] tagNumber = null;
                    byte result = MyClass.ClassAll.Reader.Inventory(KV_ISO15693.ModulateMethod.FSK, KV_ISO15693.InventoryModel.Multiple, ref tagCount, ref tagNumber);
                    //MessageBox.Show(result.ToString());
                    Thread.Sleep(100);
                    if (result == 0x00)
                    {
                        String TagCard = tagNumber[0];
                        
                        AddCard(TagCard);

                        bool fag = MyClass.Register.Select(cmbCardID.Text.Trim());
                        if (fag)
                        {
                            this.regs = new MyClass.Register(cmbCardID.Text.Trim());

                            SetControlRegister(this.regs);
                        }

                        Thread.Sleep(100);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        delegate void AddCardDel(String TagCard);

        private void AddCard(String TagCard)
        {
            if (cmbCardID.InvokeRequired)
            {
                AddCardDel d = new AddCardDel(AddCard);
                cmbCardID.Invoke(d, TagCard);
            }
            else
            {
                if (cmbCardID.Items.IndexOf(TagCard) < 0)
                {
                    cmbCardID.Items.Add(TagCard);
                }
                cmbCardID.SelectedIndex = 0;
            }
        }

        private void MerchandiseRegistrationForm_Load(object sender, EventArgs e)
        {
            Form.CheckForIllegalCrossThreadCalls = false;

            Thread_15693 = new Thread(new ThreadStart(ReadCard));
            Thread_15693.IsBackground = true;
            Thread_15693.Start();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)8))
            {
                if ((e.KeyChar == (char)8))
                {
                    e.Handled = false;
                    return;
                }
                else
                {
                    int len = ((TextBox)sender).Text.Length;
                    if (len == 0 && e.KeyChar != '0')
                    {
                        e.Handled = false;
                        return;
                    }
                    else if (len == 0)
                    {
                        return;
                    }
                    e.Handled = false;
                }
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
