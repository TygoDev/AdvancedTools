using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject colliderPrefab;
    int amountSpawned;

    private void Start()
    {
        Random.InitState(5);
    }

    // make it spawn 10 every 10 frames
    void LateUpdate()
    {
        Instantiate(colliderPrefab, RandomPointInBounds(GetComponent<BoxCollider>().bounds), Quaternion.identity);
        amountSpawned += 1;
    }

    public static Vector3 RandomPointInBounds(Bounds bounds)
    {
        return new Vector3(
            Random.Range(bounds.min.x, bounds.max.x),
            Random.Range(bounds.min.y, bounds.max.y),
            Random.Range(bounds.min.z, bounds.max.z)
        );
    }

    public int GetAmountSpawned()
    {
        return amountSpawned;
    }
}
