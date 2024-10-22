﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AkhtarievaNR.Sprint2.Task0.V16.Lib
{
    public class DataService : ISprint2Task0V16
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            
            res[0] = x == y + 750;
            res[1] = x != y + 750;
            res[2] = x < y + 1000;
            res[3] = x > y + 1000;
            res[4] = x <= y + 2000;
            res[5] = x >= y + 2000;

            return res;
        }
    }
}
