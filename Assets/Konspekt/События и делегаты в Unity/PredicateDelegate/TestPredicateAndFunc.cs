
using UnityEngine;

namespace TestPredicateDelegate
{
    public class TestPredicateAndFunc : MonoBehaviour
    {
        [SerializeField] private PredicateAndFuncDelegatesExample _player;
        private const float damage = 50f;

        private void Start()
        {
            _player.Predicate = collision => collision.gameObject.GetComponent<Enemy>();
            _player.Func = armor => armor - damage;

        }
    }
}
