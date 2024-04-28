

namespace TestEvent
{
    internal sealed class CaughtPlayer 
    {
        public delegate void CaughtPlayerChange(object value);
        public event CaughtPlayerChange CaughtPlayerDelegate;

        public void Iteraction()
        {
            CaughtPlayerDelegate?.Invoke(this);
        }
    }
}
