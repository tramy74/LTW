using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangSoNguyen
{
    internal class MangSoNguyen
    {
        List<int> _list;
        public int Length
        {
            get
            {
                return _list.Count;
            }
        }
        public MangSoNguyen()
        {
            _list = new List<int>();
        }
        public void Clear()
        {
            _list.Clear();
        }
        public void Add(int n)
        {
            _list.Add(n);
        }
        public void Sort(int type = 1)
        {
            if (type == 1)
            {
                _list.Sort();
            }
            else if (type == -1)
            {
                _list.Sort();
                _list.Reverse();
            }
        }
        public int[] GetList()
        {
            return _list.ToArray();
        }
        public int SearchGiaTri(int giaTri)
        {
            return _list.IndexOf(giaTri);
        }
        public int SearchViTri(int viTri)
        {
            if (viTri < 0 || viTri >= Length)
            {
                return -1;
            }
            return _list[viTri];
        }
        public void XoaGiaTri(int giaTri)
        {
            _list.Remove(giaTri);
        }
        public void XoaViTri(int viTri)
        {
            _list.Remove(SearchViTri(viTri));
        }
        public void ThemGiaTri(int giaTri, int value)
        {

            _list.Insert(SearchGiaTri(giaTri), value);
        }
        public void ThemViTri(int viTri, int value)
        {
            if (viTri < 0 || viTri >= Length)
            {
                return;
            }
            _list.Insert(viTri, value);
        }
        public int TongMang()
        {
            return _list.Sum();
        }
        public int TongMangChan()
        {
            return _list.Where((x) => x % 2 == 0).Sum();
        }
        public int TongMangLe()
        {
            return _list.Where((x) => x % 2 == 1).Sum();
        }
        public int Max()
        {
            return _list.Max();
        }
        public int Min()
        {
            return _list.Min();
        }
        public void ThayTheGiaTri(int giaTri, int value)
        {
            _list[SearchGiaTri(giaTri)] = value;
        }
        public void ThayTheViTri(int viTri, int value)
        {
            if (viTri < 0 || viTri >= Length)
            {
                return;
            }
            _list[viTri] = value;
        }
    }
}
