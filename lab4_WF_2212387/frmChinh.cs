using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
namespace lab4_WF_2212387
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
        }
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox mtbMSSV;
        private TextBox txtHoVaTen;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtHinh;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        private RadioButton rdNu;
        private RadioButton rdNam;
        private MaskedTextBox mtbSDT;
        private ComboBox cbLop;
        private Button btnChonHinh;
        private Button btnThoat;
        private Button btnLuu;
        private Button btnMacDinh;
        private GroupBox grbDSSV;
        private ListView lvSinhVien;
        private ColumnHeader MSSV;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private GroupBox grbThongTin;

        private void InitializeComponent()
        {
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnMacDinh = new System.Windows.Forms.Button();
            this.btnChonHinh = new System.Windows.Forms.Button();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.mtbSDT = new System.Windows.Forms.MaskedTextBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtHinh = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.mtbMSSV = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbDSSV = new System.Windows.Forms.GroupBox();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.MSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbThongTin.SuspendLayout();
            this.grbDSSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.btnThoat);
            this.grbThongTin.Controls.Add(this.btnLuu);
            this.grbThongTin.Controls.Add(this.btnMacDinh);
            this.grbThongTin.Controls.Add(this.btnChonHinh);
            this.grbThongTin.Controls.Add(this.cbLop);
            this.grbThongTin.Controls.Add(this.mtbSDT);
            this.grbThongTin.Controls.Add(this.rdNu);
            this.grbThongTin.Controls.Add(this.rdNam);
            this.grbThongTin.Controls.Add(this.dtpNgaySinh);
            this.grbThongTin.Controls.Add(this.txtHinh);
            this.grbThongTin.Controls.Add(this.txtDiaChi);
            this.grbThongTin.Controls.Add(this.txtEmail);
            this.grbThongTin.Controls.Add(this.txtHoVaTen);
            this.grbThongTin.Controls.Add(this.mtbMSSV);
            this.grbThongTin.Controls.Add(this.label6);
            this.grbThongTin.Controls.Add(this.label9);
            this.grbThongTin.Controls.Add(this.label8);
            this.grbThongTin.Controls.Add(this.label7);
            this.grbThongTin.Controls.Add(this.label5);
            this.grbThongTin.Controls.Add(this.label4);
            this.grbThongTin.Controls.Add(this.label3);
            this.grbThongTin.Controls.Add(this.label2);
            this.grbThongTin.Controls.Add(this.label1);
            this.grbThongTin.Location = new System.Drawing.Point(188, 12);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(725, 212);
            this.grbThongTin.TabIndex = 2;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin sinh viên";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(618, 183);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(93, 23);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(510, 183);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 23);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.Location = new System.Drawing.Point(400, 183);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(93, 23);
            this.btnMacDinh.TabIndex = 10;
            this.btnMacDinh.Text = "Mặc định";
            this.btnMacDinh.UseVisualStyleBackColor = true;
            this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.Location = new System.Drawing.Point(636, 155);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Size = new System.Drawing.Size(75, 23);
            this.btnChonHinh.TabIndex = 9;
            this.btnChonHinh.Text = "Chọn hình";
            this.btnChonHinh.UseVisualStyleBackColor = true;
            this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click);
            // 
            // cbLop
            // 
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.Items.AddRange(new object[] {
            "CTK46B",
            "CTK46A"});
            this.cbLop.Location = new System.Drawing.Point(473, 92);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(220, 21);
            this.cbLop.TabIndex = 7;
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.cbLop_SelectedIndexChanged);
            // 
            // mtbSDT
            // 
            this.mtbSDT.Location = new System.Drawing.Point(473, 128);
            this.mtbSDT.Mask = "(999) 000-0000";
            this.mtbSDT.Name = "mtbSDT";
            this.mtbSDT.Size = new System.Drawing.Size(220, 20);
            this.mtbSDT.TabIndex = 8;
            this.mtbSDT.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbSDT_MaskInputRejected);
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(510, 62);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 6;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            this.rdNu.CheckedChanged += new System.EventHandler(this.rdNu_CheckedChanged);
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(457, 62);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 5;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/mm/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(457, 23);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(236, 20);
            this.dtpNgaySinh.TabIndex = 4;
            this.dtpNgaySinh.ValueChanged += new System.EventHandler(this.dtpNgaySinh_ValueChanged);
            // 
            // txtHinh
            // 
            this.txtHinh.Location = new System.Drawing.Point(67, 157);
            this.txtHinh.Name = "txtHinh";
            this.txtHinh.ReadOnly = true;
            this.txtHinh.Size = new System.Drawing.Size(563, 20);
            this.txtHinh.TabIndex = 13;
            this.txtHinh.TextChanged += new System.EventHandler(this.txtHinh_TextChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(67, 121);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(307, 20);
            this.txtDiaChi.TabIndex = 3;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(67, 89);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(307, 20);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(67, 59);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(307, 20);
            this.txtHoVaTen.TabIndex = 1;
            this.txtHoVaTen.TextChanged += new System.EventHandler(this.txtHoVaTen_TextChanged);
            // 
            // mtbMSSV
            // 
            this.mtbMSSV.Location = new System.Drawing.Point(67, 21);
            this.mtbMSSV.Mask = "0000000";
            this.mtbMSSV.Name = "mtbMSSV";
            this.mtbMSSV.Size = new System.Drawing.Size(307, 20);
            this.mtbMSSV.TabIndex = 0;
            this.mtbMSSV.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbMSSV_MaskInputRejected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hình";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(397, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(397, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Lớp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Phái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV";
            // 
            // grbDSSV
            // 
            this.grbDSSV.Controls.Add(this.lvSinhVien);
            this.grbDSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDSSV.Location = new System.Drawing.Point(12, 244);
            this.grbDSSV.Name = "grbDSSV";
            this.grbDSSV.Size = new System.Drawing.Size(887, 252);
            this.grbDSSV.TabIndex = 2;
            this.grbDSSV.TabStop = false;
            this.grbDSSV.Text = "Danh sách sinh viên";
            // 
            // lvSinhVien
            // 
            this.lvSinhVien.CheckBoxes = true;
            this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MSSV,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.HideSelection = false;
            this.lvSinhVien.Location = new System.Drawing.Point(3, 19);
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(881, 230);
            this.lvSinhVien.TabIndex = 0;
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            // 
            // MSSV
            // 
            this.MSSV.Text = "MSSV";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ và tên";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phái";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày Sinh";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Lớp";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số điện thoại";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Email";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Đia chỉ";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Hình";
            this.columnHeader9.Width = 120;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "FIle GIF|*.Jpg";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmChinh
            // 
            this.ClientSize = new System.Drawing.Size(924, 508);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbDSSV);
            this.Controls.Add(this.grbThongTin);
            this.Name = "frmChinh";
            this.Text = "Quản lý thông tin khoa CNTT";
            this.Load += new System.EventHandler(this.frmChinh_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.grbDSSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void frmChinh_Load(object sender, System.EventArgs e)
        {
            InitializeComponent();
        }

        private void rdNu_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void mtbMSSV_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Mã sinh viên phải gồm 7 ký tự số.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            // Tạo hộp thoại chọn tệp
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            // Kiểm tra nếu người dùng chọn tệp
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lưu đường dẫn hình ảnh vào TextBox
                txtHinh.Text = openFileDialog.FileName;

                // Hiển thị hình ảnh trong PictureBox
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
           
        }



        private void txtHinh_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            txtHinh.Text = string.Empty;
            pictureBox1.Image = null;
            mtbMSSV.Text = string.Empty;
            txtHoVaTen.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            dtpNgaySinh.Text = string.Empty;
            cbLop.Text = string.Empty;
            mtbSDT.Text = string.Empty;
        }

        private void txtHoVaTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mtbSDT_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}