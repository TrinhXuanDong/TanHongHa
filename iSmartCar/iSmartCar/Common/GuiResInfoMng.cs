using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DongTX.Core;

namespace iSmartCar
{
    class GuiResInfoMng
    {
        #region Field
        private static GuiResInfoMng _instance = new GuiResInfoMng();
        #endregion

        #region Property
        public static GuiResInfoMng Instance
        {
            get
            {
                return _instance;
            }
        }
        #endregion

        #region Contructor
        private GuiResInfoMng()
        {

        }
        #endregion

        #region Các hàm xử lý chuỗi
        /// <summary>
        /// Hàm loại bỏ các ký tự đặc biệt của chuỗi
        /// </summary>
        /// <param name="str"></param>
        public void RemoveSpecialStr(ref string str)
        {
            while (str.Length > 0)
            {
                if (str.Contains("\""))
                {
                    int index = str.IndexOf("\"", System.StringComparison.Ordinal);
                    str = str.Remove(index, 1);
                }
                else if (str.Contains("'"))
                {
                    int index = str.IndexOf("'", System.StringComparison.Ordinal);
                    str = str.Remove(index, 1);
                }
                else
                {
                    break;
                }
            }
            str = str.Trim();
        }
        #endregion

        #region Các hàm liên quan đến CSDL
        /// <summary>
        /// Hàm set chuỗi kết nối đến CSDL
        /// </summary>
        /// <param name="connectionStr"></param>
        public void SetConnection(string connectionStr)
        {
            SqlHelper.Instance.ConnectionString = connectionStr;
        }

        /// <summary>
        /// Hàm thực hiện lấy về 1 bảng CSDL
        /// </summary>
        public DataTable GetDataTable(string sql)
        {
            return SqlHelper.Instance.ExecuteDataTable(sql);
        }

        /// <summary>
        /// Hàm insert vào CSDL
        /// </summary>
        /// <param name="tableName">Tên bảng</param>
        /// <param name="valuesParameter">Các giá trị muốn insert</param>
        /// <returns>trả về số bản ghi được insert</returns>
        public int Insert(string tableName, SqlParameter[] valuesParameter)
        {
            return (int)SqlHelper.Instance.Insert(tableName, valuesParameter);
        }

        /// <summary>
        /// Hàm cập nhật CSDL
        /// </summary>
        /// <param name="tableName">Tên bảng</param>
        /// <param name="valuesParameter">Danh sách dữ liệu cần cập nhật</param>
        /// <param name="whereParameter">Điều kiện cập nhật</param>
        /// <returns>Trả về số bản ghi được cập nhật</returns>
        public int Update(string tableName, SqlParameter[] valuesParameter, SqlParameter[] whereParameter)
        {
            return (int)SqlHelper.Instance.Update(tableName, valuesParameter, whereParameter);
        }

        /// <summary>
        /// Hàm xóa dữ liệu SQL
        /// </summary>
        /// <param name="tableName">Tên bảng</param>
        /// <param name="whereParameter">Danh sách điều kiện</param>
        /// <returns>Trả về số bản ghi bị xóa</returns>
        public int Delete(string tableName, SqlParameter[] whereParameter)
        {
            return (int)SqlHelper.Instance.Delete(tableName, whereParameter);
        }

        /// <summary>
        /// Hàm lấy dữ liệu bản ghi SQL
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int ExcuteScalarInt(string sql)
        {
            return (int)SqlHelper.Instance.ExecuteScalar(sql);
        }

        /// <summary>
        /// Hàm lấy dữ liệu bản ghi SQL
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public string ExcuteScalarStr(string sql)
        {
            return (string)SqlHelper.Instance.ExecuteScalar(sql);
        }

        /// <summary>
        /// Hàm lấy dữ liệu bản ghi SQL
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="whereParameter"></param>
        /// <returns></returns>
        public int ExcuteScalarInt(string sql, SqlParameter[] whereParameter)
        {
            return (int)SqlHelper.Instance.ExecuteScalar(sql, whereParameter);
        }

        /// <summary>
        /// Hàm lấy dữ liệu bản ghi SQL
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="whereParameter"></param>
        /// <returns></returns>
        public string ExcuteScalarStr(string sql, SqlParameter[] whereParameter)
        {
            return (string)SqlHelper.Instance.ExecuteScalar(sql, whereParameter);
        }
        #endregion
    }
}
