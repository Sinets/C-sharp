using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IntelligentWarehouseManagementSystem.MyClass
{
    /// <summary>
    /// 货仓设置类
    /// </summary>
    public class Cargo
    {
        #region 变量

        int _Name;
        int _Reality;
        int _Max;
        int _Min;

        #endregion

        #region 属性



        /// <summary>
        /// 通道号
        /// </summary>
        public int Tab_Name
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
        /// 实际商品数
        /// </summary>
        public int Reality
        {
            get
            {
                return _Reality;
            }
            set
            {
                _Reality = value;
            }
        }
        /// <summary>
        /// 最大商品数
        /// </summary>
        public int Max
        {
            get
            {
                return _Max;
            }
            set
            {
                _Max = value;
            }
        }

        /// <summary>
        /// 最小商品数
        /// </summary>
        public int Min
        {
            get
            {
                return _Min;
            }
            set
            {
                _Min = value;
            }
        }

        #endregion

        #region 构造函数

        public Cargo()
        { }

        public Cargo(int Name)
        {
            string sql = string.Format("select * from cargo where name='{0}'", Name);

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
        }

        #endregion

        #region 私有方法

        private void SetObject(DataRow row)
        {

            _Name = Convert.ToInt32(row["Name"]);
            _Reality = Convert.ToInt32(row["Reality"]);
            _Max = Convert.ToInt32(row["Max"]);
            _Min = Convert.ToInt32(row["Min"]);

        }

        #endregion

        #region 公有方法

        /// <summary>
        /// 插入信息
        /// </summary>
        public bool Insert()
        {
            string sql = string.Format("insert into Cargo (Name,Reality,Max,Min) values ({0},{1},{2},{3})", _Name, 0, _Max, _Min);
            
            MySqlCommand stmt = new MySqlCommand(sql, ClassAll.mycon);

            bool Temp = Convert.ToBoolean(stmt.ExecuteNonQuery());

            return Temp;
            
        }

        public bool Select()
        {
            string sql = string.Format("select * from Cargo where Name='{0}'", _Name);
            //DataTable dtb = ClassAll.dbo.GetDataTable(sql);

            MySqlCommand cmd = new MySqlCommand(sql, ClassAll.mycon);

            MySqlDataAdapter ada = new MySqlDataAdapter(cmd);

            //DataTable dt = ClassAll.dbo.GetDataTable(sql);

            DataTable dtb = new DataTable();

            ada.Fill(dtb);//这里也可以把数据查询结果填充到DataSet中

            if (dtb.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 更新仓位商品数
        /// </summary>
        /// <param name="num"></param>
        public void Update(int num)
        {
            string sql = string.Format("update Cargo set Reality='{0}' where Name='{1}'", num, _Name);

            MySqlCommand stmt = new MySqlCommand(sql, ClassAll.mycon);

            stmt.ExecuteNonQuery();

        }

        /// <summary>
        /// 货仓修改
        /// </summary>
        public bool Update()
        {
            string sql = string.Format("update Cargo set Max='{0}',Min='{1}' where Name='{2}' ", _Max, _Min, _Name);

            MySqlCommand stmt = new MySqlCommand(sql, ClassAll.mycon);

            bool Temp = Convert.ToBoolean(stmt.ExecuteNonQuery());

            return Temp;
        }

        /// <summary>
        /// 查询实际商品数
        /// </summary>
        /// <returns></returns>
        public int GetGoodsCount()
        {
            string sql = string.Format("select Reality from Cargo where Name='{0}'", _Name);

            MySqlCommand stmt = new MySqlCommand(sql, ClassAll.mycon);

            int num = stmt.ExecuteNonQuery();


            return num;
        }

        #endregion

        #region 静态方法

        /// <summary>
        /// 获取所有货仓对象列表
        /// </summary>
        /// <returns></returns>
        public static List<Cargo> GetObjectList()
        {
            List<Cargo> list = new List<Cargo>();

            string sql = string.Format("select name from cargo");

            MySqlCommand cmd = new MySqlCommand(sql, ClassAll.mycon);

            MySqlDataAdapter ada = new MySqlDataAdapter(cmd);


            DataTable dt = new DataTable();

            ada.Fill(dt);//这里也可以把数据查询结果填充到DataSet中

            //DataTable dt = ClassAll.dbo.GetDataTable(sql);


            foreach (DataRow row in dt.Rows)
            {
                int Tab_Name = Convert.ToInt32(row["name"]);
                Cargo cargo = new Cargo(Tab_Name);
                list.Add(cargo);
            }

            return list;
        }


        #endregion
    }
}
