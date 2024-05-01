
using System.Collections.Generic;
using UnityEngine;

namespace StackTest
{
    internal sealed class StackTest : MonoBehaviour
    {
        //коллекция, которая исполбзует алгоритм LIFO(последний вошёл - первый вышел)
        //три основных метода Push(добавляет элемент в стек на первое место),
        //Pop (извлекает и возвращает первый элемент из стека),Peek(просто возвращает первый элемент из стека без его удаления)
        private void Start()
        {
            Stack<int> numbers = new Stack<int>();

            numbers.Push(1);//1
            numbers.Push(1);//1 1
            numbers.Push(5);//5 1 1
            numbers.Push(2);//2 5 1 1

            Debug.Log(numbers.Peek());//2 5 1 1
            Debug.Log(numbers.Pop());//5 1 1 
        }
    }
}
