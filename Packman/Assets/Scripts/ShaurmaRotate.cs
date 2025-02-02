using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaurmaRotate : MonoBehaviour
{
    private float speedRotation = 50f;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(Vector3.up * speedRotation * Time.deltaTime);
    }
}
