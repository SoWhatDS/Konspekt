
using UnityEngine;

namespace IEnumeratorTest
{
    public class TestIEnumerator : MonoBehaviour
    {
        private void Start()
        {
            IEnumeratorClass testIEnumerator = new IEnumeratorClass();

            while (testIEnumerator.MoveNext())
            {
                if (testIEnumerator.Current is Enemy enemy)
                {
                    enemy.Test();
                }
            }
        }
    }
}
