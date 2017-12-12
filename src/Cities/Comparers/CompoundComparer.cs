using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Comparers
{
    class CompoundComparer : IComparer<City>
    {
        public IList<IComparer<City>> Comparers = new List<IComparer<City>>();

        public int Compare(City x, City y)
        {
            bool isEqual = true;
            int ComparerIndex = 0;
            int CompareInt = 0;
            while (isEqual && ComparerIndex < Comparers.Count)
            {
                IComparer<City> Comparer = Comparers[ComparerIndex];
                if (Comparer.Compare(x,y) != 0)
                {
                    isEqual = false;
                }
                CompareInt = Comparer.Compare(x, y);
                ComparerIndex++;
            }
            return CompareInt;
        }
    }
}
