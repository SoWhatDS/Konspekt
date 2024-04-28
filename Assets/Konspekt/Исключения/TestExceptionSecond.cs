using System;
using UnityEngine;

namespace ExceptionTest
{
    internal sealed class TestExceptionSecond : MonoBehaviour
    {
        private int _a = 1;
        private int _y = 0;

        private void Start()
        {
            try
            {
                int result = _a / _y;
            }
            catch (Exception ex) when (_y == 0)
            {
                Debug.Log("Деление на 0!!!");
                Debug.Log(ex.Message);
            }
        }
    }
}
