
using UnityEngine;

namespace IDisposableTest
{
    public class TestDisposable : MonoBehaviour
    {
        private Enemy _enemy;

        private void Start()
        {
            _enemy = new Enemy();
            _enemy.OnTestDispose?.Invoke();
        }

        private void OnDisable()
        {
            _enemy.Dispose();
        }
    }
}
