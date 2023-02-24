using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    public List<PerformanceData> performanceDataList = new List<PerformanceData>();

    private void LateUpdate()
    {
        SaveIntoJson();
    }

    public void SaveIntoJson()
    {
        PerformanceData newPerformanceData = new PerformanceData();

        newPerformanceData.time = Time.time;
        newPerformanceData.fps = 1 / Time.deltaTime;
        newPerformanceData.colliders = 0;
        newPerformanceData.amountOfCollisions = 0;

        performanceDataList.Add(newPerformanceData);

        string jsonStr = JsonConvert.SerializeObject(performanceDataList, Formatting.Indented);

        System.IO.File.WriteAllText(Application.persistentDataPath + "/PerformanceData.json", jsonStr);
    }

}

[System.Serializable]
public class PerformanceData
{
    public float fps;
    public float time;
    public int colliders;
    public int amountOfCollisions;
}
