using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X_remove : MonoBehaviour
{
    public GameObject trigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger.gameObject.active == false)
        {
            gameObject.active = false;
        }
    }
}
