using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace IntelligentWarehouseManagementSystem.MyClass
{
    /// <summary>
    /// 商品登记/入库/出库类
    /// </summary>
    public class Register
    {
        #region 变量

        string _TagID;
        int _Tab_Name;
        string _Name;
        int _Price;
        int _Life;
        int _Status;
        DateTime _TimeIn;
        DateTime _TimeOut;
        DateTime _Produce;

        #endregion

        #region 属性

        /// <summary>
        /// 标签号
        /// </summary>
        public string TagID
        {
            get
            {
                return _TagID;
            }
            set
            {
                _TagID = value;
            }
        }

        /// <summary>
        /// 通道号
        /// </summary>
        public int Tab_Name
        {
            get
            {
                return _Tab_Name;
            }
            set
            {
                _Tab_Name = value;
            }
        }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        /// <summary>
        /// 商品价格
        /// </summary>
        public int Price
        {
            get
            {
                return _Price;
            }
            set
            {
                _Price = value;
            }
        }

        /// <summary>
        /// 保质期
        /// </summary>
        public int Life
        {
            get
            {
                return _Life;
            }
            set
            {
                _Life = value;
            }
        }

        /// <summary>
        /// 状态 0 表示登记，1 表示入库，3表示出库
        /// </summary>
        public int Status
        {
            get
            {
                return _Status;
            }
            set
            {
                _Status = value;
            }
        }

        /// <summary>
        /// 商品入库时间
        /// </summary>
        public DateTime TimeIn
        {
            get
            {
                return _TimeIn;
            }
            set
            {
                _TimeIn = value;
            }
        }

        /// <summary>
        /// 商品出库时间
        /// </summary>
        public DateTime TimeOut
        {
            get
            {
                return _TimeOut;
            }
            set
            {
                _TimeOut = value;
            }
        }

        /// <summary>
        /// 生产日期
        /// </summary>
        public DateTime Produce
        {
            get
            {
                return _Produce;
            }
            set
            {
                _Produce = value;
            }
        }



        #endregion

        #region 构造函数

        public Register()
        {

        }

        public Register(string ID)
        {
            

            string sql = string.Format("select TagID,Tab_Name,Name,Price,Life,Produce from goodsregister where TagID='{0}'", ID);

            //DataTable dt = ClassAll.dbo.GetDataTable(sql);

            MySqlCommand cmd = new MySqlCommand(sql, ClassAll.mycon);

            MySqlDataAdapter ada = new MySqlDataAdapter(cmd);

            //DataTable dt = ClassAll.dbo.GetDataTable(sql);

            DataTable dt = new DataTable();

            ada.Fill(dt);//这里也可以把数据查询结果填充到DataSet中

            if (dt.Rows.Count > 0)
            {
                SetObject(dt.Rows[0]);
            }
            cmd.Dispose();
            
        }

        public Register(DataRow row)
        {
            InOutSetObject(row);
        }

        #endregion

        #region 私有方法

        private void SetObject(DataRow row)
        {
            _TagID = row["TagID"].ToString();
            _Tab_Name = Convert.ToInt32(row["Tab_Name"]);
            _Name = row["Name"].ToString();
            _Price = Convert.ToInt32(row["Price"]);
            _Life = Convert.ToInt32(row["Life"]);
            _Produce = Convert.ToDateTime(row["Produce"]);
        }

        private void InOutSetObject(DataRow row)
        {
            _TagID = row["TagID"].ToString();
            _Tab_Name = Convert.ToInt32(row["Tab_Name"]);
            _Name = row["Name"].ToString();
            _Price = Convert.ToInt32(row["Price"]);
            _Life = Convert.ToInt32(row["Life"]);
            _Status = Convert.ToInt32(row["Status"]);

        }

        #endregion

        #region 公有方法

        /// <summary>
        /// 插入信息
        /// </summary>
        public bool Insert()
        {
            string sql = string.Format("insert into goodsregister (TagID,Tab_Name,Name,Price,Life,Status,TimerIn,TimerOut,Produce) values ('{0}',{1},'{2}',{3},{4},{5},'{6}','{7}','{8}') ", _TagID, _Tab_Name, _Name, _Price, _Life, _Status, _TimeIn, _TimeOut, _Produce);

            

            MySqlCommand stmt = new MySqlCommand(sql, ClassAll.mycon);

            bool Temp = Convert.ToBoolean(stmt.ExecuteNonQuery());


            stmt.Dispose();
            return Temp;


        }

        /// <summary>
        /// 判断商品是否登记
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool Select(string str)
        {
            string sql = string.Format("select TagID from goodsregister where TagID='{0}'", str);

            

            MySqlCommand cmd = new MySqlCommand(sql, ClassAll.mycon);

            MySqlDataAdapter ada = new MySqlDataAdapter(cmd);


            DataTable dt = new DataTable();

            ada.Fill(dt);//这里也可以把数据查询结果填充到DataSet中

            


            if (dt.Rows.Count > 0)
            {
                cmd.Dispose();
                return true;
            }
            else
            {
                cmd.Dispose();
                return false;
            }
            


        }

        /// <summary>
        /// 查询通道号
        /// </summary>
        /// <param name="sta"></param>
        /// <returns></returns>
        public static int TabSelect(string sta)
        {
            string sql = string.Format("select Tab_Name from goodsregister where TagID='{0}'", sta);
            int result = 0;
            

            MySqlCommand stmt = new MySqlCommand(sql, ClassAll.mycon);
            MySqlDataReader datareader = stmt.ExecuteReader();
            if (datareader.Read())
            {
                result = Convert.ToInt32(datareader[0]);
            }
            //MessageBox.Show(result.ToString());

            datareader.Dispose();

            

            return result;


        }

        /// <summary>
        /// 查询状态
        /// </summary>
        /// <param name="sta"></param>
        /// <returns></returns>
        public static int StatusSelect(string sta)
        {
            string sql = string.Format("select Status from goodsregister where TagID = '{0}'", sta);
            int result=0;
           // MessageBox.Show(sql);

            MySqlCommand stmt = new MySqlCommand(sql, ClassAll.mycon);
            MySqlDataReader datareader=stmt.ExecuteReader();
            if(datareader.Read())
            {
                result = Convert.ToInt32(datareader[0]);
            }
            //MessageBox.Show(result.ToString());

            datareader.Dispose();
            return result;



        }

        /// <summary>
        /// 数据修改
        /// </summary>
        public void Update()
        {
            string sql = string.Format("update goodsregister set Status='{0}',TimerIn='{1}',TimerOut='{2}' where TagID='{3}'", _Status, _TimeIn, _TimeOut, _TagID);

            

            MySqlCommand stmt = new MySqlCommand(sql, ClassAll.mycon);

            stmt.ExecuteNonQuery();

            stmt.Dispose();
        }

        /// <summary>
        /// 定义一个有参数的数据修改方法 
        /// </summary>
        /// <param name="s">商品状态</param>
        /// <param name="i">商品入库/出库时间</param>
        public bool Update(int s, DateTime i)
        {
            string sql = string.Format("update goodsregister set Status='{0}',TimerIn='{1}' where TagID='{2}'", s, i, _TagID);

            

            MySqlCommand stmt = new MySqlCommand(sql, ClassAll.mycon);

            bool Temp = Convert.ToBoolean(stmt.ExecuteNonQuery());


            stmt.Dispose();
            return Temp;


        }

        #endregion

        #region 静态方法

        /// <summary>
        /// 泛型方法
        /// </summary>
        /// <returns></returns>
        public static List<Register> GetObjectList()
        {
            List<Register> listRegister = new List<Register>();

            string sql = string.Format("select * from goodsregister");

            

            MySqlCommand cmd = new MySqlCommand(sql, ClassAll.mycon);

            MySqlDataAdapter ada = new MySqlDataAdapter(cmd);

            //DataTable dt = ClassAll.dbo.GetDataTable(sql);

            DataTable dt = new DataTable();

            ada.Fill(dt);//这里也可以把数据查询结果填充到DataSet中

            foreach (DataRow row in dt.Rows)
            {
                Register r = new Register(row);
                listRegister.Add(r);
            }


            cmd.Dispose();

            return listRegister;


        }

        /// <summary>
        /// 泛型方法
        /// </summary>
        /// <returns></returns>
        public static List<Register> GetObjectList(Cargo cargo)
        {
            List<Register> listRegister = new List<Register>();


            string sql = string.Format("select TagID,Tab_Name,Name,Price,Life,Status from goodsregister where Tab_Name = '{0}'", cargo.Tab_Name);

            

            //DataTable dt = ClassAll.dbo.GetDataTable(sql);
            MySqlCommand cmd = new MySqlCommand(sql, ClassAll.mycon);

            MySqlDataAdapter ada = new MySqlDataAdapter(cmd);

            //DataTable dt = ClassAll.dbo.GetDataTable(sql);

            DataTable dt = new DataTable();

            ada.Fill(dt);//这里也可以把数据查询结果填充到DataSet中

            foreach (DataRow row in dt.Rows)
            {
                Register r = new Register(row);
                listRegister.Add(r);
            }
            cmd.Dispose();
            return listRegister;
        }

        #endregion
    }
}
