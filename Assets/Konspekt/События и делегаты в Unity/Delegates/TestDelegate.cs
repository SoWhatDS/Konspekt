
using UnityEngine;

namespace TestDelegate
{
    public class TestDelegate : MonoBehaviour
    {
        //тип объекта, который сохраняет ссылку на методы с такой же конструкцией (метод возвращает int,и принимает два входящих параметра int)
        //используют для вызова метода динамически во время исполнения программы, а так же уменьшить связность кода между классами
        public delegate void CaughtPlayerChange();

        //Обощённый делегат, который может принимать любой параметр и возвращать void
        private delegate void MyGenericDelegate<T>(T arg);

        public CaughtPlayerChange CaughtPlayer;
        private GameOver _gameOver;

        private void Start()
        {
            _gameOver = new GameOver();
            CaughtPlayer += _gameOver.GameOverConsole;

            //Обобощённый делегат тест
            MyGenericDelegate<string> strTarget = new MyGenericDelegate<string>(StrTarget);
            strTarget("TestStringDelegate");
            MyGenericDelegate<int> intTarget = IntTarget;
            IntTarget(9);
            strTarget?.Invoke("LastTest");
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                CaughtPlayer();
            }
        }

        private void OnDisable()
        {
            CaughtPlayer -= _gameOver.GameOverConsole;
        }

        private void IntTarget(int target)
        {
            Debug.Log($"int: {++target}");
        }

        private void StrTarget(string target)
        {
            Debug.Log($"string: {target.ToUpper()}");
        }
    }
}
