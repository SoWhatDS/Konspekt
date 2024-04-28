
using UnityEngine;

namespace TestActionDelegate
{
    public class TestAction : MonoBehaviour
    {
        //Action<> обобщенный пример делегата, его можно применять для указания метода,
        //который принимает вплоть до 16 аргументов и возвращает void
        private ActionDelegateTest _actionDelegateTest;

        private void Start()
        {
            _actionDelegateTest = new ActionDelegateTest();

            _actionDelegateTest[UserAction.Up]();
            _actionDelegateTest[UserAction.Down]();
        }
    }
}
