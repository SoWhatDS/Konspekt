
using UnityEngine;
using System.IO;
using System.Xml.Serialization;
using static DataStructures;

namespace SaveDataTest
{
    public class XMLSerializerTest : ISaveData
    {
        string SavePath = Path.Combine(Application.dataPath, "XMLSerialization.xml"); // путь сохранения файла
                                                                                      // (Application. и выбираем DataPath,StreamingAssetsPath,PersistentDataPath,temporaryCachePath)

        private XmlSerializer _serializer;

        public void Save(PlayerData player)
        {
            _serializer = new XmlSerializer(typeof(SVect3[]));
            
        }

        public PlayerData Load()
        {
            PlayerData result = new PlayerData();

            if (!File.Exists(SavePath))
            {
                Debug.Log("File not exist!");
                return result;
            }

            return result;
        }
    }
}
