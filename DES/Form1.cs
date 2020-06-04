using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DES
{
    public partial class Form1 : Form
    {
        private string Kstring = "12345678"; //2033 555551 
        private BitArray[] K;
        private int[] IP_OTi;
        private List<int>[] i_Ei;
        private int[] PC1j_j;
        private int[] i_LSi;
        private int[] PC2j_j;
        private int[,] Si;
        private int[] Pi_I;
        private int[] IP_Bi;
        BitArray L0, L1;
        C0Generator C0Gen;
        BitArray C0;

        public Form1()
        {
            InitializeComponent();
            L0 = new BitArray(28, false);
            L1 = new BitArray(28, false);

            //K = new BitArray[16];
            IP_OTi = new int[] { 58, 50, 42, 34, 26, 18, 10, 2, 60, 52, 44, 36, 28, 20, 12, 4,
                62, 54, 46, 38, 30, 22, 14, 6, 64, 56, 48, 40, 32, 24, 16, 8,
                57, 49, 41, 33, 25, 17, 9, 1, 59, 51, 43, 35, 27, 19, 11, 3,
                61, 53, 45, 37, 29, 21, 13, 5, 63, 55, 47, 39, 31, 23, 15, 7};

            i_Ei = new List<int>[] { new List<int>(new int[] { 2, 48}), new List<int>(new int[] { 3 }), new List<int>(new int[] { 4 }), new List<int>(new int[] { 5, 7 }), new List<int>(new int[] { 6, 8 }),
            new List<int>(new int[] { 9}), new List<int>(new int[] { 10}), new List<int>(new int[] { 11, 13}), new List<int>(new int[] { 12, 14}), new List<int>(new int[] { 15}),
            new List<int>(new int[] { 16}), new List<int>(new int[] { 17, 19}), new List<int>(new int[] { 18, 20}), new List<int>(new int[] { 21}), new List<int>(new int[] { 22}),
            new List<int>(new int[] { 23, 25}), new List<int>(new int[] { 24, 26}), new List<int>(new int[] { 27}), new List<int>(new int[] { 28}), new List<int>(new int[] { 29, 31}),
            new List<int>(new int[] { 30, 32}), new List<int>(new int[] { 33}), new List<int>(new int[] { 34}), new List<int>(new int[] { 35, 37}), new List<int>(new int[] { 36, 38}),
            new List<int>(new int[] { 39}), new List<int>(new int[] { 40}), new List<int>(new int[] { 41, 43}), new List<int>(new int[] { 42, 44}), new List<int>(new int[] { 45}),
            new List<int>(new int[] { 46}), new List<int>(new int[] { 1, 47})};

            PC1j_j = new int[] { 57, 49, 41, 33, 25, 17, 9, 1, 58, 50, 42, 34, 26, 18,
            10, 2, 59, 51, 43, 35, 27, 19, 11, 3, 60, 52, 44, 36,
            63, 55, 47, 39, 31, 23, 15, 7, 62, 54, 46, 38, 30, 22,
            14, 6, 61, 53, 45, 37, 29, 21, 13, 5, 28, 20, 12, 4};

            i_LSi = new int[] { 1, 1, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 1};

            PC2j_j = new int[] { 14, 17, 11, 24, 1, 5, 3, 28, 15, 6, 21, 10, 23, 19, 12, 4,
            26, 8, 16, 7, 27, 20, 13, 2, 41, 52, 31, 37, 47, 55, 30, 40,
            51, 45, 33, 48, 44, 49, 39, 56, 34, 53, 46, 42, 50, 36, 29, 32};

            Si = new int[,]{ { 14, 4, 13, 1, 2, 15, 11, 8, 3, 10, 6, 12, 5, 9, 0, 7},
            { 0, 15, 7, 4, 14, 2, 13, 1, 10, 6, 12, 11, 9, 5, 3, 8},
            { 4, 1, 14, 8, 13, 6, 2, 11, 15, 12, 9, 7, 3, 10, 5, 0},
            { 15, 12, 8, 2, 4, 9, 1, 7, 5, 11, 3, 14, 10, 0, 6, 13},
            { 15, 1, 8, 14, 6, 11, 3, 4, 9, 7, 2, 13, 12, 0, 5, 10},
            { 3, 13, 4, 7, 15, 2, 8, 14, 12, 0, 1, 10, 6, 9, 11, 5},
            { 0, 14, 7, 11, 10, 4, 13, 1, 5, 8, 12, 6, 9, 3, 2, 15},
            { 13, 8, 10, 1, 3, 15, 4, 2, 11, 6, 7, 12, 0, 5, 14, 9},
            { 10, 0, 9, 14, 6, 3, 15, 5, 1, 13, 12, 7, 11, 4, 2, 8},
            { 13, 7, 0, 9, 3, 4, 6, 10, 2, 8, 5, 14, 12, 11, 15, 1},
            { 13, 6, 4, 9, 8, 15, 3, 0, 11, 1, 2, 12, 5, 10, 14, 7},
            { 1, 10, 13, 0, 6, 9, 8, 7, 4, 15, 14, 3, 11, 5, 2, 12},
            { 7, 13, 14, 3, 0, 6, 9, 10, 1, 2, 8, 5, 11, 12, 4, 15},
            { 13, 8, 11, 5, 6, 15, 0, 3, 4, 7, 2, 12, 1, 10, 14, 9},
            { 10, 6, 9, 0, 12, 11, 7, 13, 15, 1, 3, 14, 5, 2, 8, 4},
            { 3, 15, 0, 6, 10, 1, 13, 8, 9, 4, 5, 11, 12, 7, 2, 14},
            { 2, 12, 4, 1, 7, 10, 11, 6, 8, 5, 3, 15, 13, 0, 14, 9},
            { 14, 11, 2, 12, 4, 7, 13, 1, 5, 0, 15, 10, 3, 9, 8, 6},
            { 4, 2, 1, 11, 10, 13, 7, 8, 15, 9, 12, 5, 6, 3, 0, 14},
            { 11, 8, 12, 7, 1, 14, 2, 13, 6, 15, 0, 9, 10, 4, 5, 3},
            { 12, 1, 10, 15, 9, 2, 6, 8, 0, 13, 3, 4, 14, 7, 5, 11},
            { 10, 15, 4, 2, 7, 12, 9, 5, 6, 1, 13, 14, 0, 11, 3, 8},
            { 9, 14, 15, 5, 2, 8, 12, 3, 7, 0, 4, 10, 1, 13, 11, 6},
            { 4, 3, 2, 12, 9, 5, 15, 10, 11, 14, 1, 7, 6, 0, 8, 13},
            { 4, 11, 2, 14, 15, 0, 8, 13, 3, 12, 9, 7, 5, 10, 6, 1},
            { 13, 0, 11, 7, 4, 9, 1, 10, 14, 3, 5, 12, 2, 15, 8, 6},
            { 1, 4, 11, 13, 12, 3, 7, 14, 10, 15, 6, 8, 0, 5, 9, 2},
            { 6, 11, 13, 8, 1, 4, 10, 7, 9, 5, 0, 15, 14, 2, 3, 12},
            { 13, 2, 8, 4, 6, 15, 11, 1, 10, 9, 3, 14, 5, 0, 12, 7},
            { 1, 15, 13, 8, 10, 3, 7, 4, 12, 5, 6, 11, 0, 14, 9, 2},
            { 7, 11, 4, 1, 9, 12, 14, 2, 0, 6, 10, 13, 15, 13, 5, 8},
            { 2, 1, 14, 7, 4, 10, 8, 13, 5, 12, 9, 0, 3, 5, 5, 11} };

            Pi_I = new int[] { 16, 7, 20, 21, 29, 12, 28, 17, 1, 15, 23, 26, 5, 18, 31, 10,
            2, 8, 24, 14, 32, 27, 3, 9, 19, 13, 30, 6, 22, 11, 4, 25};

            IP_Bi = new int[] { 40, 8, 48, 16, 56, 24, 64, 32, 39, 7, 47, 15, 55, 23, 63, 31,
            38, 6, 46, 14, 54, 22, 62, 30, 37, 5, 45, 13, 53, 21, 61, 29,
            36, 4, 44, 12, 52, 20, 60, 28, 35, 3, 43, 11, 51, 19, 59, 27,
            34, 2, 42, 10, 50, 18, 58, 26, 33, 1, 41, 9, 49, 17, 57, 25};

            K = GetK();
            C0Gen = new C0Generator(41, 256, 13);
            C0 = GetC0(65, 10, 5, 13);
        }

        private BitArray GetC0(int T0, int A, int B, int C)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int index = 0; index < 8; index++)
            {
                stringBuilder.Append((char)T0);
                T0 = (A * T0 + C) % B;
            }
            var bytes = Encoding.Default.GetBytes(stringBuilder.ToString());
            var c0 = new BitArray(bytes);
            return c0;
        }

        private BitArray GetF(BitArray right, BitArray k)
        {
            var extention = Extension(right, i_Ei);
            var xorSum = Xor(extention, k);
            var sBlock = SBlock(xorSum, Si);
            var f = Transposition(sBlock, Pi_I, false);
            return f;
        }

        private BitArray[] GetK()
        {
            BitArray[] K = new BitArray[15];
            var bytesK = GetBytes(Kstring)[0];
            var K0 = Transposition(new BitArray(bytesK), PC1j_j, true);
            var leftAndRight = SplitInHalf(K0);
            var left = leftAndRight[0];
            var right = leftAndRight[1]; //L1;//
            for (int index = 0; index < 15; index++)
            {
                left = ShiftLeft(left, i_LSi[index]);
                right = ShiftLeft(right, i_LSi[index]);
                var t = Transposition(ConcatArrays(right, left), PC2j_j, true);
                K[index] = t;
            }
            return K;
        }

        private BitArray Transposition(BitArray inputArr, int[] rule, bool isKey)
        {
            BitArray outputArr = new BitArray(rule.Length);
            int ruleIndex = 0;
            for (int index = 0; index < outputArr.Length; index++)
            {
                if (isKey && index % 8 == 7)
                {
                    continue;
                }
                outputArr[ruleIndex] = inputArr[rule[ruleIndex++] - 1];
            }
            return outputArr;
        }

        private BitArray RevTransposition(BitArray inputArr, int[] rule, bool isKey)
        {
            BitArray outputArr = new BitArray(rule.Length);
            int ruleIndex = 0;
            for (int index = 0; index < outputArr.Length; index++)
            {
                if (isKey && index % 8 == 7)
                {
                    continue; 
                }
                outputArr[rule[ruleIndex] - 1] = inputArr[ruleIndex++];
            }
            return outputArr;
        }

        private BitArray Xor(BitArray arr1, BitArray arr2)
        {
            return arr1.Xor(arr2);
        }

        private BitArray Extension(BitArray inputArr, List<int>[] rule)
        {
            BitArray outputArr = new BitArray(48);
            for (int index = 0; index < inputArr.Length; index++)
            {
                foreach (var el in rule[index])
                {
                    outputArr[el - 1] = inputArr[index];
                }
            }
            return outputArr;
        }

        private BitArray SBlock(BitArray inputArr, int[,] rule)
        {
            BitArray outputArr = new BitArray(32);
            int k, l = 0;
            int counterByFour = 0;
            for (int index = 0; index < inputArr.Length; index += 6)
            {
                k = BinToDec(Convert.ToInt16(inputArr[index]).ToString() + Convert.ToInt16(inputArr[index + 5]).ToString());
                l = BinToDec(Convert.ToInt16(inputArr[index + 1]).ToString() + Convert.ToInt16(inputArr[index + 2]).ToString() +
                        Convert.ToInt16(inputArr[index + 3]).ToString() + Convert.ToInt16(inputArr[index + 4]));
                AddToArr(ref outputArr, counterByFour, DecToBin(rule[k, l]));
                counterByFour += 4;
            }
            return outputArr;
        }

        private BitArray[] SplitInHalf(BitArray inputArr)
        {
            bool[] input = new bool[inputArr.Length];
            inputArr.CopyTo(input, 0);
            BitArray[] outputArr = new BitArray[2];
            bool[] arr = new bool[inputArr.Length / 2];
            Buffer.BlockCopy(input, 0, arr, 0, arr.Length);
            outputArr[0] = new BitArray(arr);
            Buffer.BlockCopy(input, inputArr.Length / 2, arr, 0, arr.Length);
            outputArr[1] = new BitArray(arr);
            return outputArr;
        }

        private BitArray ShiftLeft(BitArray inputArr, int pos)
        {
            for (int index = 0; index < inputArr.Length - pos; index++)
            {
                inputArr[index] = inputArr[index + pos];
            }
            for (int index = inputArr.Length - pos; index < inputArr.Length; index++)
            {
                inputArr[index] = false;
            }
            return inputArr;
        }

        private BitArray ConcatArrays(BitArray arr1, BitArray arr2)
        {
            BitArray outputArr = new BitArray(arr1.Length + arr2.Length);
            for (int index = 0; index < arr1.Length; index++)
            {
                outputArr[index] = arr1[index];
            }
            for (int index = 0; index < arr2.Length; index++)
            {
                outputArr[index + arr1.Length] = arr2[index];
            }
            return outputArr;
        }

        private int BinToDec(string str)
        {
            return Convert.ToInt32(str, 2);
        }

        private string DecToBin(long i)
        {
            var str = Convert.ToString(i, 2);
            string empty = string.Empty;
            for (int index = str.Length; index < 4; index++)
            {
                empty += "0";
            }
            return empty + str;
        }

        private void AddToArr(ref BitArray arr, int index, string str)
        {
            foreach (var ch in str)
            {
                arr[index++] = ch == '1';
            }
        }

        private void OutToLabel(int[] arr, Label label)
        {
            label.Text = string.Empty;
            string msg = string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                msg += string.Format("{0}) {1}; ", (i + 1).ToString(), arr[i]);
            }
            label.Text = msg;
        }

        private void shifrButton_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                Kstring = textBox1.Text;
                K = GetK();
            }
            //CheckInputData(cryptInputTextBox);
            switch (toolStripComboBox1.Text) { 
                case "ECB":
                    crypt();
                    break;
                case "CBC":
                    cryptCBC();
                    break;
                case "CFB":
                    cryptCFB();
                    break;
                case "OFB":
                    cryptCBC();
                    break;

            }
            
        }

        private void crypt()
        {
            shifrOutputTextBox.Text = string.Empty;
            var bytesArray = GetBytes(shifrInputTextBox.Text);
            byte[] bytes = new byte[8];
            foreach (var array in bytesArray)
            {
                DoDirectMainCicl(new BitArray(array)).CopyTo(bytes, 0);
                shifrOutputTextBox.Text += GetNewString(Encoding.Default.GetString(bytes));//s1;
            }
        }

        private string GetNewString(string str)
        {
            return str.Replace("\0", "\\0");
        }

        private BitArray DoDirectMainCicl(BitArray bitArray)
        {
            var IP = Transposition(bitArray, IP_OTi, false);
            var leftAndRight = SplitInHalf(IP);
            var left = leftAndRight[0];
            BitArray oldLeft = left;
            var right = leftAndRight[1];
            BitArray f;
            for (int index = 0; index < 15; index++)
            {
                f = GetF(right, K[index]);
                left = right;
                right = Xor(oldLeft, f);
                oldLeft = left;
            }
            var concat = ConcatArrays(left, right);
            var crypt = Transposition(concat, IP_Bi, false);
            return crypt;
        }

        private byte[][] GetBytes(string str)
        {
            byte[] bytesArray = Encoding.Default.GetBytes(str);
            bytesArray = AddToBlock(bytesArray);
            byte[][] array = new byte[bytesArray.Length / 8][];
            for (int index = 0; index < bytesArray.Length / 8; index++)
            {
                array[index] = new byte[8];
                Buffer.BlockCopy(bytesArray, index * 8, array[index], 0, 8);
            }
            return array;
        }

        private byte[] AddToBlock(byte[] byteArray)
        {
            int value = 8 - byteArray.Length % 8;
            int addedCount = value != 8 ? value : 0;
            byte[] outputArr = new byte[byteArray.Length + addedCount];
            Buffer.BlockCopy(byteArray, 0, outputArr, 0, byteArray.Length);
            for (int index = 0; index < addedCount; index++)
            {
                outputArr[index + byteArray.Length] = 32;
            }
            return outputArr;
        }

        private void Decrypt()
        {
            deshifrOutputTextBox.Text = string.Empty;
            var bytesArray = GetBytes(deshifrInputTextBox.Text);
            byte[] bytes = new byte[8];
            foreach (var array in bytesArray)
            {
                DoReverseMainCicl(new BitArray(array)).CopyTo(bytes, 0);
                deshifrOutputTextBox.Text += Encoding.Default.GetString(bytes);
            }
        }

        private BitArray DoReverseMainCicl(BitArray bitArray)
        {
            var crypt = RevTransposition(bitArray, IP_Bi, false);
            var leftAndRight = SplitInHalf(crypt);
            var left = leftAndRight[0];
            var right = leftAndRight[1];
            var oldRight = right;
            //var K = GetK();
            BitArray f;
            for (int index = 14; index >= 0; index--)
            {
                right = left;
                f = GetF(right, K[index]);
                left = Xor(oldRight, f);
                oldRight = right;
            }
            var concat = ConcatArrays(left, right);
            var IP = RevTransposition(concat, IP_OTi, false);

            return IP;
        }

        private BitArray GetLeftBits(BitArray bitArray, int bitCount)
        {
            BitArray output = new BitArray(bitCount);
            for (int index = 0; index < bitCount; index++)
            {
                output[index] = bitArray[index];
            }
            return output;
        }

        private BitArray AddKBitesToRight(BitArray array, BitArray addedArray, int k)
        {
            for (int index = 0; index < array.Length - k; index++)
            {
                array[index] = array[index + k];
            }
            for (int index = 0; index < k; index++)
            {
                array[index + array.Length - k] = addedArray[index];
            }
            return array;
        }

        private BitArray[] GetBites(string str, int blockSize)
        {
            byte[] bytesArray = Encoding.Default.GetBytes(str);
            bytesArray = AddToBlock(bytesArray, blockSize);

            BitArray temp = new BitArray(bytesArray);
            BitArray[] array = new BitArray[temp.Length / blockSize];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new BitArray(blockSize);

                for (int j = 0; j < blockSize; j++)
                {
                    array[i][j] = temp[i * blockSize + j];
                }
            }
            return array;
        }

        private byte[] AddToBlock(byte[] byteArray, int blockSize)
        {
            int value = blockSize - byteArray.Length % blockSize;
            int addedCount = value != blockSize ? value : 0;
            byte[] outputArr = new byte[byteArray.Length + addedCount];
            Buffer.BlockCopy(byteArray, 0, outputArr, 0, byteArray.Length);
            for (int index = 0; index < addedCount; index++)
            {
                outputArr[index + byteArray.Length] = 32;
            }
            return outputArr;
        }

        private void cryptCFB()
        {
            var k = (int)kNumericUpDown.Value;
            BitArray[] bitesArray = GetBites(shifrInputTextBox.Text, k);
            var c0 = C0Gen.GetC0();
            shifrOutputTextBox.Text = string.Empty;
            byte[] bytes = new byte[8];
            BitArray result = new BitArray(0);
            BitArray bitArray;

            foreach (var array in bitesArray)
            {
                DoDirectMainCicl(new BitArray(c0)).CopyTo(bytes, 0);
                var leftBits = GetLeftBits(new BitArray(bytes), k);
                bitArray = Xor(array, leftBits);
                result = ConcatArrays(result, bitArray);
                c0 = AddKBitesToRight(c0, bitArray, k);
            }
            byte[] resultBytes = new byte[result.Length / 8];
            result.CopyTo(resultBytes, 0);
            shifrOutputTextBox.Text += Encoding.Default.GetString(resultBytes);//s1;
        }

        private void DecryptCFB()
        {
            var k = (int)kNumericUpDown.Value;
            BitArray[] bitesArray = GetBites(deshifrInputTextBox.Text, k);
            var c0 = C0Gen.GetC0();
            deshifrOutputTextBox.Text = string.Empty;
            byte[] bytes = new byte[8];
            BitArray result = new BitArray(0);
            foreach (var array in bitesArray)
            {
                DoDirectMainCicl(new BitArray(c0)).CopyTo(bytes, 0);
                var t = new BitArray(bytes);
                var leftBits = GetLeftBits(new BitArray(bytes), k);
                leftBits = Xor(new BitArray(array), leftBits);
                result = ConcatArrays(result, leftBits);
                c0 = AddKBitesToRight(c0, array, k);
            }

            byte[] resultBytes = new byte[result.Length / 8];
            result.CopyTo(resultBytes, 0);
            deshifrOutputTextBox.Text += Encoding.Default.GetString(resultBytes);//s1;
        }

        private void cryptCBC()
        {
            shifrOutputTextBox.Text = string.Empty;
            var bytesArray = GetBytes(shifrInputTextBox.Text);
            byte[] bytes = new byte[8];
            var C = C0;
            BitArray m, xorResult;
            foreach (var array in bytesArray)
            {
                m = new BitArray(array);
                xorResult = Xor(m, C);
                m = DoDirectMainCicl(xorResult);
                m.CopyTo(bytes, 0);
                shifrOutputTextBox.Text += GetNewString(Encoding.Default.GetString(bytes));//s1;
                C = m;
            }
        }

        private void DecryptCBC()
        {
            deshifrOutputTextBox.Text = string.Empty;
            var bytesArray = GetBytes(deshifrInputTextBox.Text);
            byte[] bytes = new byte[8];
            BitArray m, oldC;
            var C = oldC = C0;

            foreach (var array in bytesArray)
            {
                m = new BitArray(array);
                C = m;
                m = Xor(oldC, DoReverseMainCicl(C));
                m.CopyTo(bytes, 0);
                deshifrOutputTextBox.Text += Encoding.Default.GetString(bytes);
                oldC = C;
            }
        }

        private void deshifrButton_Click(object sender, EventArgs e)
        {
            switch (toolStripComboBox1.Text)
            {
                case "ECB":
                    Decrypt();
                    break;
                case "CBC":
                    DecryptCBC();
                    break;
                case "CFB":
                    DecryptCFB();
                    break;
                case "OFB":
                    DecryptCBC();
                    break;

            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                shifrInputTextBox.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void сохранитьЗашифрованныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Validated(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            deshifrInputTextBox.Text = shifrOutputTextBox.Text;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void shifrOutputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void kNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.SelectedText = toolStripComboBox1.Items[0].ToString();
        }
    }
}
