
using System;
using Random = UnityEngine.Random;

//без IComparable мы не можем передать массив в Array.Sort()!!!!!!
//Array.Sort(_enemies);
namespace IComparableTest
{
    internal sealed class IComparableClass
    {
        public Enemy[] Enemies;

        public IComparableClass()
        {
            Enemies = new Enemy[10];
            InitializeArray();
            Array.Sort(Enemies);
        }

        private void InitializeArray()
        {
            for (int i = 0; i < Enemies.Length; i++)
            {
                Enemies[i] = new Enemy();
                Enemies[i].Damage = Random.Range(0, 100);
            }
        }
    }
}
