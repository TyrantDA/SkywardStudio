using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tilechangerwalk : MonoBehaviour
{

    public Material Material1;
    public Material Material2;
    public bool ocupided;
    //in the editor this is what you would set as the object you wan't to change

    void Start()
    {
        ocupided = false;
        this.GetComponent<MeshRenderer>().material = Material1;
    }
    private void OnTriggerEnter(Collider other)
    {
        ocupided = true;

        this.GetComponent<MeshRenderer>().material = Material2;
    }
    private void OnTriggerExit(Collider other)
    {
        ocupided = false;

        this.GetComponent<MeshRenderer>().material = Material1;
    }
}
