using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class ShootProjectile : MonoBehaviour
{
    public Transform firePoint;
    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Shoot();
        }
    }

    void Shoot() {
        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
    }
}
