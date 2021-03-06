﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Comparers
{
    class PopulationComparer : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            if (x.Population < y.Population)
            {
                return 1;
            }
            else if (x.Population > y.Population)
            {
                return -1;
            }
            return 0;
        }
    }
}
