using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    // 默认速度值
    public float moveSpeed = 9f;
    public float rotateSpeed = 90f;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * (moveSpeed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * (moveSpeed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * (rotateSpeed * Time.deltaTime));
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * (rotateSpeed * Time.deltaTime));
        }
    }
}
