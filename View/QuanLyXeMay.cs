using hoangpdph31561_CSharp_3_BaiTap_1.DomainClass;
using hoangpdph31561_CSharp_3_BaiTap_1.Respository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hoangpdph31561_CSharp_3_BaiTap_1.View
{
    public partial class QuanLyXeMay : Form
    {
        XeMayRespository _res = new XeMayRespository();
        Guid _idWhenClick;
        public QuanLyXeMay()
        {
            InitializeComponent();
            LoadComboBox();
            LoadGrid();
        }
        public void LoadComboBox()
        {
            for (int i = 1; i <= 100; i++)
            {
                cmbSoLuong.Items.Add(i.ToString());
            }
            cmbSoLuong.SelectedIndex = 4;
        }
        public void LoadGrid()
        {
            int stt = 1;
            Type type = typeof(XeMay);
            dgvXeMay.ColumnCount = type.GetProperties().Length - 1;
            dgvXeMay.Columns[0].Name = "STT";
            dgvXeMay.Columns[1].Name = "Tên xe";
            dgvXeMay.Columns[2].Name = "Mô tả";
            dgvXeMay.Columns[3].Name = "Số lượng";
            dgvXeMay.Columns[4].Name = "Giá nhập";
            dgvXeMay.Columns[5].Name = "Loại xe";
            dgvXeMay.Rows.Clear();
            List<XeMay> lstXeMays = _res.GetXeMays();
            for (int i = 0; i < lstXeMays.Count; i++)
            {
                dgvXeMay.Rows.Add(stt++, lstXeMays[i].TenXeMay, lstXeMays[i].MoTa, lstXeMays[i].SoLuong, lstXeMays[i].GiaNhap, (lstXeMays[i].IdLoaiXe == null ? "Xe nhái" : _res.GetLoaiXes().Where(x => x.IdLoaiXe == lstXeMays[i].IdLoaiXe).Select(x => x.TenLoaiXe).First()));
                dgvXeMay.Rows[i].Tag = lstXeMays[i].IdXeMay;
            }


        }
        public void LoadGrid(string input)
        {
            int stt = 1;
            Type type = typeof(XeMay);
            dgvXeMay.ColumnCount = type.GetProperties().Length - 1;
            dgvXeMay.Columns[0].Name = "STT";
            dgvXeMay.Columns[1].Name = "Tên xe";
            dgvXeMay.Columns[2].Name = "Mô tả";
            dgvXeMay.Columns[3].Name = "Số lượng";
            dgvXeMay.Columns[4].Name = "Giá nhập";
            dgvXeMay.Columns[5].Name = "Loại xe";
            dgvXeMay.Rows.Clear();
            List<XeMay> lstXeMays = _res.GetXeMays().Where(x => x.TenXeMay.ToLower().StartsWith(input.Trim().ToLower())).ToList();
            for (int i = 0; i < lstXeMays.Count; i++)
            {
                dgvXeMay.Rows.Add(stt++, lstXeMays[i].TenXeMay, lstXeMays[i].MoTa, lstXeMays[i].SoLuong, lstXeMays[i].GiaNhap, (lstXeMays[i].IdLoaiXe == null ? "Xe nhái" : _res.GetLoaiXes().Where(x => x.IdLoaiXe == lstXeMays[i].IdLoaiXe).Select(x => x.TenLoaiXe).First()));
                dgvXeMay.Rows[i].Tag = lstXeMays[i].IdXeMay;
            }


        }
        public Guid? CheckLoaiXe(string input)
        {
            var data = _res.GetLoaiXes().FirstOrDefault(x => input.ToLower().Contains(x.TenLoaiXe.ToLower()));
            if (data == null)
            {
                return null;
            }
            return data.IdLoaiXe;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckError())
            {
                XeMay newMoTo = new XeMay();
                newMoTo.TenXeMay = txtTenXe.Text;
                newMoTo.MoTa = txtMoTa.Text;
                newMoTo.GiaNhap = Convert.ToInt32(txtGiaNhap.Text);
                newMoTo.SoLuong = Convert.ToInt32(cmbSoLuong.SelectedItem);
                newMoTo.IdLoaiXe = CheckLoaiXe(txtTenXe.Text);
                MessageBox.Show(_res.AddXeMay(newMoTo));
            }
            LoadGrid();
            ResetTextBox();
        }

        private void dgvXeMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index == _res.GetXeMays().Count)
            {
                return;
            }
            DataGridViewRow row = dgvXeMay.Rows[index];
            if (row.Tag != null)
            {
                _idWhenClick = (Guid)row.Tag;
                var data = _res.GetXeMays().First(x => x.IdXeMay == _idWhenClick);
                txtTenXe.Text = data.TenXeMay;
                txtMoTa.Text = data.MoTa;
                txtGiaNhap.Text = data.GiaNhap.ToString();
                cmbSoLuong.SelectedItem = data.SoLuong;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult reg = MessageBox.Show("Bạn chắc muốn xóa đối tượng được chọn chứ", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reg == DialogResult.Yes)
            {
                MessageBox.Show(_res.DeleteXeMay(_idWhenClick));
                LoadGrid();
            }
            ResetTextBox();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetTextBox();
        }
        public void ResetTextBox()
        {
            txtTenXe.Text = "";
            txtMoTa.Text = "";
            txtGiaNhap.Text = "";
            cmbSoLuong.SelectedIndex = 4;
        }
        public bool CheckError()
        {
            err.SetError(txtTenXe, "");
            err.SetError(txtMoTa, "");
            err.SetError(txtGiaNhap, "");
            if (txtTenXe.Text.Trim().Length == 0)
            {
                err.SetError(txtTenXe, "Chưa nhập tên xe");
                return false;
            }
            if (txtMoTa.Text.Trim().Length == 0)
            {
                err.SetError(txtMoTa, "Chưa nhập mô tả");
                return false;
            }
            if (txtGiaNhap.Text.Trim().Length == 0)
            {
                err.SetError(txtGiaNhap, "Chưa nhập giá xe");
                return false;
            }
            else if (!Regex.IsMatch(txtGiaNhap.Text, @"^[\d]+$"))
            {
                err.SetError(txtGiaNhap, "Phải là số");
                return false;
            }
            return true;
        }
        /// <summary>
        /// textBox 4 = txtTimKiem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox4_MouseEnter(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void txtTimKiem_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim().Length == 0)
            {
                LoadGrid();
            }
            else LoadGrid(txtTimKiem.Text);
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            txtTimKiem.Text = "Nhập tên cần tìm ở đây";
            LoadGrid();
        }
    }
}
