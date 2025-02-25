using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 1;
    public Rigidbody2D Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody.linearVelocity = transform.right * speed;
    }

    void OnTriggerEnter2D (Collider2D hitInfo) {

        EnemyHealth enemy = hitInfo.GetComponent<EnemyHealth>();
        if (enemy != null) {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
