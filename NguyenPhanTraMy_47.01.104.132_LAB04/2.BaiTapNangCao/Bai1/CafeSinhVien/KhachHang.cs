using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSinhVien
{
    internal class KhachHang
    {
        int _soKhachHang;
        string _tenKhachHang;
        bool _isSinhVien;
        List<ThucAn> _thucAn;
        ThucUong _thucUong;
        int _tongTien;
        int _tongTienSauGiam;
        public int TongTien
        {
            get
            {
                return _tongTienSauGiam;
            }
        }
        public KhachHang()
        {
            _soKhachHang = 0;
            _tenKhachHang = "";
            _isSinhVien = false;
            _tongTien = 0;
            _thucAn = new List<ThucAn>();
            _thucUong = new ThucUong();
        }
        public KhachHang(int soKhachHang, string tenKhachHang, bool isSinhVien)
        {
            _soKhachHang = soKhachHang;
            _tenKhachHang = tenKhachHang;
            _isSinhVien = isSinhVien;
            _tongTien = 0;
            _thucAn = new List<ThucAn>();
            _thucUong = new ThucUong();

        }
        public void AddThucAn(ThucAn thucAn)
        {
            if (thucAn != null)
            {

                _thucAn.Add(thucAn);
            }
        }
        public void SetThucUong(ThucUong thucUong)
        {
            if (thucUong != null)
            {

                _thucUong = thucUong;
            }
        }
        public void SetTongTien()
        {
            int tongTienThucAn = 0;
            foreach (var item in _thucAn)
            {
                tongTienThucAn += item.GiaThucAn;

            }
            _tongTien = tongTienThucAn + _thucUong.GiaThucUong;
            if (_isSinhVien)
            {
                _tongTienSauGiam = _tongTien - _tongTien * 20 / 100;
            }
            else
            {
                _tongTienSauGiam = _tongTien;
            }

        }
        public string GetThongTin()
        {
            string result = "";
            result += $"Tên khách hàng: {_tenKhachHang}\n";
            result += $"Số khách hàng: {_soKhachHang}\n";
            result += $"Thức uống: {_thucUong.TenThucUong} -  {_thucUong.GiaThucUong} VNĐ \n";
            foreach (var item in _thucAn)
            {
                result += $"Thức ăn: {item.TenThucAn} -  {item.GiaThucAn} VNĐ \n";

            }
            result += $"Tổng tiền: {_tongTien} VNĐ \n";
            if (_isSinhVien)
            {
                result += $"Bạn được giảm 20% vì là sinh viên, tổng tiền còn: {_tongTienSauGiam} VNĐ \n";

            }

            return result;
        }
    }
}
