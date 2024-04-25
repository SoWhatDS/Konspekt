
using UnityEngine;

namespace IComparerTest
{
    public class TestComparer : MonoBehaviour
    {
        private void Start()
        {
            EnemyList enemyList = new EnemyList();

            foreach (var enemy in enemyList.Enemies)
            {
                Debug.Log(enemy.Damage);
            }
        }
    }
}
