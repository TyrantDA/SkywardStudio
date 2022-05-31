using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tilechangerwalk : MonoBehaviour
{

    public Material Material1;
    public Material Material2;

    //in the editor this is what you would set as the object you wan't to change

    void Start()
    {
        this.GetComponent<MeshRenderer>().material = Material1;
    }
    private void OnTriggerEnter(Collider other)
    {
        this.GetComponent<MeshRenderer>().material = Material2;
    }
    private void OnTriggerExit(Collider other)
    {
        this.GetComponent<MeshRenderer>().material = Material1;
    }
}
