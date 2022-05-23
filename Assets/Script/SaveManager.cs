using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class SaveManager
{
    //tên folder save
    public static string directoryName="/SaveData/";
    //tên file txt lưu playerData
    public static string fileName="PlayerData.txt";
    //đường dẫn đến folder save
    public static string directory = Application.persistentDataPath + directoryName;
    public static void Save(PlayerData playerData)
    {
       
        // nếu đường dẫn đến folder chứa file txt không tồn tại
        if (!Directory.Exists(directory))
        {
            Debug.Log("Directory not exist");
        }
        else
        {
            //store playerdata with json
            string json = JsonUtility.ToJson(playerData);
            //create file with json data
            File.WriteAllText(directory + fileName, json);
        }
        
    }

    public static PlayerData Load()
    {
        // nếu đường dẫn đến folder chứa file txt không tồn tại
        if (!Directory.Exists(directory))
        {
            //create new one
            Directory.CreateDirectory(directory);
            //create file 
            File.WriteAllText(directory + fileName,"");
        }
        //the directory of file txt for storing playerdata
        string fullpath = Application.persistentDataPath + directoryName + fileName;
        PlayerData playerData = new PlayerData();
        //directory of file txt for storing playerdata is exist?
        if (File.Exists(fullpath))
        {
            //json is created by the file's data
            string json = File.ReadAllText(fullpath);
            //playerData is created by the json's data
            playerData = JsonUtility.FromJson<PlayerData>(json);
        }
        else
        {
            Debug.Log("File not exist, something happend that cant create directory or/and file");
        }
        return playerData;
    }
   
}
