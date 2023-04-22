using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    public List<PerformanceData> performanceDataList = new List<PerformanceData>();
    [SerializeField] private Spawner spawner;
    private float amountOfCollisions;

    private void LateUpdate()
    {
        SaveIntoJson();
    }

    public void AddCollision()
    {
        amountOfCollisions += 0.5f;
    }

    public void SaveIntoJson()
    {
        PerformanceData newPerformanceData = new PerformanceData();

        newPerformanceData.time = Time.time;
        newPerformanceData.fps = 1 / Time.deltaTime;
        newPerformanceData.colliders = spawner.GetAmountSpawned();
        newPerformanceData.amountOfCollisions = amountOfCollisions;

        performanceDataList.Add(newPerformanceData);

        string jsonStr = JsonConvert.SerializeObject(performanceDataList, Formatting.Indented);

        System.IO.File.WriteAllText(Application.persistentDataPath + "/PerformanceData.json", jsonStr);
        Debug.Log(Application.persistentDataPath);
    }

}

[System.Serializable]
public class PerformanceData
{
    public float fps;
    public float time;
    public int colliders;
    public float amountOfCollisions;
}
