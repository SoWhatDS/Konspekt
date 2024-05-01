
using System.Collections.Generic;
using UnityEngine;

namespace DictionaryTest
{
    internal sealed class DictionaryTest : MonoBehaviour
    {
        private Dictionary<char, string> _newDictionary;

        private void Start()
        {
            _newDictionary = new Dictionary<char, string>();

            _newDictionary.Add('r', "Roman");
            _newDictionary.Add('i',"Ivan");
            _newDictionary.Add('v', "Victoria");

            foreach (KeyValuePair<char,string> user in _newDictionary)
            {
                Debug.Log($"{user.Key} - {user.Value}");
            }

            _newDictionary['i'] = "Inga"; // изменяем элемент с ключом i
            _newDictionary['t'] = "Tom"; // добавляем элемент с ключом t

            foreach (KeyValuePair<char,string> user in _newDictionary)
            {
                Debug.Log($"{user.Key} - {user.Value}");
            }

            _newDictionary.Remove('i'); // удаляем элемент по ключу i

            if (_newDictionary.ContainsKey('i')) // проверяем, имеется ли элемент с ключом i
            {
                var tempUser = _newDictionary['i']; // получаем элемент по ключу i
            }

            //перебор ключей
            foreach (var user in _newDictionary.Keys)
            {
                Debug.Log($"{user}");
            }

            //перебор по значениям
            foreach (var p in _newDictionary.Values)
            {
                Debug.Log($"{p}");
            }

            //initialization
            Dictionary<int, string> dictionary = new Dictionary<int, string>()
            {
                {1,"Roman"},
                {2,"Ivan" },
                {3,"Igor" },
                {4,"Vova" }
            };

            foreach (var name in dictionary)
            {
                Debug.Log($"{name.Value}");
            }

            //initialization new

            Dictionary<int, string> secondDictionary = new Dictionary<int, string>()
            {
                [1] = "Roman",
                [2] = "Ivan",
                [3] = "Igor",
                [4] = "Vova"
            };

            foreach (var name in secondDictionary)
            {
                Debug.Log($"{name.Value}");
            }
        }
    }
}
