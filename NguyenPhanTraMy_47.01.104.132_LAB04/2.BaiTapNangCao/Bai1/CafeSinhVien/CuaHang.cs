using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSinhVien
{
    internal class CuaHang
    {
        List<KhachHang> _danhSachKhachHang;
        List<ThucAn> _danhSachThucAn;
        List<ThucUong> _danhSachThucUong;
        public CuaHang()
        {
            _danhSachKhachHang = new List<KhachHang>();
            _danhSachThucAn = new List<ThucAn>();
            _danhSachThucUong = new List<ThucUong>();
            KhoiTaoThucAn();
            KhoiTaoThucUong();
        }
        public void AddKhachHang(KhachHang khachHang)
        {
            _danhSachKhachHang.Add(khachHang);
        }
        public void AddThucAn(ThucAn thucAn)
        {
            _danhSachThucAn.Add(thucAn);
        }
        public void AddThucUong(ThucUong thucUong)
        {
            _danhSachThucUong.Add(thucUong);
        }
        void KhoiTaoThucUong()
        {
            ThucUong cafeDen = new ThucUong(1, "Cafe đen", 20000);
            ThucUong cafeDa = new ThucUong(2, "Cafe đá", 25000);
            ThucUong cafeSua = new ThucUong(3, "Cafe sữa", 25000);
            ThucUong cafeSuaDa = new ThucUong(4, "Cafe sữa đá", 30000);
            ThucUong cafeKem = new ThucUong(5, "Cafe kem", 35000);
            AddThucUong(cafeDen);
            AddThucUong(cafeDa);
            AddThucUong(cafeSua);
            AddThucUong(cafeSuaDa);
            AddThucUong(cafeKem);
        }
        void KhoiTaoThucAn()
        {
            ThucAn banhMyTrung = new ThucAn(1, "Bánh mỳ trứng", 15000);
            ThucAn banhMyCa = new ThucAn(2, "Bánh mỳ cá", 15000);
            ThucAn myTomTrung = new ThucAn(3, "Mỳ tôm trứng", 20000);
            ThucAn myXaoBo = new ThucAn(4, "Mỳ xào bò", 30000);
            ThucAn myCay = new ThucAn(5, "Mỳ cay", 50000);
            AddThucAn(banhMyTrung);
            AddThucAn(banhMyCa);
            AddThucAn(myTomTrung);
            AddThucAn(myCay);
            AddThucAn(myXaoBo);





        }
        public int GetSoLuongKhachHang()
        {
            return _danhSachKhachHang.Count;
        }
        public ThucUong GetThucUong(int maThucUong)
        {
            foreach (var item in _danhSachThucUong)
            {
                if (item.MaThucUong == maThucUong)
                {
                    return item;
                }
            }
            return null;
        }
        public ThucAn GetThucAn(int maThucAn)
        {
            foreach (var item in _danhSachThucAn)
            {
                if (item.MaThucAn == maThucAn)
                {
                    return item;
                }
            }
            return null;
        }
        public int GetTongTien()
        {
            int tongTien = 0;
            foreach (var item in _danhSachKhachHang)
            {
                tongTien += item.TongTien;
            }
            return tongTien;
        }

    }
}
