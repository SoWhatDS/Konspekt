
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System;

namespace LinqTest
{
    internal sealed class LinqTest : MonoBehaviour
    {
        private void Start()
        {
            //LinqWitnOneWhere();
            //LinqWithTwoWhere();
            //TestLinq();
            //OrderByTest();

            ExampleLinq test = new ExampleLinq();
            test.ExampleAverage();
        }
        //пример1
        private void LinqWitnOneWhere()
        {
            int[] numbers = { 1, -2, 3, 0, -4, 5 };

            //создаем запрос получающий только положительные числа
            var posNum = from n // переменная диапазона
                         in numbers // источник данных
                         where n > 0 // предикат(условте) - фильтр данных
                         select n; // полученные данные

            Debug.Log("Положительные числа: ");

            foreach (int i in posNum)
            {
                Debug.Log(i + " ");
            }
        }
        //пример2
        private void LinqWithTwoWhere()
        {
            int[] numbers = { 1, -2, 3, 0, -4, 5 };

            //создаем запрос получающий только положительные числа
            var posNum = from n // переменная диапазона
                         in numbers // источник данных
                         where n > 0 // предикат(условте) - фильтр данных
                         where n < 10 // предикат(условте) - фильтр данных
                         select n; // полученные данные

            Debug.Log("Положительные числа меньше 10: ");

            foreach (int i in posNum)
            {
                Debug.Log(i + " ");
            }
        }
        //пример 3
        private void TestLinq()
        {
            string[] strs = { ".com", ".net", "hsNameA.com", "test", ".network" };

            //создадим запрос, который получает все Интернет-адреса, заканчивающиеся на .net
            var netAddrs = from addr in strs
                           where addr.Length > 4 && addr.EndsWith(".net", StringComparison.Ordinal)
                           //он возвращает логическое значение true, если вызывающая его строка оканчивается последовательностью символов,
                           // указываемой в качестве аргумента этого метода
                           select addr;

            foreach (var str in netAddrs)
            {
                Debug.Log(str);
            }
        }

        //демонстрация OrderBy
        private void OrderByTest()
        {
            int[] nums = { 10, -19, 4, 7, 2, -5, 0 };
            //запрос который получает значения в отсортированном порядке
            var posNums = from n in nums
                          where n > 0
                          orderby n ascending 
                          select n;
            Debug.Log("Значения по возрастанию: ");

            List<int> a = posNums.ToList<int>();

            foreach (int i in posNums)
            {
                Debug.Log(i + " ");
            }

            nums[1] = 10;
            Debug.Log(posNums.Sum());
        }
    }
}
