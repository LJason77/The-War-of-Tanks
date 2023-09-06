using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    [Tooltip("爆炸特效")]
    public GameObject explosionEffect;
    [Tooltip("爆炸特效销毁的延迟时间")]
    public float explosionTimeUp = 1.5f;

    void OnCollisionEnter()
    {
        var tf = transform;
        GameObject effect = Instantiate(explosionEffect, tf.position, tf.rotation);
        Destroy(gameObject);
        Destroy(effect, explosionTimeUp);
    }
}
