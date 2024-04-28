using System;
using UnityEngine;

namespace TestFuncDelegate
{
    public class TestFunc : MonoBehaviour
    {
        //обощённый делегат, который может принимать до 16 аргументов и возвращать специальное возвращаемое значение
        private Func<string> _gameOverAction;

        private void Start()
        {
            var GameOver = new GameOver();
            _gameOverAction += GameOver.GameOverFunc;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                Debug.Log(_gameOverAction?.Invoke());
            }
        }
    }
}
