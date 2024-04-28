
using System.Collections.Generic;
using UnityEngine;

namespace ListTest
{
    internal sealed class TestList : MonoBehaviour
    {
        private List<float> _testList;
        private float _number = 1f;
        private float[] _numbersArray;

        private void Start()
        {
            _testList = new List<float>();
            _numbersArray = new float[] { 1.0f, 2.0f, 3.0f };

            //добавление нового элемента в список
            _testList.Add(_number);
            //добавление в список коллекции или массива
            _testList.AddRange(_numbersArray);
            //бинарный поиск элемента в списке. Если элемент найден, метод возвращает его индекс в коллекции. При этом список должен быть отсортирован.
            _testList.BinarySearch(_number);
            //возвращает индекс первого вхождения элемента в списке
            _testList.IndexOf(_number);
            //вставляет элемент item в списке на позицию index
            _testList.Insert(3, _number);
            //удаляет элемент item из списка. Если удаление прощло успешно, возвращает true
            _testList.Remove(_number);
            //удаляет элемент по указанному индексу index
            _testList.RemoveAt(2);
            //сортировка списка
            _testList.Sort();
        }
    }
}
