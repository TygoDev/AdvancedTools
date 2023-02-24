using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject colliderPrefab;
    [SerializeField] private int amountToSpawn;
    int amountSpawned;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Random.InitState(5);

            for (int i = 0; i < amountToSpawn; i++)
            {
                Instantiate(colliderPrefab, RandomPointInBounds(GetComponent<BoxCollider>().bounds), Quaternion.identity);
                amountSpawned += 1;
            }
        }
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
