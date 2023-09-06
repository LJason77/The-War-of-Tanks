using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankWeapon : MonoBehaviour
{
    public GameObject shell;
    public float shootForce = 30f;
    public Transform firePoint;
    
    private AudioSource _audioSource;
    
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }

    private void Fire()
    {
        GameObject shellInstantiate = Instantiate(shell, firePoint.position, firePoint.rotation);
        Rigidbody rb = shellInstantiate.GetComponent<Rigidbody>();
        rb.velocity = firePoint.forward * shootForce;
        _audioSource.Play();
    }
}
