using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConttroller : MonoBehaviour
{
    private float speed = 10f;
    private float speedRotation = 60f;
    private float horizontal;
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * speedRotation* Time.deltaTime * horizontal);
        if (Input.GetKey(KeyCode.S))
        {
            speed = 5f;
        }
        else
        {
            speed = 10f;
        }
    }
}
