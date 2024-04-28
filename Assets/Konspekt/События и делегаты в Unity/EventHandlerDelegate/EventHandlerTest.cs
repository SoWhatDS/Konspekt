using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TestEventHandler
{
    internal sealed class EventHandlerTest : MonoBehaviour
    {
        private CaughtPlayer _caughtPlayer;
        private GameOver _gameOver;

        private void Start()
        {
            _caughtPlayer = new CaughtPlayer();
            _gameOver = new GameOver();
            _caughtPlayer.CaughtPlayerHandler += _gameOver.GameOverConsole;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                _caughtPlayer.Iteraction();
            }
        }

        private void OnDisable()
        {
            _caughtPlayer.CaughtPlayerHandler -= _gameOver.GameOverConsole;
        }
    }
}
