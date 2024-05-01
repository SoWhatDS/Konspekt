
using System.Collections.Generic;
using UnityEngine;

namespace ExtensionsTest
{
    public class TestExtensions : MonoBehaviour
    {
        private string _name = "Ivan";

        private void Start()
        {
            AddToList();

            ExampleIsOneOf();
        }

        private void AddToList()
        {
            var list = new List<int>();
            var list2 = new List<int>();

            list.Add(1);

            1.AddTo(list).AddTo(list2);
            2.AddTo(list);

            foreach (var number in list)
            {
                Debug.Log(number);
            }

            foreach (var number in list2)
            {
                Debug.Log(number);
            }

            Debug.Log(_name.TryBool());
        }

        private void ExampleIsOneOf()
        {
            var array = new[] { 1, 5, 6, 3 };

            var t = 7;

            foreach (var i in array)
            {
                if (i == 7)
                {

                }
            }
            //содержится ли значение в массиве?
            if (t.IsOneOf(5, 8, 6, 3))
            {
                Debug.Log("true");
            }
        }
    }
}
