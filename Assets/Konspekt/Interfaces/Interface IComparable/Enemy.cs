

using System;

namespace IComparableTest
{
    internal sealed class Enemy : IComparable<Enemy>
    {
        public int Damage;

        public int CompareTo(Enemy enemy)
        {
            if (enemy == null)
            {
                throw new Exception();
            }

            return Damage.CompareTo(enemy.Damage);
        }
        
    }
}
