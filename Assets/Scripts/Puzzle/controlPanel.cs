using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controlPanel : MonoBehaviour
{
    public Animator lever;
    public Animator grill;
    public Animator wheel;
    public Animator Antenna;
    public bool powered;
    public AudioSource noice;
    public Text pe;
    public Text tghnp;
    public Text aa;

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
            if(!powered)
            {
                tghnp.gameObject.SetActive(true);
            }
            else
            {
                pe.gameObject.SetActive(true);
            }
        }
        else
        {
            aa.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(!activated)
        {
            collide = false;
            if (!powered)
            {
                tghnp.gameObject.SetActive(false);
            }
            else
            {
                pe.gameObject.SetActive(false);
            }
        }
        else
        {
            aa.gameObject.SetActive(false);
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
                        noice.Play();
                        pe.gameObject.SetActive(false);
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