using System;


namespace TestEventHandler
{
    internal sealed class CaughtPlayer 
    {
        private EventHandler<EventHandlerArgs> _caughtPlayer;

        public event EventHandler<EventHandlerArgs> CaughtPlayerHandler
        {
            add { _caughtPlayer += value; }
            remove { _caughtPlayer -= value; }
        }

        public void Iteraction()
        {
            _caughtPlayer?.Invoke(this,new EventHandlerArgs("GameOver"));
        }
    }
}
