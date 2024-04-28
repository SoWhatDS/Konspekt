
using System.Collections.Generic;
using UnityEngine;

namespace ICloneableTest
{
    public class TestCloneable : MonoBehaviour
    {
        private List<Enemy> _enemies;

        private void Start()
        {
            Enemy enemy = new Enemy();
            _enemies = new List<Enemy>();

            for (int i = 0; i < 10; i++)
            {
                _enemies.Add((Enemy)enemy.Clone());
                Debug.Log(_enemies[i]);
            }
        }
    }
}
