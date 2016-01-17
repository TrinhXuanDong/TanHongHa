using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace iSmartCar
{
    class MyDataGridView : DataGridView
    {
        private int _cellIndex = 0;
        private int _firstDisplayIndex = 0;
        public bool LockChangeRowsIndex = false;

        public MyDataGridView()
        {
            this.AllowUserToResizeRows = false;
        }

        protected override void OnDataBindingComplete(DataGridViewBindingCompleteEventArgs e)
        {
            base.OnDataBindingComplete(e);
            if (this.RowCount > 0 && _cellIndex < this.RowCount)
            {
                this.Rows[_cellIndex].Selected = true;
                this.FirstDisplayedScrollingRowIndex = _firstDisplayIndex;
            }

            for (int i = 0; i < this.Rows.Count; i++)
            {
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                if (i % 2 == 0)
                {
                    style.BackColor = System.Drawing.Color.FromArgb(221, 224, 225);
                }
                else
                {
                    style.BackColor = System.Drawing.Color.White;
                }
                this.Rows[i].DefaultCellStyle = style;
            }
        }

        protected override void OnCellEnter(DataGridViewCellEventArgs e)
        {
            base.OnCellEnter(e);
            if (LockChangeRowsIndex == false)
            {
                _cellIndex = e.RowIndex;
                _firstDisplayIndex = this.FirstDisplayedScrollingRowIndex;
            }
        }
    }
}
