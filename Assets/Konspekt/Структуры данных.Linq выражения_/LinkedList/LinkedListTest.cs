
using System.Collections.Generic;
using UnityEngine;

namespace LinkedListTest
{
    internal sealed class LinkedListTest : MonoBehaviour
    {
        // представляет собой двусвязный список, в котором каждый элемент хранит ссылку одновременно на следующий и на предыдущий элемент
        // каждый узел представляет объект класса LinkedListNode<T>, который имеет следующие свойства: Value(само значение узла),
        // Next (ссылка на следующий элемент, если его нет то null), Previous (ссылка на предыдущий элемент)

        private LinkedList<float> _linkedListTest;
        private float _number = 3.0f;

        private void Start()
        {
            _linkedListTest = new LinkedList<float>();

            //вставляет в список новый узел со значением value после узла node
            _linkedListTest.AddAfter(_linkedListTest.Last,_number);
            //вставляет в список новый узел со значением value перед узлом node
            _linkedListTest.AddBefore(_linkedListTest.Last,_number);
            //вставляет новый узел в начало списка
            _linkedListTest.AddFirst(_number);
            //вставляет новый узел в конец списка
            _linkedListTest.AddLast(_number);
            //удаляет первый узел из списка. После этого первым узлом становится узел, следующий за удаленным
            _linkedListTest.RemoveFirst();
            //удаляет последний узел из списка
            _linkedListTest.RemoveLast();

        }
    }
}
