using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSet : MonoBehaviour
{
    public controlPanel generator;
    [SerializeField] LightOnOff[] lof;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(generator.getActivated())
        {
            for(int x = 0; x < lof.Length; x++)
            {
                lof[x].onOff = true;
            }
        }
    }
}
