

using UnityEngine;

namespace SaveDataTest
{
    public struct PlayerData
    {
        public string PlayerName;
        public int PlayerHealth;
        public bool PlayerDead;
    }


    internal sealed class Player : MonoBehaviour
    {
        private ISaveData _data;

        public int Health = 100;
        public bool isdead;
        public string Name;

        private void Awake()
        {
            isdead = false;
            Health = 100;

            PlayerData SinglePlayerdata = new PlayerData
            {
                PlayerName = gameObject.name,
                PlayerDead = isdead,
                PlayerHealth = Health
            };

            _data = new XMLData();

            _data.Save(SinglePlayerdata);

            PlayerData newPlayer = _data.Load();

            Debug.Log(newPlayer.PlayerDead);
            Debug.Log(newPlayer.PlayerName);
            Debug.Log(newPlayer.PlayerHealth);
        }


    }
}
