
using System.Collections.Generic;
using UnityEngine;

namespace IComparerTest
{
    internal sealed class EnemyList
    {
        public List<Enemy> Enemies;

        public EnemyList()
        {
            Enemies = new List<Enemy>();
            InitializeArray();
            Enemies.Sort(new Enemy());
            
        }

        private void InitializeArray()
        {
            for (int i = 0; i < 10; i++)
            {
                Enemies.Add(new Enemy());
                Enemies[i].Damage = Random.Range(0, 100);
            }
        }
    }
}
