
using System.Collections.Generic;

namespace IComparerTest
{
    public class Enemy : IComparer<Enemy>
    {
        public int Damage;
        
        public int Compare(Enemy x, Enemy y)
        {
            if (x.Damage < y.Damage)
            {
                return -1;
            }

            if (x.Damage > y.Damage)
            {
                return 1;
            }

            return 0;
        }
    }
}
