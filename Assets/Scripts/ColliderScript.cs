using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    SaveData saveData;
    private void Start()
    {
        saveData = FindObjectOfType<SaveData>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "collider")
        {
            saveData.AddCollision();
        }
    }
}
