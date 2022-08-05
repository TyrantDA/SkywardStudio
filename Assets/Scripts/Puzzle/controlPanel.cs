using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPanel : MonoBehaviour
{
    bool activated;
    bool collide;

    private void Start()
    {
        activated = false;
        collide = false;
    }

    public bool getActivated()
    {
        return activated;
    }
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!activated)
        {
            collide = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(!activated)
        {
            collide = false;
        }
    }

    private void Update()
    {
        if (!activated)
        {
            if (collide)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("pressed");
                    activated = true;
                }
                else
                {
                    Debug.Log("need to press E");
                }
            }
        }
    }
}