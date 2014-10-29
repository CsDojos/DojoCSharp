using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace UnitTestProjectRomanos
{
    public class Romanos
    {
        private readonly Dictionary<int, string> dictArabeRomano;

        public Romanos()
        {
            dictArabeRomano = new Dictionary<int, string>();
            PopulateDictionary();
        }

        public string Convert(int numero)
        {
            return CheckX(numero);
        }

        private string CheckI(int num)
        {
            var I = dictArabeRomano[1];
            if (num == 1)
                return I;
            if (num == 2)
                return I+I;
            if (num == 3)
                return I+I+I;
            return "";
        }

        private string CheckV(int num)
        {
            var result = "";
            var I = dictArabeRomano[1];
            var V = dictArabeRomano[5];
            if (num >= 5 && num <= 8)
            {
                result += V;
                num -= 5;
            }
            if (num == 4)
            {
                result += I + V;
                num -= 4;
            }
            return result + CheckI(num);
        }

        private string CheckX(int num)
        {
            var result = "";
            var I = dictArabeRomano[1];
            var X = dictArabeRomano[10];
            if (num == 10)
            {
                result += X;
                num -= 10;
            }
            if (num == 9)
            {
                result += I + X;
                num -= 9;
            }
            return result + CheckV(num);
        }

        private void PopulateDictionary()
        {
            var I = "I";
            var V = "V";
            var X = "X";
            dictArabeRomano.Add(1, I);
            dictArabeRomano.Add(5, V);
            dictArabeRomano.Add(10, X);
        }
    }
}