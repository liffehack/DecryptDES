using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DES
{
    class C0Generator
    {
        private int A;
        private int B;
        private int C;
        private List<int> T;

        internal C0Generator(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
            T = new List<int>();
            T.Add(11);
            GenerateT();
        }

        internal string GetInitialValues()
        {
            return string.Format("A = {0}; B = {1}; C = {2};", A, B, C);
        }

        internal string GetT()
        {
            string msg = string.Empty;
            var arr = T.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                msg += string.Format("{0}) {1}; ", (i + 1).ToString(), arr[i]);
            }
            return msg;
        }

        private string GetTString()
        {
            string msg = string.Empty;

            foreach (var t in T)
            {
                msg += Convert.ToChar(t);
            }
            return msg;
        }

        internal BitArray GetC0()
        {
            var bytes = Encoding.Default.GetBytes(GetTString());
            return new BitArray(bytes);
        }

        private void GenerateT()
        {
            int value = (A * T[0] + C) % B;
            int index = 1;
            while (index <= 7)
            {
                T.Add(value);
                value = (A * T[index++] + C) % B;
            }
        }
    }
}
