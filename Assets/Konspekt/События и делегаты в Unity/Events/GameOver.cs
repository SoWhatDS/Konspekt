
using UnityEngine;

namespace TestEvent
{
    internal sealed class GameOver 
    {
        public void GameOverEvent(object value)
        {
            Debug.Log($"GameOver: {value}");
        }
    }
}
