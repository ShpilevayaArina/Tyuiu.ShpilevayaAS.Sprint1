﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShpilevayaAS.Sprint1.Task6.V10.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint1.ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string value)
        {
            string[] array = new string[] { };
            string[] st = value.Split(' ');
            for (int i = 1; i < st.Length -1; i++)
            {
                if (st[i].Length % 2 == 1)
                {
                    st[i] = st[i].Remove(st[i].Length / 2, 1);
                }
                array[i] = (string)st[i];
            }
            return string.Join("", array);
        }
    }
}
