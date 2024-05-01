
using System.Collections.Generic;
using UnityEngine;

namespace LambdaTest
{
    internal sealed class LambdaExpressionSyntax : MonoBehaviour
    {
        private void Start()
        {
            LambdaTestSyntax();
        }

        private void LambdaTestSyntax()
        {
            List<int> list = new List<int>();

            list.AddRange(new int[] { 1, 20, 8, 7, 15, 3, 9, 21, 22, 74 });

            List<int> evenNumbers = list.FindAll(i => (i%2) == 0);

            Debug.Log("Здесь только четные числа: ");
            foreach (int evenNumber in evenNumbers)
            {
                Debug.Log(evenNumber);
            }

        }
    }
}
