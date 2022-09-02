using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColour : MonoBehaviour
{

    public bool colourSet;
    public controlPanel check;
    Renderer rend;
    [SerializeField] Material[] material;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        colourSet = false;
    }


    void Powered()
    {
        if(check.powered)
        {
            colourSet = true;
        }
        else
        {
            colourSet = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        Powered();

        if(!colourSet)
        {
            var hold = rend.materials;
            hold[1] = material[0];
            rend.materials = hold;


        }
        else
        {
            var hold = rend.materials;
            hold[1] = material[1];
            rend.materials = hold;
        }
    }
}
