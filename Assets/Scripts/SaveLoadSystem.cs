using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace JDevs.Playground2D
{
    [System.Serializable]
    public class SaveDataTest
    {
        public int intData;
        public float floatData;
        public float[] vectorData;

        public SaveDataTest(int intValue, float floatValue, Vector3 vector3Value)
        {
            intData = intValue;
            floatData = floatValue;
            vectorData = new float[3];
            vectorData[0] = vector3Value.x;
            vectorData[1] = vector3Value.y;
            vectorData[2] = vector3Value.z;
        }
    }

    public static class SaveLoadSystem
    {
        public static void Save()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string filepath = Application.persistentDataPath + "/savedata";
            FileStream stream = new FileStream(filepath, FileMode.Create);

            SaveDataTest saveData = new SaveDataTest(10, 22.3f, new Vector3(21, 12, 20.233f));

            formatter.Serialize(stream, saveData);
            stream.Close();

            Debug.Log("Data saved to " + filepath);
            Debug.Log(saveData);
        }

        public static void Load()
        {
            string filepath = Application.persistentDataPath + "/savedata";
            if(File.Exists(filepath))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(filepath, FileMode.Open);

                SaveDataTest saveData = formatter.Deserialize(stream) as SaveDataTest;
                stream.Close();

                Debug.Log("Save data loaded from " + filepath);
                Debug.Log(saveData);
            }
            else
            {
                Debug.LogError("Save file not found in " + filepath);
            }
        }
    }
}
