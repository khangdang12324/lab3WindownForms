using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lab4_WF_2212387
{
    public class SinhVien 
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Lop { get; set; }
        public string Hinh { get; set; }
        public bool GioiTinh { get; set; }
        public ArrayList ChuyenNganh { get; set; }
        //Phuong thuc tao lap mac dinh
        public SinhVien()
        {
            ChuyenNganh = new ArrayList();
        }
        //phuong thuc tao lap co tham so
        public SinhVien(string ms, string ht, DateTime ngay, string dc, string lop, string hinh, bool gt, ArrayList cn)
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

        public class DanhSachSinhVien
        {
            private ArrayList DSSV;
            
            public DanhSachSinhVien()
            {
                DSSV = new ArrayList();
            }
            
        }
    }
}
