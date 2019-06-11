using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace IntelligentWarehouseManagementSystem
{
    public partial class MerchandiseWarehousingForm : Form
    {
        private Thread Thread_15693;

        private MyClass.Register regs;
        private MyClass.Cargo cargo;
        public MerchandiseWarehousingForm()
        {
            InitializeComponent();
            SetListView();
        }

        private void SetListView()
        {
            this.lsvGoodsInOut.Items.Clear();

            List<MyClass.Register> listRegister = MyClass.Register.GetObjectList();

            foreach (MyClass.Register r in listRegister)
            {
                ListViewItem item = new ListViewItem();

                item.Text = r.TagID;
                item.Tag = r;
                item.SubItems.Add(r.Tab_Name.ToString());
                item.SubItems.Add(r.Name);

                item.SubItems.Add(r.Price.ToString());
                item.SubItems.Add(r.Life.ToString());
                item.SubItems.Add(r.Status.ToString());

                this.lsvGoodsInOut.Items.Add(item);
            }
        }
        private void ReadCard()
        {
            while (true)
            {
                try
                {
                    int tagCount = 0;
                    string[] tagNumber = null;
                    byte result = MyClass.ClassAll.Reader.Inventory(KV_ISO15693.ModulateMethod.FSK, KV_ISO15693.InventoryModel.Multiple, ref tagCount, ref tagNumber);

                    Thread.Sleep(100);
                    if (result == 0x00)
                    {
                        //txtCardID.Text = tagNumber[0];
                        String TagCard = tagNumber[0];
                        AddCard(TagCard);

                        bool Temp = MyClass.Register.Select(cmbCardID.Text.Trim());
                        if (!Temp)
                        {
                            MessageBox.Show("此卡未登记,请先登记");
                            Close();
                        }
                    }
                    else
                    {
                        //MessageBox.Show("寻卡失败，请将卡片放入你对应通道号的仓位中");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyClass.ClassAll.Antenna("1", false);

            if (this.Thread_15693 != null && this.Thread_15693.IsAlive)
            {
                Thread_15693.Suspend();
                //Thread_15693.DisableComObjectEagerCleanup();
            }
            //Thread_15693.Abort();
            
            MainForm.mainform.Show();
            this.Hide();
        }

        private void MerchandiseWarehousingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyClass.ClassAll.Antenna("1", false);

            if (this.Thread_15693 != null && this.Thread_15693.IsAlive)
            {
                Thread_15693.Suspend();
                //Thread_15693.DisableComObjectEagerCleanup();
            }
            //Thread_15693.Abort();
            
            MainForm.mainform.Show();
            this.Hide();
        }

        private void MerchandiseWarehousingForm_Load(object sender, EventArgs e)
        {
            Form.CheckForIllegalCrossThreadCalls = false;

            Thread_15693 = new Thread(new ThreadStart(ReadCard));
            Thread_15693.IsBackground = true;
            Thread_15693.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //实例化Register类与Cargo类
            regs = new MyClass.Register();
            cargo = new MyClass.Cargo();

            regs.TagID = cmbCardID.Text.Trim();

            //获取登记商品的通道号
            int value = MyClass.Register.TabSelect(cmbCardID.Text.Trim());
            txtSeat.Text = value.ToString();
            cargo.Tab_Name = Convert.ToInt32(txtSeat.Text.Trim());

            int result = MyClass.Register.StatusSelect(cmbCardID.Text.Trim());
            //MessageBox.Show(result.ToString());
            if (result == 0)
            {
                int num = cargo.GetGoodsCount();
                //传递一个状态值为 1，入库时间为当前时间，出库时间为空。
                bool Temp = regs.Update(1, DateTime.Now);

                if (Temp)
                {
                    num++;
                    cargo.Update(num);
                    MessageBox.Show("入库成功");
                    //设置通道号和设置LED屏状态显示
                    MyClass.ClassAll.Antenna(txtSeat.Text.Trim(), false);

                }
                else
                {
                    MessageBox.Show("入库失败");
                }
            }
            else if (result == 1)
            {
                MessageBox.Show("该商品已经入库");
            }
            else
            {
                MessageBox.Show("该商品已经出库了，无法再入库");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            MainForm.mainform.Show();
            this.Hide();
        }
    }
}
