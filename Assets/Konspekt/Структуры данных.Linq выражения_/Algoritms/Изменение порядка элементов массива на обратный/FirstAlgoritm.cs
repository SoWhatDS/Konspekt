
using UnityEngine;

namespace Algoritms
{
    internal sealed class FirstAlgoritm : MonoBehaviour
    {
        //изменение порядка элементов массива на обратный
        private void Start()
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };

            Reverse(array);

            foreach (var number in array)
            {
                Debug.Log(number);
            }

        }

        private void Reverse<T>(T[] array)
        {
            int left = 0, right = array.Length - 1;
            while (left < right)
            {
                T temp = array[left];
                array[left] = array[right];
                array[right] = temp;
                left++;
                right--;
            }
        }


    }
}
