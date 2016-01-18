using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace iSmartCar
{
    public partial class frmBaoDuongXe : Form
    {
        #region Contructor
        public frmBaoDuongXe()
        {
            InitializeComponent();

            HandleCreated += OnHandleCreated;
        }
        #endregion

        #region Event
        private void OnHandleCreated(object sender, EventArgs e)
        {
            CreateTreeView();
        }

        private void OnTreeViewAfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 1)
            {
                MessageBox.Show(e.Node.Text);
            }
        }

        private void OnBtnBoLocBienSoXeMouseClick(object sender, EventArgs e)
        {
            CreateTreeView();
        }

        private void OnBtnLocBienSoXeMouseClick(object sender, EventArgs e)
        {
            if (_txtLocBienSoXe.Text != "")
            {
                string bienSoXe = _txtLocBienSoXe.Text;
                CreateTreeView(bienSoXe);
            }
        }

        #endregion

        #region Method
        /// <summary>
        /// Hàm tạo danh sách xe theo dạng cây
        /// </summary>
        /// <param name="bienSoXe"></param>
        private void CreateTreeView(string bienSoXe = "")
        {
            _treeView.Nodes.Clear();

            //Lấy ra danh sách xe
            string sql = "select * from Xe";
            if (bienSoXe != "")
            {
                sql += " where BienSo like N'%" + bienSoXe + "%'";
            }
            DataTable dtb = GuiResInfoMng.Instance.GetDataTable(sql);

            //Lấy ra các loại xe khác nhau
            List<string> dSachLoaiXe = new List<string>();
            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                string loaiXe = dtb.Rows[i][1].ToString();
                if (dSachLoaiXe.Contains(loaiXe) == false)
                {
                    dSachLoaiXe.Add(loaiXe);
                }
            }
            //Thêm loại xe vào treeview với vai trò là root
            for (int i = 0; i < dSachLoaiXe.Count; i++)
            {
                //Lấy ra danh sách biển số xe thuộc cùng 1 loại xe
                sql = string.Format("select BienSo from Xe where LoaiXe = N'{0}'", dSachLoaiXe[i]);

                if (bienSoXe != "")
                {
                    sql += " and  BienSo like N'%" + bienSoXe + "%'";
                }

                dtb = GuiResInfoMng.Instance.GetDataTable(sql);

                List<TreeNode> childrenNode = new List<TreeNode>();
                for (int j = 0; j < dtb.Rows.Count; j++)
                {
                    TreeNode tmp = new TreeNode(dtb.Rows[j][0].ToString());
                    childrenNode.Add(tmp);
                }

                TreeNode root = new TreeNode(dSachLoaiXe[i] + " [" + dtb.Rows.Count + "]", childrenNode.ToArray());

                _treeView.Nodes.Add(root);
            }
            _treeView.ExpandAll();
        }
        #endregion
    }
}