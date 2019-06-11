using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WSN_New_DLL
{
    public class Converts
    {
        /// <summary>
        /// 字节数据转字符串
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string BytesToString(byte[] bytes)
        {
            string result = "";
            foreach (byte b in bytes)
            {
                result = result + string.Format("{0:X2}", b);
            }
            return result;
        }

        /// <summary>
        /// 字节数据转字符串(带格式)
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string BytesToStringFormat(byte[] bytes)
        {
            string result = "";
            foreach (byte b in bytes)
            {
                result = result + string.Format("{0:X2}", b) + "-";
            }
            return result.Substring(0, result.Length - 1);
        }

        /// <summary>
        /// 2位字符串转字节
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static byte StringToByte(string str)
        {
            try
            {
                str = System.Convert.ToInt32(str, 16).ToString();
            }
            catch (Exception err)
            {
                throw err;
            }

            byte result = 0;
            if (byte.TryParse(str, out result) == true)
            {
                return result;
            }
            else
            {
                throw new Exception("StringToByte error");
            }
        }

        /// <summary>
        /// 字符串转字节数据
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static byte[] StringToBytes(string str)
        {
            byte[] result = new byte[str.Length / 2];
            for (int i = 0; i < str.Length; i = i + 2)
            {
                result[i / 2] = StringToByte(str.Substring(i, 2));
            }
            return result;
        }
    }
}
