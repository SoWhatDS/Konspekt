using System;


namespace IDisposableTest
{
    
    internal sealed class Enemy : IDisposable
    {
        public Action OnTestDispose;

        public Enemy()
        {
            OnTestDispose += Move;
        }

        private void Move()
        {
            //реализация движения
        }

        public void Dispose()
        {
            //не ожидает финализации и подчищает мусор

            OnTestDispose -= Move;
        }
    }
}
