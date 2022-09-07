using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    public LightOnOff light1;
    public LightOnOff light2;

    public AudioSource source1;
    public AudioSource source2;

    public Animator anim;

    [SerializeField] GameObject[] enemyList;
    [SerializeField] AudioSource[] noiceList;

    bool anRun;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int lightnumber = 0;
        for (int x = 0; x < enemyList.Length; x++)
        { 
            try
            {
                GameObject hold = enemyList[x];
                Transform hold2 = hold.transform;
            }
            catch (Exception e)
            {
                lightnumber++;
            }
        }

        if(lightnumber >= 1)
        {
            if (!light1.onOff)
            {
                light1.onOff = true;
                source1.Play();
            }
        }
        
        if(lightnumber >= 2)
        {
            if (!light2.onOff)
            {
                light2.onOff = true;
                source2.Play();
            }

            if(!anRun)
            {
                anim.SetTrigger("Move");
                anRun = true;
                for(int x = 0; x < noiceList.Length; x++)
                {

                }
            }
        }
    }
}
