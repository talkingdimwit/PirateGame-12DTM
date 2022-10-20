using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class enemy_controller : MonoBehaviour
{
    private Rigidbody rb;
    public Transform player;
    private float speed = 0.05f;
    private bool challenged = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezePositionY;
    }

    // Update is called once per frame
    void Update()
    {
        if (challenged == true)
        {
            transform.LookAt(player);
            Vector3 direction = player.transform.position - transform.position;
            direction.Normalize();
            transform.Translate(direction * speed, Space.World);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("ball"))
        {
            challenged = false;
            rb.constraints = RigidbodyConstraints.None;
        }
        if (collision.collider.gameObject.CompareTag("Player"))
        {
            challenged = false;
            rb.constraints = RigidbodyConstraints.None;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            challenged = true;
        }
    }
}
