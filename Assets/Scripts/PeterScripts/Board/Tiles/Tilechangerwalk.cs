using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tilechangerwalk : MonoBehaviour
{

    public Material Material1;
    public Material Material2;
    public Material Material3;

    public GameObject player;
    public GameObject inside;
    public bool ocupided;
    public bool target;
    //in the editor this is what you would set as the object you wan't to change

    void Start()
    {
        ocupided = false;
        this.GetComponent<MeshRenderer>().material = Material1;
    }
    private void OnTriggerStay(Collider other)
    {
        ocupided = true;
        inside = other.gameObject;
        if (target == false)
        {
            this.GetComponent<MeshRenderer>().material = Material2;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        ocupided = false;
        inside = null;
        if (target == false)
        {
            this.GetComponent<MeshRenderer>().material = Material1;
        }
    }
    void Update()
    {

        if (target== true)
        {
            this.GetComponent<MeshRenderer>().material = Material3;

        }
        if (player.GetComponent<Playertilemover>().targeting == false)
        {
            target = false;
            if (ocupided == false)
            {
                this.GetComponent<MeshRenderer>().material = Material1;
            }
        }
    }

}
