using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("ground"))
        {
            Destroy(gameObject);
        }
        if (collision.collider.gameObject.CompareTag("worldGround"))
        {
            Destroy(gameObject);
        }
    }
}