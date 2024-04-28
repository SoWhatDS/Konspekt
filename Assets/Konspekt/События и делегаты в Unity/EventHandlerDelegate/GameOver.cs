
using UnityEngine;

namespace TestEventHandler
{
    internal sealed class GameOver 
    {
        public void GameOverConsole(object o,EventHandlerArgs eventHandlerArgs)
        {
            Debug.Log(eventHandlerArgs.GameOver);
        }
    }
}
