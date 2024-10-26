﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AkhtarievaNR.Sprint2.Task2.V6.Lib
{
    public class DataService : ISprint2Task2V6
    {
        public bool CheckDotInShadedArea(int x, int y)

        {
            bool res;

            if ((x >= 3) && (x <= 5) && (y >= 3) && (y <= 7))
            {
                res = true;        
            }

            else if ((x >= 6) && (x <= 10) && (y >= 5) && (y <= 7))
            {
                res = true;
            }

            else if ((x >= 9) && (x <= 9) && (y >= 3) && (y <= 4))
            {
                res = true;
            }

            else if ((x >= 3) && (x <= 11) && (y == 11))
            {
                res = true;
            }

            else if ((x >= 7) && (x <= 10) && (y == 12))
            {
                res = true;
            }

            else
            {
               res = false;
            }
            return res;

        }
    }
}
