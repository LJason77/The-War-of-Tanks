using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public GameObject explosionEffect;

    void OnCollisionEnter()
    {
        var tf = transform;
        Instantiate(explosionEffect, tf.position, tf.rotation);
        Destroy(gameObject);
    }
}
