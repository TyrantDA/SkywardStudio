using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPanel : MonoBehaviour
{
    public Animator lever;
    public Animator grill;
    public Animator wheel;
    public Animator Antenna;
    public bool powered;

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
        if (powered)
        {
            if (!activated)
            {
                if (collide)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Debug.Log("pressed");
                        activated = true;
                        lever.SetTrigger("Activate");
                        grill.SetTrigger("MoveGrill");
                        wheel.SetTrigger("MoveWheel");
                        Antenna.SetTrigger("MoveAntenna");
                    }
                    else
                    {
                        Debug.Log("need to press E");
                    }
                }
            }
        }
    }
}