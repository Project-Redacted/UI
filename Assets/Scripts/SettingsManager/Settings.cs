using System.IO;
using UnityEngine;

public class Settings : MonoBehaviour
{
    private GameData gameSettings;
    private string fileName = "UserSettings.json";

    public GameData Data => gameSettings;

    public void Load()
    {
        gameSettings = new GameData();
		string json = ReadFromFile(fileName);
		JsonUtility.FromJsonOverwrite(json, gameSettings);
    }

	public void Save()
    {
        string json = JsonUtility.ToJson(gameSettings, true);
        WriteToFile(fileName, json);
    }

	private void WriteToFile(string fileName, string json)
	{
		string realPath = GetFilePath(fileName);
		FileStream fileStream = new FileStream(realPath, FileMode.Create);

		using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.Write(json);
        }
	}

	private string ReadFromFile(string fileName)
	{
		string path = GetFilePath(fileName);
		
		if (File.Exists(path))
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string json = reader.ReadToEnd();
                return json;
            }
        }
        else
        {
            Debug.LogWarning("File not found");
        }

        return "Success";
	}

	private string GetFilePath(string fileName)
    {
        return Application.persistentDataPath + "/" + fileName;
    }

    private void OnApplicationPause(bool pause)
    {
        if (pause) Save();
    }
}
