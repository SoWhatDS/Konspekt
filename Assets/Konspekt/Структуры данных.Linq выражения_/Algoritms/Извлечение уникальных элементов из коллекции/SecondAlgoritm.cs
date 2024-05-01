
using System.Collections.Generic;
using UnityEngine;

namespace Algoritms
{
    internal sealed class SecondAlgoritm : MonoBehaviour
    {
        private ICollection<T> GetUniques<T>(ICollection<T> list)
        {
            Dictionary<T, bool> found = new Dictionary<T, bool>();
            List<T> uniques = new List<T>();

            foreach (T val in list)
            {
                if (!found.ContainsKey(val))
                {
                    found[val] = true;
                    uniques.Add(val);
                }
            }

            return uniques;
        }
    }
}
