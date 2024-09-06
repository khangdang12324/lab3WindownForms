using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab3_2212387.frmSinhVien;

namespace Lab3_2212387
{
    public partial class frmSinhVien : Form
    {
        QuanLySinhVien qlsv;
        public frmSinhVien()
        {
            InitializeComponent();
        }
        #region Phương thức bổ trợ
        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            List<string> cn = new List<string>();
            sv.MaSo = this.mtxtMaSo.Text;
            sv.HoTen = this.txtHoTen.Text;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.DiaChi = this.txtDiaChi.Text;
            sv.Lop = this.cboLop.Text;
            sv.Hinh = this.txtHinh.Text;
            if (rdNu.Checked)
                gt = false;
            sv.GioiTinh = gt;
            for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
                if (clbChuyenNganh.GetItemChecked(i))
                    cn.Add(clbChuyenNganh.Items[i].ToString());
            sv.ChuyenNganh = cn;
            return sv;
        }
        //Lấy thông tin sinh viên từ dòng item của ListView
        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MaSo = lvitem.SubItems[0].Text;
            sv.HoTen = lvitem.SubItems[1].Text;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[2].Text);
            sv.DiaChi = lvitem.SubItems[3].Text;
            sv.Lop = lvitem.SubItems[4].Text;
            sv.GioiTinh = false;
            if (lvitem.SubItems[5].Text == "Nam")
                sv.GioiTinh = true; List<string> cn = new List<string>();
            string[] s = lvitem.SubItems[6].Text.Split(',');
            foreach (string t in s)
                cn.Add(t);
            sv.ChuyenNganh = cn;
            sv.Hinh = lvitem.SubItems[7].Text;
            return sv;
        }
        //Thiết lập các thông tin lên controls sinh viên
        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtxtMaSo.Text = sv.MaSo;
            this.txtHoTen.Text = sv.HoTen;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.txtDiaChi.Text = sv.DiaChi;
            this.cboLop.Text = sv.Lop;
            this.txtHinh.Text = sv.Hinh;
            this.pbHinh.ImageLocation = sv.Hinh;
            if (sv.GioiTinh)
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;
            for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
                this.clbChuyenNganh.SetItemChecked(i, false);
            foreach (string s in sv.ChuyenNganh)
            {
                for (int i = 0; i < this.clbChuyenNganh.Items.Count;
                i++)
                    if
                    (s.CompareTo(this.clbChuyenNganh.Items[i]) == 0)
                        this.clbChuyenNganh.SetItemChecked(i,
                        true);
            }
        }
        //Thêm sinh viên vào ListView
        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MaSo);
            lvitem.SubItems.Add(sv.HoTen);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.DiaChi);
            lvitem.SubItems.Add(sv.Lop);
            string gt = "Nữ";
            if (sv.GioiTinh)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            string cn = "";
            foreach (string s in sv.ChuyenNganh)
                cn += s + ",";
            cn = cn.Substring(0, cn.Length - 1);
            lvitem.SubItems.Add(cn);
            lvitem.SubItems.Add(sv.Hinh);
            this.lvSinhVien.Items.Add(lvitem);
        }
        //Hiển thị các sinh viên trong qlsv lên ListView
        private void LoadListView()
        {
            this.lvSinhVien.Items.Clear();
            foreach (SinhVien sv in qlsv.DanhSach)
            {
                ThemSV(sv);
            }
        }
        #endregion
        #region Các sự kiện

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile();
            LoadListView();
        }
        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvSinhVien.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem =
                this.lvSinhVien.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThietLapThongTin(sv);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            SinhVien kq = qlsv.Tim(sv.MaSo,
            delegate (object obj1, object obj2)
            {
                return (obj2 as
    SinhVien).MaSo.CompareTo(obj1.ToString());
            });
            if (kq != null)
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm dữ liệu",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.qlsv.Them(sv);
                this.LoadListView();
            }
            UpdateStatusStrip();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem lvitem;
            count = this.lvSinhVien.Items.Count - 1;
            for (i = count; i >= 0; i--)
            {
                lvitem = this.lvSinhVien.Items[i];
                if (lvitem.Checked)
                    qlsv.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
            }
            this.LoadListView();
            this.btnMacDinh.PerformClick();
            UpdateStatusStrip();
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.mtxtMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgaySinh.Value = DateTime.Now;
            this.txtDiaChi.Text = "";
            this.cboLop.Text = this.cboLop.Items[0].ToString();
            this.txtHinh.Text = "";
            this.pbHinh.ImageLocation = "";
            this.rdNam.Checked = true;
            for (int i = 0; i < this.clbChuyenNganh.Items.Count - 1;
            i++)
                this.clbChuyenNganh.SetItemChecked(i, false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            bool kqsua;
            kqsua = qlsv.Sua(sv, sv.MaSo, SoSanhTheoMa);
            if (kqsua)
            {
                this.LoadListView();
            }
        }
        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.MaSo.CompareTo(obj1);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string filePath = openFileDialog1.FileName;
            txtHinh.Text = filePath;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            UpdateStatusStrip();
        }
        private void UpdateStatusStrip()
        {
            toolStripStatusLabel1.Text = $"Tổng số sinh viên: {qlsv.DanhSach.Count}";
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            toolStripStatusLabel1.Text = $"Tổng số sinh viên: {qlsv.DanhSach.Count}";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mởFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void thêmCtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnThem_Click(sender, e);
        }
    }
    #endregion
    public class SinhVien
        {
            //Các thuộc tính của lớp sinh viên
            public string MaSo { get; set; }
            public string HoTen { get; set; }
            public DateTime NgaySinh { get; set; }
            public string DiaChi { get; set; }
            public string Lop { get; set; }
            public string Hinh { get; set; }
            public bool GioiTinh { get; set; }
            public List<string> ChuyenNganh { get; set; }
            public SinhVien()
            {
                ChuyenNganh = new List<string>();
            }
            public SinhVien(string ms, string ht, DateTime ngay,
string dc, string lop, string hinh, bool gt,
List<string> cn)
            {
                this.MaSo = ms;
                this.HoTen = ht;
                this.NgaySinh = ngay;
                this.DiaChi = dc;
                this.Lop = lop;
                this.Hinh = hinh;
                this.GioiTinh = gt;
                this.ChuyenNganh = cn;
            }
        }
        public delegate int SoSanh(object sv1, object sv2);
        class QuanLySinhVien
        {
            public List<SinhVien> DanhSach;
            public QuanLySinhVien()
            {
                DanhSach = new List<SinhVien>();
            }
            // Thêm một sinh viên vào danh sách
            public void Them(SinhVien sv)
            {
                this.DanhSach.Add(sv);
            }
            public SinhVien this[int index]
            {
                get { return DanhSach[index]; }
                set { DanhSach[index] = value; }
            }
            //Xóa các obj trong danh sách nếu thỏa điều kiện so sánh
            public void Xoa(object obj, SoSanh ss)
            {
                int i = DanhSach.Count - 1;
                for (; i >= 0; i--)
                    if (ss(obj, this[i]) == 0)
                        this.DanhSach.RemoveAt(i);
            }
            //Tìm một sinh viên trong danh sách thỏa điều kiện so sánh
            public SinhVien Tim(object obj, SoSanh ss)
            {
                SinhVien svresult = null;
                foreach (SinhVien sv in DanhSach)
                    if (ss(obj, sv) == 0)
                    {
                        svresult = sv;
                        break;
                    }
                return svresult;
            }

            public bool Sua(SinhVien svsua, object obj, SoSanh ss)
            {
                int i, count;
                bool kq = false;
                count = this.DanhSach.Count - 1;
                for (i = 0; i < count; i++)
                    if (ss(obj, this[i]) == 0)
                    {
                        this[i] = svsua;
                        kq = true;
                        break;
                    }
                return kq;
            }

            // Hàm đọc danh sách sinh viên từ tập tin txt
            public void DocTuFile()
            {
                string filename = "DanhSachSV.txt", t;
                string[] s;
                SinhVien sv;
                StreamReader sr = new StreamReader(
                new FileStream(filename,
               FileMode.Open));
                while ((t = sr.ReadLine()) != null)
                {
                    s = t.Split('*');
                    sv = new SinhVien();
                    sv.MaSo = s[0];
                    sv.HoTen = s[1];
                    sv.NgaySinh = DateTime.Parse(s[2]);
                    sv.DiaChi = s[3];
                    sv.Lop = s[4];
                    sv.Hinh = s[5];
                    sv.GioiTinh = false;
                    if (s[6] == "1")
                        sv.GioiTinh = true;
                    string[] cn = s[7].Split('\t');
                    foreach (string c in cn) sv.ChuyenNganh.Add(c);
                    this.Them(sv);
                }
            }
        }


    }



