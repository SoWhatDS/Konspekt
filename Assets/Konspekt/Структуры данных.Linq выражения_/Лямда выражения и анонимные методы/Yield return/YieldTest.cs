using System.Collections;
using UnityEngine;

namespace YieldTest
{
    internal sealed class YieldTest : MonoBehaviour
    {
        private void Start()
        {
            User user = new User();

            foreach (string name in user.UsersEnum)
            {
                Debug.Log(name);
            }
        }


        private class User
        {
            private string[] Names =
            {
                "Roman",
                "Ilya",
                "Igor",
                "Lera"
            };

            public IEnumerable UsersEnum
            {
                get
                {
                    for (int i = 0; i < Names.Length; i++)
                    {
                        yield return Names[i];
                    }
                }
            }
        }
    }
}
