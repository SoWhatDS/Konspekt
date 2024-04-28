
using UnityEngine;
using UnityEngine.Events;

namespace UnityEventTest
{
    internal sealed class ExampleUnityEvent : MonoBehaviour
    {
        public UnityEvent MyEvent;

        private void OnEnable()
        {
            if (MyEvent == null)
            {
                MyEvent = new UnityEvent();
            }

            MyEvent.AddListener(Ping);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.U))
            {
                MyEvent?.Invoke();
            }
        }

        private void OnDisable()
        {
            if (MyEvent == null)
            {
                MyEvent = new UnityEvent();
            }

            MyEvent.RemoveListener(Ping);
        }

        private void Ping()
        {
            Debug.Log("Ping");
        }
    }
}
