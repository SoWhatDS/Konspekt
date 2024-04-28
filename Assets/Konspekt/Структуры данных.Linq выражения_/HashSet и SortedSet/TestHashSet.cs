
using System.Collections.Generic;
using UnityEngine;

public class TestHashSet : MonoBehaviour
{
    //коллукция содержащая только отличающиеся элементы, называется множеством(set)
    // есть HashSet<T> и SortedSet<T>. Класс HashSet<T> содержит неупорядоченный список различающихся элементов,
    //а в SortedSet<T> элементы упорядочены. При использовании данных контейнеров будет весомый прирост производительности на больших коллекциях, так как
    //некоторые операции выполняются быстрее(например Contains, Remove, Add)

    private HashSet<float> _hashSetTest;
    private SortedSet<float> _sortedSetTest;

    private void Start()
    {
        _hashSetTest.Add(1.0f);
        _sortedSetTest.Add(1.0f);
    }
}
