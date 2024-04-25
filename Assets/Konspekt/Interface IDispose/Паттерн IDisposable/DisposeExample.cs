using System;


//паттерн IDisposable
namespace IDisposableTest
{
    internal class DisposeExample : IDisposable
    {
        private bool _isDisposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    //освобождаем управлямые ресурсы
                }

                //освобождаем неуправляемые ресурсы
                _isDisposed = true;
            }   
        }

        //реализация интерфейса IDispose
        public void Dispose()
        {
            Dispose(true);
            //подавляем финализацию
            GC.SuppressFinalize(this);
        }
    }

    internal sealed class Derived : DisposeExample
    {
        private bool _isDisposed = false;

        protected override void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    //освобождаем управлямые ресурсы
                }

                //освобождаем неуправляемые ресурсы
                _isDisposed = true;
            }

            //обращение к методу базового класса
            base.Dispose(disposing);
        }
    }
}
