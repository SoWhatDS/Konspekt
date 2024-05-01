
using System.Collections.Generic;
using UnityEngine;

namespace QueueTest
{
    internal sealed class QueueTest : MonoBehaviour
    {
        //представляет собой обычную очередь, работающую по алгоритму FIFO (первый вошёл - первый вышел)
        //основные три метода  Dequeue(извлекает и возвращает первый элемент очереди),Enqueue(добавляет элемент в конец очереди),
        //Peek(возвращает первый элемент из начала очереди без его удаления)

        private Queue<int> _myQueue;

        private void Start()
        {
            _myQueue = new Queue<int>(4);

            _myQueue.Enqueue(1);//1
            _myQueue.Enqueue(1);//1 1
            _myQueue.Enqueue(5);//1 1 5
            _myQueue.Enqueue(2);//1 1 5 2

            Debug.Log(_myQueue.Peek());//1 1 5 2
            Debug.Log(_myQueue.Dequeue());//1 5 2

        }
    }
}
