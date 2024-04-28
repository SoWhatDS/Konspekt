using System;


namespace TestEventHandler
{
    //класс для передачи аргументов
    internal sealed class EventHandlerArgs : EventArgs
    {
        public string GameOver { get; }

        public EventHandlerArgs(string value)
        {
            GameOver = value;
        }
    }
}
