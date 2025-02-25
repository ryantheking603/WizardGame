using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectile1 : MonoBehaviour
{
    public Camera mainCam;
    private Vector3 mousePos;

    // Update is called once per frame
    void Update()
    {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousePos - transform.position;
        float rotationZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0 , rotationZ);
    }
}
