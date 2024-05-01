using System.Xml;
using System.IO;
using UnityEngine;
using System;

namespace SaveDataTest
{
    internal sealed class XMLData : ISaveData
    {
        string SavePath = Path.Combine(Application.dataPath, "XMLData.xml");

        public void Save(PlayerData player)
        {
            //создали документ XML
            XmlDocument xmlDoc = new XmlDocument();

            //создаем ноду
            XmlNode rootNode = xmlDoc.CreateElement("Player");

            //прикрепляем корневую ноду в документ
            xmlDoc.AppendChild(rootNode);

            //создаем элемент названия игрока
            XmlElement element = xmlDoc.CreateElement("PlayerName");
            element.SetAttribute("value",player.PlayerName); //помещаем значение в этот элемент из нашей структуры данных 
            rootNode.AppendChild(element);//помещаем созданныйэлемент в рутовскую ноду

            element = xmlDoc.CreateElement("PlayerHealth");
            element.SetAttribute("health", player.PlayerHealth.ToString());
            rootNode.AppendChild(element);

            element = xmlDoc.CreateElement("PlayerDead");
            element.SetAttribute("isDead", player.PlayerDead.ToString());
            rootNode.AppendChild(element);

            xmlDoc.Save(SavePath);

        }

        public PlayerData Load()
        {
            PlayerData result = new PlayerData();

            if (!File.Exists(SavePath))
            {
                Debug.Log("File not exist!");
                return result;
            }

            using (XmlTextReader _reader = new XmlTextReader(SavePath))
            {
                while (_reader.Read())
                {
                    if (_reader.IsStartElement("PlayerName"))
                    {
                        result.PlayerName = _reader.GetAttribute("value");
                    }

                    if (_reader.IsStartElement("PlayerHealth"))
                    {
                        result.PlayerHealth = Convert.ToInt32(_reader.GetAttribute("health"));
                    }

                    if (_reader.IsStartElement("PlayerDead"))
                    {
                        result.PlayerDead = Convert.ToBoolean(_reader.GetAttribute("isDead"));
                    }
                }
            }
                return result;
        }

    }
}
