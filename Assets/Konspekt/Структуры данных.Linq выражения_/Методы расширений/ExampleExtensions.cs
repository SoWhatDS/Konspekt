using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using Random = UnityEngine.Random;

namespace ExtensionsTest
{
    public static class ExampleExtensions 
    {
        //добавление в некоторый тип новый метод, но сам класс мы изменить не можем.
        //Метод расширения - это обычный статический метод, который в качестве первого параметра всегда принимает такую конструкцию:this имя_типа название_параметра.

        public static T AddTo<T>(this T self,ICollection<T> coll)
        {
            coll.Add(self);
            return self;
        }

        //проверяет спарсить строку в true или false
        public static bool TryBool(this string self)
        {
            return Boolean.TryParse(self, out var res) && res;
        }

        //проверяет содержится ли значение в массиве
        public static bool IsOneOf<T>(this T self, params T[] elem)
        {
            return elem.Contains(self);
        }

        //проверяет есть ли компонент на объекте, если нет, то добавляет его
        public static T GetOrAddComponent<T>(this Component child) where T : Component
        {
            T result = child.GetComponent<T>() ?? child.gameObject.AddComponent<T>();
            return result;
        }
        //склеивает два массива
        public static T[] Concat<T>(this T[] x, T[] y)
        {
            if (x == null) throw new ArgumentNullException("x");
            if (y == null) throw new ArgumentNullException("y");
            var oldLen = x.Length;
            Array.Resize(ref x, x.Length + y.Length);
            Array.Copy(y, 0, x, oldLen, y.Length);
            return x;
        }

        //выполняет глубокое копирование. Паттерн Prototype(ICloneable)
        public static T DeepCopy<T>(this T self)
        {
            if (!typeof(T).IsSerializable)
            {
                throw new ArgumentException("Type must be isserialezable");
            }

            if (ReferenceEquals(self, null))
            {
                return default;
            }

            var formatter = new BinaryFormatter();
            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream, self);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(stream);
            }
        }

        //позволяет найти ближайшую точку из массива точек к указанной точке в параметре.
        public static int ReturnNearestIndex(this Vector3[] nodes, Vector3 destination)
        {
            var nearestDistance = Mathf.Infinity;
            var index = 0;
            var length = nodes.Length;

            for (int i = 0; i < length; i++)
            {
                var distanceToNode = (destination + nodes[i]).sqrMagnitude;
                if (!(nearestDistance > distanceToNode)) continue;
                nearestDistance = distanceToNode;
                index = i;
            }

            return index;
        }
        //возвращает случайный элемент из списка и при этом данный элемент не должен находится в массиве, который передается в параметр
        public static T ReturnRandom<T>(this List<T> list, T[] itemsToExclude)
        {
            var val = list[Random.Range(0, list.Count)];

            while (itemsToExclude.Contains(val))
            {
                val = list[Random.Range(0, list.Count)];
            }

            return val;
        }
        //возвращает случайный элемент из списка
        public static T ReturnRandom<T>(this List<T> list)
        {
            var val = list[Random.Range(0, list.Count)];
            return val;
        }
        //возвращает случайный элемент из диапазона
        public static float GetRandom(this Vector2 v)
        {
            return Random.Range(v.x, v.y);
        }
        //изменяет значение Vector3 по оси Х
        public static Vector3 MultiplyX(this Vector3 v,float val)
        {
            v = new Vector3(val * v.x, v.y, v.z);
            return v;
        }

        //изменяет значение Vector3 по оси Y
        public static Vector3 MultiplyY(this Vector3 v, float val)
        {
            v = new Vector3( v.x, v.y * val, v.z);
            return v;
        }

        //изменяет значение Vector3 по оси Z
        public static Vector3 MultiplyZ(this Vector3 v, float val)
        {
            v = new Vector3(v.x, v.y, v.z * val);
            return v;
        }
        //позволяет расширить массив на заданное количество элементов
        public static T[] Increase<T>(this T[] values, int increment)
        {
            T[] array = new T[values.Length + increment];
            values.CopyTo(array, 0);
            return array;
        }

        //позволяет найти объект по имени в иерархии
        public static Transform FindDeep(this Transform obj, string id)
        {
            if (obj.name == id)
            {
                return obj;
            }

            var count = obj.childCount;
            for (int i = 0; i < count; i++)
            {
                var posObj = obj.GetChild(i).FindDeep(id);
                if (posObj != null)
                {
                    return posObj;
                }
            }

            return null;

        }

        //позволяет найти все компоненты вложенных объектов
        public static List<T> GetAll<T>(this Transform obj)
        {
            var results = new List<T>();
            obj.GetComponentsInChildren(results);
            return results;
        }

        //позволяет изменить альфу у выбранного цвета
        public static Color SetColorAlpha(this Color c, float alpha)
        {
            return new Color(c.r, c.g, c.b, alpha);
        }
    }
}
