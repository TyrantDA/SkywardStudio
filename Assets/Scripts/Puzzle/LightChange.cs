using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChange : MonoBehaviour
{
    Renderer rend;
    [SerializeField] Material[] material;
    [SerializeField] controlPanel[] cP;
    public LightOnOff powerOn;
    public controlPanel powerOnCP;
    public AudioSource noice;
    bool playedfirst;
    bool playedSecond;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        int hold = 0;
        for(int x = 0; x < cP.Length; x++)
        {
            if(cP[x].getActivated())
            {
                hold++;
            }
        }

        if(hold == 0)
        {
            rend.sharedMaterial = material[0];
        }
        else if(hold == 1)
        {
            rend.sharedMaterial = material[1];
            if (!playedfirst)
            {
                noice.Play();
                playedfirst = true;
            }
        }
        else if(hold == 2)
        {
            rend.sharedMaterial = material[2];
            powerOn.onOff = true;
            powerOnCP.powered = true;
            if (!playedSecond)
            {
                noice.Play();
                playedSecond = true;
            }
        }
    }
}
