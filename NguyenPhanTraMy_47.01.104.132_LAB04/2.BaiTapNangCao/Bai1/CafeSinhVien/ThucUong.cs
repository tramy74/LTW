using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSinhVien
{
    internal class ThucUong
    {
        int _maThucUong;
        string _tenThucUong;
        int _giaThucUong;
        public int GiaThucUong
        {
            get
            {
                return _giaThucUong;
            }
        }
        public string TenThucUong
        {
            get
            {
                return _tenThucUong;
            }
        }
        public int MaThucUong
        {
            get
            {
                return _maThucUong;
            }
        }
        public ThucUong()
        {
            _maThucUong = 0;
            _tenThucUong = "";
            _giaThucUong = 0;

        }
        public ThucUong(int maThucUong, string tenThucUong, int giaThucUong)
        {
            _maThucUong = maThucUong;
            _tenThucUong = tenThucUong;
            _giaThucUong = giaThucUong;
        }
    }
}
