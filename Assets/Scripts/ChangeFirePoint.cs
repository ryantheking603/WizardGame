using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFirePoint : MonoBehaviour
{
    public Transform firePoint;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w")) {
            firePoint.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0.65f, 0);
            firePoint.transform.rotation = Quaternion.Euler(0, 0, 90f);
        }
        else if (Input.GetKeyDown("s")) {
            firePoint.transform.position = new Vector3(player.transform.position.x, player.transform.position.y - 0.65f, 0);
            firePoint.transform.rotation = Quaternion.Euler(0, 0, 270f);
        }
        else if (Input.GetKeyDown("a")) {
            firePoint.transform.position = new Vector3(player.transform.position.x - 0.5f, player.transform.position.y, 0);
            firePoint.transform.rotation = Quaternion.Euler(0, 0, 180f);
        }
        else if (Input.GetKeyDown("d")) {
            firePoint.transform.position = new Vector3(player.transform.position.x + 0.5f, player.transform.position.y, 0);
            firePoint.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
