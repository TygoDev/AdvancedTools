using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{

    [SerializeField] private PerformanceData performanceData = new PerformanceData();

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.S))
            SaveIntoJson();
    }

    public void SaveIntoJson()
    {
        string potion = JsonUtility.ToJson(performanceData);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/PerformanceData.json", potion);
        Debug.Log("saved to: " + Application.persistentDataPath);
    }

}

[System.Serializable]
public class PerformanceData
{
    public string name;
}
