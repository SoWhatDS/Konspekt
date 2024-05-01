using System;
using System.Collections.Generic;
using UnityEngine;

namespace LambdaTest
{
    internal sealed class ExamplePredicate : MonoBehaviour
    {
        private void Start()
        {
            TraditionalDelegateSyntax();
        }

        private void TraditionalDelegateSyntax()
        {
            List<int> list = new List<int>();

            list.AddRange(new int[] { 1, 20, 8, 7, 15, 3, 9, 21, 22, 74 });

            //создаем экземпляр делегата, используя встроенный делегат Predicate
            Predicate<int> predicate = new Predicate<int>(IsEvenNumber);

            List<int> evenNumbers = list.FindAll(predicate);

            Debug.Log("Здесь только четные числа: ");
            foreach (int evenNumber in evenNumbers)
            {
                Debug.Log(evenNumber);
            }

        }

        //цель для делегата Predicate
        private bool IsEvenNumber(int i)
        {
            return i % 2 == 0;
        }
    }
}
