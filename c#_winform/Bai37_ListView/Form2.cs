using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai37_ListView
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lvSanPham2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        List<DanhMuc> KhoHang = new List<DanhMuc>();
        private void Form2_Load(object sender, EventArgs e)
        {
            DanhMuc sachGiaoKhoa = new DanhMuc();
            sachGiaoKhoa.Ma = "DM1";
            sachGiaoKhoa.Ten = "Sách giáo khoa";
            
            SanPham sp1 = new SanPham("sp1", "công nghệ", 10000);
            SanPham sp2 = new SanPham("sp2", "vật lý", 16000);
            SanPham sp3 = new SanPham("sp3", "hóa học", 23000);
            sachGiaoKhoa.ThemSanPham(sp1);
            sachGiaoKhoa.ThemSanPham(sp2);
            sachGiaoKhoa.ThemSanPham(sp3);

            DanhMuc but = new DanhMuc();
            but.Ma = "DM2";
            but.Ten = "Bút";

            List<SanPham> sanPhams = new List<SanPham>(){
                new SanPham("b1", "bút bi thiên long", 5000),
                new SanPham("b2", "bút chì", 1000),
                new SanPham("b3", "bút mực", 25000)
            };

            sanPhams.ForEach(item => but.ThemSanPham(item));

            KhoHang.Add(sachGiaoKhoa);
            KhoHang.Add(but);

            KhoHang.ForEach(item =>
            {
                ListViewGroup lvg = new ListViewGroup(item.Ten);
                lvSanPham2.Groups.Add(lvg);
                item.SanPhams.ForEach(item =>
                {
                    ListViewItem lvt = new ListViewItem(item.Ma);
                    lvt.SubItems.Add(item.Ten);
                    lvt.SubItems.Add(item.Gia + "");
                    lvt.Group = lvg;
                    lvSanPham2.Items.Add(lvt);
                });
            });
        }
    }
}
