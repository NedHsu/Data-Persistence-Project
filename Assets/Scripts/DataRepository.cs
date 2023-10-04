
using System.IO;
using UnityEngine;

public class DataRepository : IDataRepository
{
    public void UpdateHighestScore(SaveData data)
    {
        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public SaveData LoadData()
    {
        SaveData data = null;
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            data = JsonUtility.FromJson<SaveData>(json);
        }

        return data ?? new SaveData();
    }
}
