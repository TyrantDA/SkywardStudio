using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPanel : MonoBehaviour
{
    bool activated;

    private void Start()
    {
        activated = false;
    }

    public bool getActivated()
    {
        return activated;
    }
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        if (!activated)
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