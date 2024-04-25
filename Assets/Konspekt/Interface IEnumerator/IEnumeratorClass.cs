using System.Collections;

namespace IEnumeratorTest
{
    internal sealed class IEnumeratorClass : IEnumerator,IEnumerable
    {
        private Enemy[] _enemies;
        private int _index = -1;

        public object Current => _enemies[_index];

        public IEnumeratorClass()
        {
            _enemies = new Enemy[10];

            InitializeArray();
        }

        private void InitializeArray()
        {
            for (int i = 0; i < _enemies.Length; i++)
            {
                _enemies[i] = new Enemy();
            }
        }

        public bool MoveNext()
        {
            if (_index == _enemies.Length - 1)
            {
                Reset();
                return false;
            }

            _index++;
            return true;

        }

        public void Reset()
        {
            _index = -1;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }
}
