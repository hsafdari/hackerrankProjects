using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrankProjects
{
    public static class FlippingBits
    {
        public static long Rotate(long n)
        {

            string st = Convert.ToString(n, 2);           
            List<char> _32bit = new List<char>();
            for (int i = 0;i< 32-st.Length; i++)
            {
                _32bit.Add('0');
            }
            if (_32bit != null)
            {
                _32bit.AddRange(st);
            }
            else
            {
                _32bit.AddRange(st);
            }
            Console.WriteLine(_32bit.ToArray());
            //reverse 0 t0 1 and 1 to 0
            for (int i = 0; i < _32bit.Count; i++)
            {
                if (_32bit[i]=='0')
                {
                    _32bit[i] = '1';
                }
                else
                {
                    _32bit[i] = '0';
                }
            }
            Console.WriteLine(_32bit.ToArray());
            var _mynewNumber =new string(_32bit.ToArray());
            long _data=Convert.ToUInt32(_mynewNumber, 2);
            return _data;
           
        }
        public static long RotateP(long n)
        {
            string st = Convert.ToString(n, 2);
            if (st.Length<0)
            {
                st.PadLeft(32, '0');
            }            
            st.Replace("0", "x").Replace("1", "0").Replace("x", "1");
            long _data = Convert.ToUInt32(st, 2);
            return _data;
        }
    }
}
