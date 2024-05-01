using System.IO;
using UnityEngine;

namespace SaveDataTest
{
    internal sealed class JSONData : ISaveData
    {
        string SavePath = Path.Combine(Application.dataPath,"JSONData.json"); // путь сохранения файла
                                                                          // (Application. и выбираем DataPath,StreamingAssetsPath,PersistentDataPath,temporaryCachePath)
        
        public void Save(PlayerData player)
        {
            
            string FileJSON = JsonUtility.ToJson(player); // преобразовали в JSON
            File.WriteAllText(SavePath,FileJSON); // записали в файл
        }

        public PlayerData Load()
        {
            PlayerData result = new PlayerData();

            if (!File.Exists(SavePath))
            {
                Debug.Log("File not exist!");
                return result;
            }

            string tempJson = File.ReadAllText(SavePath); //если нашло файл, считываем его
            result = JsonUtility.FromJson<PlayerData>(tempJson); //преобразуем из JSON в data структуру
            return result;
        }
    }
}
