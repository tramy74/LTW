using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSinhVien
{
    internal class ThucAn
    {
        int _maThucAn;
        string _tenThucAn;
        int _giaThucAn;
        public int GiaThucAn
        {
            get { return _giaThucAn; }
        }
        public string TenThucAn
        {
            get { return _tenThucAn; }
        }
        public int MaThucAn
        {
            get { return _maThucAn; }
        }


        public ThucAn()
        {
            _maThucAn = 0;
            _tenThucAn = "";
            _giaThucAn = 0;

        }
        public ThucAn(int maThucAn, string tenThucAn, int giaThucAn)
        {
            _maThucAn = maThucAn;
            _tenThucAn = tenThucAn;
            _giaThucAn = giaThucAn;
        }
    }
}
