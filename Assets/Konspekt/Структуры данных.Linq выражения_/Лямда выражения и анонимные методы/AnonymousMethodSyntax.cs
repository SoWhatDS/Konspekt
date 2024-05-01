
using System.Collections.Generic;
using UnityEngine;

namespace LambdaTest
{
    internal sealed class AnonymousMethodSyntax : MonoBehaviour
    {
        private void Start()
        {
            AnonymousMethodTestSyntax();
        }

        private void AnonymousMethodTestSyntax()
        {
            List<int> list = new List<int>();

            list.AddRange(new int[] { 1, 20, 8, 7, 15, 3, 9, 21, 22, 74 });

            //использование анонимного метода (создается делегат с передаваемым значением i и значение проверяется согласно условию)
            List<int> evenNumbers = list.FindAll(delegate (int i) { return (i % 2) == 0; });

            Debug.Log("Здесь только четные числа: ");
            foreach (int evenNumber in evenNumbers)
            {
                Debug.Log(evenNumber);
            }

        }
    }
}
