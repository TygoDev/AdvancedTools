using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swinging : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;
    [SerializeField] private float maxRotation = 30.0f;

    void Update()
    {
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, maxRotation * Mathf.Sin(Time.time * speed));
    }
}
