
using UnityEngine;

namespace ParamsTest
{
    internal sealed class ParamsTest : MonoBehaviour
    {
        //используя ключевое слово params мы можем передавать неопределнное количество параметров или массив.Должен находится последним в списке параметров
        private void Start()
        {
            Addition(1, 2, 3, 4, 5);

            int[] array = new int[] { 5, 4, 3, 2, 1 };
            Addition(array);

            //ничего не выведет
            Addition();
        }

        private void Addition(params int[] integers)
        {
            for (int i = 0; i < integers.Length; i++)
            {
                Debug.Log(integers[i]);
            }
        }
    }
}
