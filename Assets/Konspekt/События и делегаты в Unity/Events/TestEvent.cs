
using UnityEngine;

namespace TestEvent
{
    public class TestEvent : MonoBehaviour
    {
        private CaughtPlayer _caughtPlayer;
        private GameOver _gameOver;

        private void Start()
        {
            _gameOver = new GameOver();
            _caughtPlayer = new CaughtPlayer();
            _caughtPlayer.CaughtPlayerDelegate += _gameOver.GameOverEvent;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                _caughtPlayer.Iteraction();
            }
        }

        private void OnDisable()
        {
            _caughtPlayer.CaughtPlayerDelegate -= _gameOver.GameOverEvent;
        }
    }
}
