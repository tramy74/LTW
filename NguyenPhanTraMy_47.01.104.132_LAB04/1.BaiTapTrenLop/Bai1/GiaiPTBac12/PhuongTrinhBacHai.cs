using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiPTBac12
{
    internal class PhuongTrinhBacHai
    {
        float _a, _b, _c;
        public PhuongTrinhBacHai()
        {
            _a = 0;
            _b = 0;
            _c = 0;
        }
        public PhuongTrinhBacHai(float a, float b, float c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        public string Giai()
        {
            string result;
            if (_a == 0)
            {
                if (_b == 0)
                {
                    if (_c == 0)
                    {
                        result = "Phuong trinh vo so nghiem";
                    }
                    else
                    {
                        result = "Phuong trinh vo nghiem";
                    }
                }
                else
                {
                    result = $"Phuong trinh co nghiem duy nhat: {-_c / _b}";
                }
            }
            else
            {
                float delta = _b * _b - 4 * _a * _c;
                if (delta > 0)
                {
                    float x1 = (float)((-_b + Math.Sqrt(delta)) / (2 * _a));
                    float x2 = (float)((-_b - Math.Sqrt(delta)) / (2 * _a));
                    result = $"Nghiem thu nhat x1 = {x1}, x2 = {x2}";
                }
                else if (delta == 0)
                {
                    result = $"Phuong trinh co nghiem kep: x1 = x2 = {-_b / 2 * _a}";
                }
                else
                {
                    result = "Phuong trinh vo nghiem";
                }

            }
            return result;
        }


    }
}
