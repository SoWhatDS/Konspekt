using System;
using System.Collections.Generic;
using UnityEngine;

namespace TestActionDelegate
{
    //пример замены оператора switch
    internal sealed class ActionDelegateTest 
    {
        private readonly Dictionary<UserAction, Action> _actions;

        public Action this[UserAction index] => _actions[index];

        public ActionDelegateTest()
        {
            _actions = new Dictionary<UserAction, Action>
            {
                [UserAction.Up] = UpMethod,
                [UserAction.Down] = DownMethod
            };
        }

        private void DownMethod()
        {
            Debug.Log(nameof(DownMethod));
        }

        private void UpMethod()
        {
            Debug.Log(nameof(UpMethod));
        }

    }
}
