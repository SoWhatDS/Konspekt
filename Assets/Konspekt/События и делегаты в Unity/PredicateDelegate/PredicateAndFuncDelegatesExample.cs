using System;
using UnityEngine;

namespace TestPredicateDelegate
{
    internal sealed class PredicateAndFuncDelegatesExample : MonoBehaviour
    {
        //Обощённый делегат, который используется для сравнения, сопоставления некоторого объекта T определенному условию.
        //В качестве выходного результата возвращается true, если условие соблюдено, и false, если условие не соблюдено
        public Predicate<Collision> Predicate;
        public Func<float,float> Func;
        private float _armor = 3.0f;
        private float _hp = 100.0f;

        private void OnCollisionEnter(Collision collision)
        {
            if (Predicate(collision))
            {
                _hp -= Func(_armor);
            }

            Debug.Log(_hp);
        }
    }
}
