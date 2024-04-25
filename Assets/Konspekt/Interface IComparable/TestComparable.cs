
using UnityEngine;

namespace IComparableTest
{
    internal sealed class TestComparable : MonoBehaviour
    {
        private void Start()
        {
            IComparableClass comparableClass = new IComparableClass();

            for (int i = 0; i < comparableClass.Enemies.Length; i++)
            {
                Debug.Log(comparableClass.Enemies[i].Damage);
            }
        }
    }
}
