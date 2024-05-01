
using System.Collections.Generic;
using UnityEngine;

namespace LinkedListTest
{
    internal sealed class LinkedListSecondTest : MonoBehaviour
    {
        private LinkedList<User> _persons;

        private void Start()
        {
            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddLast(1); //вставляет узел со значением 1 на последнее место
            numbers.AddFirst(2); //вставляет узел со значением 2 на первое место
            numbers.AddAfter(numbers.Last, 3); //вставляет после последнего узла новый узел со значением 3
            // список имеет следующую последовательность 2,1,3

            foreach (var i in numbers)
            {
                Debug.Log(i);
            }

            _persons = new LinkedList<User>();
            LinkedListNode<User> users = _persons.AddLast(new User("Lera", "Petrova"));
            _persons.AddLast(new User("Igor", "Ivanov"));
            _persons.AddFirst(new User("Ilya", "Petrov"));

            Debug.Log(users.Previous.Value.FirstName);
            Debug.Log(users.Next.Value.LastName);
            Debug.Log(users.Value.FirstName);

            //получаем Ilya,Ivanov,Lera

            foreach (var name in _persons)
            {
                Debug.Log(name.FirstName);
            }

            // Ilya,Lera,Igor

            foreach (var name in users.List)
            {
                Debug.Log(name.LastName);
            }

            //Petrov,Petrova,Ivanov
        }
    }
}
