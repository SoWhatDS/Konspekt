
using System;
using System.IO;
using UnityEngine;

namespace SaveDataTest
{
    internal sealed class StreamData : ISaveData
    {
        string SavePath = Path.Combine(Application.dataPath, "StreamData.XYZ");

        public void Save(PlayerData player)
        {
            using (StreamWriter _writer = new StreamWriter(SavePath))
            {
                _writer.WriteLine(player.PlayerName);
                _writer.WriteLine(player.PlayerDead);
                _writer.WriteLine(player.PlayerHealth);
            }
        }

        public PlayerData Load()
        {
            PlayerData result = new PlayerData();

            if (!File.Exists(SavePath))
            {
                Debug.Log("File not exist!");
                return result;
            }

            using (StreamReader _reader = new StreamReader(SavePath))
            {
                result.PlayerName = _reader.ReadLine();
                result.PlayerDead = Convert.ToBoolean(_reader.ReadLine());
                result.PlayerHealth = Convert.ToInt32(_reader.ReadLine());
            }

            return result;
        }
    }
}
